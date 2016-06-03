using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySoThu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    
        public ActionResult QuanLyDongVat()
        {
            return PartialView();
        }

 
        public ActionResult QuanLyNhanVien()
        {
            return PartialView();
        }

 
        public ActionResult KhuVeSinh()
        {
            return PartialView();
        }

 
        public ActionResult KhuDieuTri()
        {
            return PartialView();
        }

 
        public ActionResult KhuThucAn()
        {
            return PartialView();
        }
    }
}
