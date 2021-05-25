using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BA_API.Controllers
{
    public class BaoCaoTongHopController : BaseController
    {
        [Route("bao-cao/{type}/toan-quoc")]
        public IActionResult ToanQuoc()
        {
            return View();
        }

        [Route("bao-cao/{type}/so-gtvt")]
        public IActionResult SoGtvt(string id, string start, string end, string vehicleType, int index = 0)
        {
            ViewBag.id = id;
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.vehicleType = vehicleType;
            ViewBag.index = index;
            return View();
        }

        [Route("bao-cao/{type}/don-vi-van-tai")]
        public IActionResult DonViVanTai(string company, string start, string end, string vehicleType, string vehicle, string department, int index = 0)
        {
            ViewBag.company = company;
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.vehicleType = vehicleType;
            ViewBag.vehicle = vehicle;
            ViewBag.index = index;
            ViewBag.department = department;
            return View();
        }


        [Route("bao-cao/{type}/don-vi-truyen-du-lieu")]
        public IActionResult DonViTruyenDuLieu(string id, string start, string end, string companyId, string vehicle, string departmentId, int index = 0)
        {
            ViewBag.id = id;
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.companyId = companyId;
            ViewBag.vehicle = vehicle;
            ViewBag.index = index;
            ViewBag.departmentId = departmentId;
            return View();
        }

        [Route("bao-cao/{type}/phuong-tien-vi-pham")]
        public IActionResult PhuongTienViPham(string department_id, string start, string end, string provider_id, int index = 0)
        {
            ViewBag.department_id = department_id;
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.provider_id = provider_id;
            ViewBag.index = index;
            return View();
        }

        [Route("bao-cao/{type}/lich-su-hinh-anh-lai-xe")]
        public IActionResult LichSuHinhAnhLaiXe(string plate, long start, long end)
        {
            ViewBag.plate = plate;
            ViewBag.start = start;
            ViewBag.end = end;
            return View();
        }

        [Route("bao-cao/{type}/anh-vi-pham")]
        public IActionResult AnhViPham()
        {
            return View();
        }

    }
}
