using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chit_Chat.Models;


namespace Chit_Chat.Controllers
{
    public class LoginController : Controller
    {

        static List<Login> Log = new List<Login>();
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
	}
}