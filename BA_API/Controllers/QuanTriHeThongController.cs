using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace BA_API.Controllers
{
    public class QuanTriHeThongController : BaseController
    {
        [Route("quan-tri/quan-ly-nguoi-dung")]
        public IActionResult QuanLyNguoiDung(string username, string roleId, string status, int index = 0)
        {
            ViewBag.username = username;
            ViewBag.roleId = roleId;
            ViewBag.status = status;
            ViewBag.index = index;
            return View();
        }
        [Route("quan-tri/phan-quyen-he-thong")]
        public IActionResult PhanQuyenHeThong()
        {
            return View();
        }
        [Route("quan-tri/nhom-nguoi-dung")]
        public IActionResult NhomNguoiDung()
        {
            return View();
        }
        [Route("quan-tri/nhat-ky-truy-cap")]
        public IActionResult NhatKyTruyCap(string username, long start, long end, int index = 0)
        {
            ViewBag.username = username;
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.index = index;
            return View();
        }
        [Route("quan-tri/chuc-nang--he-thong")]
        public IActionResult ChucNangHeThong()
        {
            return View();
        }
    }
}
