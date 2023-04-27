using ProjetASP.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.net.Controllers
{
    public class VoitureController : Controller
    {
        private DataBaseDataContext db = new DataBaseDataContext();

        [HttpGet]
        public ActionResult Index(int? VoitureId)
        {
            if (VoitureId != null)
            {
                Voiture_info voiture = (from v in db.Voitures
                                        join p in db.Users on v.Proprietaire equals p.Id
                                        where v.Id == VoitureId
                                        select new Voiture_info { voiture = v, user = p }).FirstOrDefault();


                var listvoiture = from v in db.Voitures
                                  where v.Proprietaire == voiture.user.Id
                                  select new Voiture_info { voiture = v, user = voiture.user };

                ViewBag.info = voiture;
                ViewBag.list = listvoiture;
                return View();
            }
            else
                return RedirectToAction("Index", "Home");
        }

        public ActionResult ListVoiture(DateTime? dateDispo = null)
        {
            var listVoiture = from v in db.Voitures
                              join p in db.Users on v.Proprietaire equals p.Id
                              select new Voiture_info { voiture = v, user = p };
            if (dateDispo != null)
            {
                var res = from r in db.Reservations
                          where (r.DateDebut < dateDispo && r.DateFin > dateDispo)
                          select r.Voiture;

                List<Voiture_info> listVoitureDispo = listVoiture.Where(v => !res.Contains(v.voiture.Id)).ToList();
            }

            return View(listVoiture.ToList());


        }
        [HttpPost]
        public ActionResult ListVoiture(string TextRecherche, string RecherchePar)
        {
            try
            {
                if (RecherchePar.Equals("Nom"))
                {
                    var listVoiture = from v in db.Voitures
                                      join p in db.Users on v.Proprietaire equals p.Id
                                      where v.Nom.Contains(TextRecherche)
                                      select new Voiture_info { voiture = v, user = p };

                    return View(listVoiture.ToList());
                }
                if (RecherchePar.Equals("Marque"))
                {
                    var listVoiture = from v in db.Voitures
                                      join p in db.Users on v.Proprietaire equals p.Id
                                      where v.Marque.Contains(TextRecherche)
                                      select new Voiture_info { voiture = v, user = p };

                    return View(listVoiture.ToList());
                }
                if (RecherchePar.Equals("Couleur"))
                {
                    var listVoiture = from v in db.Voitures
                                      join p in db.Users on v.Proprietaire equals p.Id
                                      where v.Couleur.Contains(TextRecherche)
                                      select new Voiture_info { voiture = v, user = p };

                    return View(listVoiture.ToList());
                }
                if (RecherchePar.Equals("Annee"))
                {
                    var listVoiture = from v in db.Voitures
                                      join p in db.Users on v.Proprietaire equals p.Id
                                      where v.Modele == Convert.ToInt32(TextRecherche)
                                      select new Voiture_info { voiture = v, user = p };

                    return View(listVoiture.ToList());

                }
                if (RecherchePar.Equals("Km"))
                {
                    var listVoiture = from v in db.Voitures
                                      join p in db.Users on v.Proprietaire equals p.Id
                                      where v.Kilometrage == Convert.ToInt32(TextRecherche)
                                      select new Voiture_info { voiture = v, user = p };

                    return View(listVoiture.ToList());
                }
                if (RecherchePar.Equals("Proprietaire"))
                {
                    var listVoiture = from v in db.Voitures
                                      join p in db.Users on v.Proprietaire equals p.Id
                                      where p.Name.Contains(TextRecherche)
                                      select new Voiture_info { voiture = v, user = p };

                    return View(listVoiture.ToList());
                }
            }
            catch (Exception) { }
            return View();
        }




        public ActionResult Reserver(int id)
        {

            res(id);


            return View(false);
        }
        [HttpPost]
        public ActionResult Reserver(string nom, string email, string phone, string addresse, string paiement, int jours, DateTime date, int voitureId = 4)
        {
            //  DateTime date = DateTime.Now;
            int? UserId = (from u in db.Users
                           where u.Email.Equals(email)
                           select u.Id).FirstOrDefault();


            Reservation r = new Reservation
            {
                Locataire = UserId,
                Voiture = voitureId,
                Nom = nom,
                Email = email,
                Phone = phone,
                Adresse = addresse,
                DateDebut = Convert.ToDateTime(date),
                DateFin = Convert.ToDateTime(date).AddDays(jours),
                Paiment = paiement,
                Status = 0,
            };
            db.Reservations.InsertOnSubmit(r);
            db.SubmitChanges();

            //-------------------------------
            res(voitureId);

            return View(true);
        }

        void res(int id)
        {
            int userid = Convert.ToInt32(Session["UserId"]);

            User user = db.Users.Where(r => r.Id == userid).FirstOrDefault();

            Voiture voiture = (from v in db.Voitures
                               where v.Id == id
                               select v).FirstOrDefault();

            ViewBag.voiture = voiture;
            ViewBag.date = DateTime.Now;

            if (user == null)
                ViewBag.user = new User { Name = " ", Address = " ", Phone = " ", Email = " " };
            else
                ViewBag.user = user;



        }

    }

}


