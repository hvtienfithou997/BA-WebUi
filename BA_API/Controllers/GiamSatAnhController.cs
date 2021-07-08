using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BA_API.Controllers
{
    public class GiamSatAnhController : Controller
    {
        [Route("he-thong-giam-sat-anh/giam-sat-anh")]
        public IActionResult GiamSatAnh()
        {
            return View();
        }
    }
}
