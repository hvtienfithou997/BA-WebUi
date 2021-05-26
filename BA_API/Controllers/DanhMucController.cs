using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BA_API.Controllers
{
    public class DanhMucController : Controller
    {
        [Route("danh-muc/phuong-tien")]
        public IActionResult PhuongTien(string providerId, string departmentId, string companyId, string vehicle, string type, int index = 0)
        {
            ViewBag.providerId = providerId;
            ViewBag.departmentId = departmentId;
            ViewBag.companyId = companyId;
            ViewBag.vehicle = vehicle;
            ViewBag.type = type;
            ViewBag.index = index;
            return View();
        }

        [Route("danh-muc/don-vi-van-tai")]
        public IActionResult VanTai(string departmentid, string companyid, int index = 0)
        {
            ViewBag.departmentid = departmentid;
            ViewBag.companyid = companyid;
            ViewBag.index = index;
            return View();
        }

        [Route("danh-muc/danh-sach-tinh")]
        public IActionResult DanhSachTinh()
        {
            return View();
        }
        [Route("danh-muc/danh-sach-don-vi-truyen-du-lieu")]
        public IActionResult DonViTruyenDuLieu()
        {
            return View();
        }
    }
}
