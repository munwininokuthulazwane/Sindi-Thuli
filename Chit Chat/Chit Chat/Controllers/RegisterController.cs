using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chit_Chat.Models;

namespace Chit_Chat.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/

        // static List<sonal> sun = new List<sonal>();
        static List<Register> Reg = new List<Register>();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
       


        

	}
}