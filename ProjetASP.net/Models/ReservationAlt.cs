using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.net.Models
{
    public class ReservationAlt
    {
        public int Id;
        public DateTime Date;
        public string VoitureNom;
        public string VoitureMarque;
        public int VoituresPrix;
        public string LocataireNom;
        public string LocataireAdresse;
        public string LocataireTele;
        public int Jours;
        public string Pay;
        public int Status;

        public ReservationAlt(int id,DateTime date, string voitureNom, string voitureMarque, int voituresPrix, string locataireNom, string locataireAdresse, string locataireTele, int jours, string pay, int status)
        {
            Id = id;
            Date = date;
            VoitureNom = voitureNom;
            VoitureMarque = voitureMarque;
            VoituresPrix = voituresPrix;
            LocataireNom = locataireNom;
            LocataireAdresse = locataireAdresse;
            LocataireTele = locataireTele;
            Jours = jours;
            Pay = pay;
            Status = status;
        }
    }
}