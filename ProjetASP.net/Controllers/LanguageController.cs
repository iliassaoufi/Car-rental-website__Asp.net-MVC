using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Globalization;

namespace ProjetASP.net.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Change(string LanguageAbreviation)
        {
            if (LanguageAbreviation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbreviation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbreviation);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LanguageAbreviation;
            Response.Cookies.Add(cookie);
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}