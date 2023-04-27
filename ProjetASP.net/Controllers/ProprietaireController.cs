using ProjetASP.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.net.Controllers
{
    [SessionCheck(Role = "Proprietaire")]
    public class ProprietaireController : Controller
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        // GET: Proprietaire

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListProprietaire()
        {
            return View();
        }
        public ActionResult Proprietaire_Page(int? id)
        {
            if (id != null)
            {
                User prop = (from p in db.Users
                             where p.Id == id
                             select p).FirstOrDefault();
                var listvoiture = from v in db.Voitures
                                  where v.Proprietaire == prop.Id
                                  select new Voiture_info { voiture = v, user = prop };
                ViewBag.prop = prop;
                ViewBag.listVoiture_prop = listvoiture;

                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Proprietaire_Info()
        {
            var query = (from user in db.Users
                         where user.Id.Equals(Convert.ToInt32(Session["UserId"]))
                         select user).First();
            ViewBag.User = (User)query;
            return View();
        }
        public ActionResult Update_Proprietaire_Info(int Id, string name, string email, string adresse, string tele)
        {
            User user = new User()
            {
                Id = Id,
                Name = name,
                Email = email,
                Address = adresse,
                Phone = tele,
            };
            ViewBag.User = user;
            return View();
        }

        [HttpPost]
        public ActionResult Update_Proprietaire_Info(string nom, string tele, string email, string adresse)
        {
            User u = (from user in db.Users
                      where user.Id.Equals(Convert.ToInt32(Session["UserId"]))
                      select user).First();
            u.Name = nom;
            u.Phone = tele;
            u.Email = email;
            u.Address = adresse;
            db.SubmitChanges();
            return RedirectToAction("Proprietaire_Info");
        }
        public ActionResult reservation()
        {
            var reservations = from r in db.Reservations
                               join voiture in db.Voitures on r.Voiture equals voiture.Id
                               where voiture.Proprietaire.Equals(Convert.ToInt32(Session["UserId"]))
                               select new Voiture_info { reservation = r, voiture = voiture };


            ViewBag.Reservations = reservations.ToList();
            return View();
        }
        public ActionResult Liste_Voiture()
        {
            var query = (from v in db.Voitures
                         where v.Proprietaire.Equals(Convert.ToInt32(Session["UserId"]))//
                         select v).ToList();
            ViewBag.voitures = query;
            return View();
        }
        public ActionResult Ajouter_voiture()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ajouter_Voiture(string Name, string Imm, string Color, int kilom, int modele, string transition, int price, HttpPostedFileBase image, string offre, string marque)
        {
            Voiture v = new Voiture()
            {
                Proprietaire = Convert.ToInt32(Session["UserId"]),
                Nom = Name,
                Immatriculation = Imm,
                Couleur = Color,
                Kilometrage = kilom,
                Modele = modele,
                Transition = transition,
                Prix = price,
                Image = image.FileName,
                Marque = marque,

            };

            if (offre.Equals("true")) v.Offre = 1;
            else v.Offre = 0;
            db.Voitures.InsertOnSubmit(v);
            db.SubmitChanges();
            ViewBag.msg = "Voiture ajoutée !";
            return View("Ajouter_voiture");
        }
        public ActionResult Update_voiture(int VoitureId)
        {
            var v = (from voiture in db.Voitures
                     where voiture.Id.Equals(VoitureId)
                     select voiture).First();
            ViewBag.Voiture = v;
            return View();
        }

        [HttpPost]
        public ActionResult Update_voiture(int id, string Name, string Imm, string Color, int kilom, int modele, string transition, int price, HttpPostedFileBase image, string offre, string marque)
        {
            var voiture = (from v in db.Voitures
                           where v.Id.Equals(id)
                           select v).First();
            voiture.Nom = Name;
            voiture.Immatriculation = Imm;
            voiture.Couleur = Color;
            voiture.Kilometrage = kilom;
            voiture.Modele = modele;
            voiture.Transition = transition;
            voiture.Prix = price;
            voiture.Marque = marque;
            if (image != null) voiture.Image = image.FileName;

            if (offre.Equals("true")) voiture.Offre = 1;
            else voiture.Offre = 0;
            db.SubmitChanges();
            return Redirect("Liste_Voiture");
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
            return RedirectToAction("Liste_Voiture");
        }

        public ActionResult Valider(int resId)
        {
            var r = (from res in db.Reservations
                     where res.Id.Equals(resId)
                     select res).First();
            r.Status = 1;
            db.SubmitChanges();
            return RedirectToAction("reservation");
        }

        public ActionResult Supprimer(int resId)
        {
            var r = (from res in db.Reservations
                     where res.Id.Equals(resId)
                     select res).First();
            r.Status = -1;
            db.SubmitChanges();
            return RedirectToAction("reservation");
        }
    }
}