using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaMa.Framework.Core.Web.Controllers;


namespace LaMa.ResourceManagment.Web.Controllers
{
    public class HomeController : LaMaController
    {
        // GET: Home
        public ActionResult Index()
        { 
 
            return View();
        }
    }
}