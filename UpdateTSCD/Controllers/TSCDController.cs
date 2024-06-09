using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UpdateTSCD.Controllers
{
    public class TSCDController : Controller
    {
        // GET: TSCD
        public ActionResult Index()
        {
            return View();
        }
        DanhSachTSCDBusiness danhSachTSCD = new DanhSachTSCDBusiness();
        public ActionResult DanhSach(string tuKhoa)
        {
            ViewBag.tuKhoa = tuKhoa;
            List<DanhSachTSCD> lstTSCD = danhSachTSCD.TimKiemTSCD(tuKhoa);
            return View(lstTSCD);
        }
        public ActionResult ThemMoi()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemMoi(DanhSachTSCD objTSCD, HttpPostedFileBase fUpload)
        {
            if(objTSCD != null)
            {
                objTSCD.NgayTao=DateTime.Now;
                if(fUpload != null && fUpload.ContentLength > 0)
                {
                    string imgName = Path.GetFileName(fUpload.FileName);
                    fUpload.SaveAs(Server.MapPath("~/Content/Images/" + imgName));
                    objTSCD.Photo = imgName;
                }
                bool keQua =danhSachTSCD.ThemMoi(objTSCD);
                if (keQua)
                {
                    return RedirectToAction("DanhSach");
                }
            }
            return View(objTSCD);
        }
        public ActionResult Sua(int id)
        {
            DanhSachTSCD objTSCD = danhSachTSCD.LayChiTiet(id);
            if(objTSCD != null)
            {
                return View(objTSCD);
            }
            return HttpNotFound();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sua(int id, DanhSachTSCD objTSCD, HttpPostedFileBase fUpload)
        {
            if (objTSCD != null)
            {
                if(fUpload != null && fUpload.ContentLength > 0)
                {
                    string imgName = Path.GetFileName(fUpload.FileName);
                    fUpload.SaveAs(Server.MapPath("~/Content/Images/" + imgName));
                    objTSCD.Photo = imgName;

                }
                bool keQua = danhSachTSCD.CapNhat(objTSCD);
                if (keQua)
                {
                    return RedirectToAction("DanhSach");
                }

            }
            return View(objTSCD);
        }
        public ActionResult Xoa(int id)
        {
            if (id > 0)
            {
                bool ketQua = danhSachTSCD.Xoa(id);
                if (ketQua)
                {
                    return RedirectToAction("DanhSach");
                }
            }
            return View();
        }
    }
}
