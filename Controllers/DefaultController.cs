using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Microsoft.Ajax.Utilities;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default

        DbCvEntities db = new DbCvEntities();

        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult SosyalMedya()
        {
            var sosyalMedya = db.TblSosyalMedya.Where(x => x.Durum == true).ToList();
            return PartialView(sosyalMedya);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimler.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitim()
        {
            var egitimler = db.TblEgitimler.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yetenek()
        {
            var yetenekler = db.TblYetenekler.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobiler()
        {
            var hobiler = db.TblHobiler.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifika()
        {
            var sertifikalar = db.TblSertifikalar.ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult iletisim(Tbliletisim t)
        {
            try
            {
                t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                db.Tbliletisim.Add(t);
                db.SaveChanges();

                return Json(new { success = true, message = "Mesaj Başarıyla Gönderildi." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Mesaj Gönderilirken Bir Hata Oluştu." });
            }
        }
    }
}