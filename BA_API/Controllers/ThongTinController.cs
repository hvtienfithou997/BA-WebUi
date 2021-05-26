using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BA_API.Controllers
{
    public class ThongTinController : Controller
    {
        public IActionResult ThongTin()
        {
            return View();
        }
    }
}
