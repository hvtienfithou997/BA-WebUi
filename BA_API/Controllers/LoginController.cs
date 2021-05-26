using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace BA_API.Controllers
{
    public class LoginController : BaseController
    {
        //[Route("nguoi-dung/dang-nhap-he-thong")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            ViewBag.ReturnUrl = HttpContext.Request.Query["ReturnUrl"].ToString();
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(string username, string passwords)
        {
            string msg = "";
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                user = HttpContext.Request.Form["username"].ToString(),
                pass = HttpContext.Request.Form["password"].ToString()
            });



            return View();
        }



    }
}
