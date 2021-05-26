using BA_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BA_API.Controllers
{
    public class TrangChuController : BaseController
    {
        [Route("he-thong-giam-sat-anh/trang-chu")]
        public IActionResult TrangChu()
        {
            return View();
        }
    }
}
