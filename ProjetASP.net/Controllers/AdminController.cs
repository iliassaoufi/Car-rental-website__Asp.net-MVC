using ProjetASP.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.net.Controllers
{
    public class AdminController : Controller
    {
        private DataBaseDataContext db = new DataBaseDataContext();

        private bool checkAdmin()
        {
            int id = Convert.ToInt32(Session["UserId"]);

            var admin = db.Users.Where(r => r.Id == id).FirstOrDefault();
            if (admin == null)
                return false;
            else
                return true;
        }
        public ActionResult Index()
        {
            if (!checkAdmin())
                return RedirectToAction("Index", "Home");
            int nbrAllUser = db.Users.Count();
            int nbrPropUser = db.Users.Where(r => r.Role.Contains("Proprietaire")).Count();
            int nbrLocataireUser = db.Users.Where(r => r.Role.Contains("Locataire")).Count();
            int nbrReservation = db.Reservations.Count();
            var ListReservatoin = db.Reservations.GroupBy(r => r.DateDebut.Value.Date);

            ViewBag.nbrAllUser = nbrAllUser;
            ViewBag.nbrPropUser = nbrPropUser;
            ViewBag.nbrLocataireUser = nbrLocataireUser;
            ViewBag.nbrReservation = nbrReservation;
            ViewBag.ListReservatoin = ListReservatoin;

            return View();
        }
        public ActionResult Gestion_profil(int id = -1, string op = "")
        {
            if (!checkAdmin())
                return RedirectToAction("Index", "Home");
            if (id != -1 && !op.Equals(""))
            {
                if (op.Equals("fav"))
                {
                    User us = db.Users.Where(u => u.Id == id).FirstOrDefault();
                    us.Category = 1;
                    db.SubmitChanges();
                }
                if (op.Equals("noir"))
                {
                    User us = db.Users.Where(u => u.Id == id).FirstOrDefault();
                    us.Category = -1;
                    db.SubmitChanges();
                }
                if (op.Equals("sup"))
                {
                    User us = db.Users.Where(u => u.Id == id).FirstOrDefault();
                    db.Users.DeleteOnSubmit(us);
                    db.SubmitChanges();
                }
            }

            return View(db.Users.ToList());
        }

        public ActionResult Gestion_Voiture()
        {
            if (!checkAdmin())
                return RedirectToAction("Index", "Home");
            var query = (from v in db.Voitures                         //
                         select v).ToList();
            ViewBag.voitures = query;
            return View();

        }
        public ActionResult Delete(int VoitureId)
        {
            var RES = (from res in db.Reservations
                       where res.Voiture.Equals(VoitureId)
                       select res).ToList();
            RES.ForEach(res => db.Reservations.DeleteOnSubmit(res));
            db.SubmitChanges();
            var query2 = (from voiture in db.Voitures
                          where voiture.Id.Equals(VoitureId)
                          select voiture).First();
            db.Voitures.DeleteOnSubmit(query2);
            db.SubmitChanges();
            return RedirectToAction("Gestion_Voiture");
        }
        public ActionResult Gestion_Resevation()
        {
            var reservations = from r in db.Reservations
                               join voiture in db.Voitures on r.Voiture equals voiture.Id

                               select new Voiture_info { reservation = r, voiture = voiture };


            ViewBag.Reservations = reservations.ToList();
            return View();
        }
        public ActionResult Gestion_message()
        {
            if (!checkAdmin())
                return RedirectToAction("Index", "Home");
            var msg = from m in db.Messages
                      select m;
            return View(msg);
        }
    }
}