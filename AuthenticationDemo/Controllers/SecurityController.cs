using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthenticationDemo.Models;

namespace AuthenticationDemo.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userInDb = UserInit.Init().FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid User. Wrong Username or Password";
                return View();
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Security");
        }
    }
}