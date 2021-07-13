using Microsoft.AspNetCore.Mvc;

namespace BA_API.Controllers
{
    public class BaoCaoKhongTruyenDuLieuController : Controller
    {
        [Route("bao-cao-khong-truyen-du-lieu/so-gtvt")]
        public IActionResult SoGtvt(string department, string companyId, string vehicle, int start, int end, int index = 0)
        {
            ViewBag.department = department;
            ViewBag.companyId = companyId;
            ViewBag.vehicle = vehicle;
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.index = index;
            return View();
        }

        [Route("bao-cao-khong-truyen-du-lieu/dvtdl")]
        public IActionResult DVTDL(string provider, string departmentId, string companyId, string vehicle, int start, int end, int index = 0)
        {
            ViewBag.departmentId = departmentId;
            ViewBag.provider = provider;
            ViewBag.companyId = companyId;
            ViewBag.vehicle = vehicle;
            ViewBag.start = start;
            ViewBag.end = end;
            ViewBag.index = index;

            return View();
        }

        [Route("bao-cao-khong-truyen-du-lieu/lien-tiep")]
        public IActionResult LienTiep()
        {
            return View();
        }
    }
}