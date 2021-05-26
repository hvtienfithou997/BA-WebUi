using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BA_API.Controllers
{
    public class BaoCaoTruyenDuLieuController : BaseController
    {
        [Route("bao-cao-truyen-du-lieu/{type}/toan-quoc")]
        public IActionResult ToanQuoc(string date)
        {
            ViewBag.date = date;
            return View();
        }

        [Route("bao-cao-truyen-du-lieu/{type}/so-gtvt")]
        public IActionResult SoGtvt(string department, string date, string index)
        {
            ViewBag.department = department;
            ViewBag.date = date;
            ViewBag.index = index;
            return View();
        }

        [Route("bao-cao-truyen-du-lieu/{type}/don-vi-van-tai")]
        public IActionResult DonViVanTai(string companyId, string date, string department, string index)
        {
            ViewBag.companyId = companyId;
            ViewBag.date = date;
            ViewBag.index = index;
            ViewBag.department = department;
            return View();
        }

        [Route("bao-cao-truyen-du-lieu/{type}/bien-so-xe")]
        public IActionResult BienSoXe(string vehicle, string start, string end)
        {
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.vehicle = vehicle;
            return View();
        }


        [Route("bao-cao-truyen-du-lieu/{type}/don-vi-truyen-du-lieu")]
        public IActionResult DonViTruyenDuLieu(string provider, string companyId, string vehicle, string date, string index)
        {
            ViewBag.provider = provider;
            ViewBag.companyId = companyId;
            ViewBag.vehicle = vehicle;
            ViewBag.date = date;
            ViewBag.index = index;
            return View();
        }
    }
}
