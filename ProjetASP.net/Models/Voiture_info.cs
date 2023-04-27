using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetASP.net.Models
{
    public class Voiture_info
    {
        public User user;
        public Voiture voiture;
        public Reservation reservation = null;
    }
}