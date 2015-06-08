using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pruebas_ASP_C_sharp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private String nombre { get; set; }

        public ActionResult Index()
        {
            
            return View();
        }

    }
}
