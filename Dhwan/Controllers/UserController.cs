using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dhwan.Models;

namespace Dhwan.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}