using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Views.Home
{
    public class OverdueController : Controller
    {
        // GET: Overdue
        public ActionResult Index()
        {
            return View();
        }
    }
}