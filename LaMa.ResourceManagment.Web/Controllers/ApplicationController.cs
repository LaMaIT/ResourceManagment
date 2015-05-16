using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaMa.Framework.Core.Web.Controllers;
using LaMa.ResourceManagment.Business;
using LaMa.ResourceManagment.Web.Models;

namespace LaMa.ResourceManagment.Web.Controllers
{
    public class ApplicationController : LaMaController
    {
      
        public ActionResult Index()
        {
            var applicationService = new ApplicationService();
            var viewModel = new ApplicationVM(applicationService.GetApplications(true));
            return View(viewModel);
        } 
       
        
    }
}