using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurizmDB.Models;


namespace TurizmDB.Controllers
{
    public class DefaultController : Controller
    {
       
        public ActionResult Index()
        {
            TurizmDBEntities db = new TurizmDBEntities();
            List<Havalimanlari> allHavalimanlari = db.Havalimanlari.ToList();
            ViewBag.Havalimanlari = allHavalimanlari;
            return View();
        }

        public ActionResult Havalimanlari()
        {

            return View();
        }

        public ActionResult EkleHavalimani(AddHavalimaniRequest request)
        {

            Havalimanlari havalimanlari = new Havalimanlari();
            havalimanlari.HavalimaniAdi = request.Ad;
            havalimanlari.Sehir = request.Sehir;
            TurizmDBEntities db = new TurizmDBEntities();
            db.Havalimanlari.Add(havalimanlari);
            db.SaveChanges();
            return RedirectToAction("Index");
           
        }

        public ActionResult UpdateHavalimani()
        {
            int havalimaniId = Convert.ToInt32(Request.QueryString["id"]);
            TurizmDBEntities db = new TurizmDBEntities();
            Havalimanlari havalimanlari = db.Havalimanlari.Where(p => p.HavalimaniId == havalimaniId).SingleOrDefault();
            return View(havalimanlari);
        }

        public ActionResult Update(UpdateHavalimaniRequest request)
        {
            TurizmDBEntities db = new TurizmDBEntities();
            Havalimanlari update = db.Havalimanlari.Where(p => p.HavalimaniId == request.Id).SingleOrDefault();
            update.HavalimaniAdi = request.Ad;
            update.Sehir = request.Sehir;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult VarisNoktalari()
        {
            TurizmDBEntities db = new TurizmDBEntities();
            List<VarisNoktalari> allVarisNoktalari = db.VarisNoktalari.ToList();
            ViewBag.VarisNoktalari = allVarisNoktalari;

            return View();

        }
        public ActionResult AddVarisNoktalari()
        {
            return View();
        }

        public ActionResult EkleVaris(AddVarisNoklariRequest request)
        {
            VarisNoktalari varisNoktalari = new VarisNoktalari();
            varisNoktalari.VarisNokta = request.VarisNokta;
            varisNoktalari.HavaLimaniId = request.HavaLimaniId;
            TurizmDBEntities db = new TurizmDBEntities();
            db.VarisNoktalari.Add(varisNoktalari);
            db.SaveChanges();
            return RedirectToAction("VarisNoktalari");
           
        }

        public ActionResult UpdateVaris()
        {
            int varisId = Convert.ToInt32(Request.QueryString["id"]);
            TurizmDBEntities db = new TurizmDBEntities();
            VarisNoktalari varisNokta = db.VarisNoktalari.Where(p => p.VarisNoktaId == varisId).SingleOrDefault();
            return View(varisNokta);
           
          
        }

        public ActionResult UpdateVarisNoktalari(UpdateVarisNoktalariRequest request)
        {
            TurizmDBEntities db = new TurizmDBEntities();
            VarisNoktalari updateVaris = db.VarisNoktalari.Where(p => p.VarisNoktaId == request.VarisNoktaId).SingleOrDefault();
            updateVaris.VarisNokta = request.VarisNokta;
            updateVaris.HavaLimaniId = request.HavalimaniId;
            db.SaveChanges();
            return RedirectToAction("VarisNoktalari");
          
        }

        public ActionResult Müsteri()
        {
            TurizmDBEntities db = new TurizmDBEntities();
            List<Musteri> allMusteri = db.Musteri.ToList();
            ViewBag.Musteri = allMusteri;
            return View();
        }


        public ActionResult Müsteriler()
        {
            return View();
        }

        public ActionResult AddMüsteri(AddMüsteriRequest request)
        {

            Musteri musteri = new Musteri();
            musteri.Adi = request.Ad;
            musteri.Soyadi = request.Soyad;
            musteri.Email = request.Email;
            musteri.EvTel = request.EvTel;
            musteri.CepTel = request.CepTel;
            musteri.EvAdresi = request.EvAdres;
            TurizmDBEntities db = new TurizmDBEntities();
            db.Musteri.Add(musteri);
            db.SaveChanges();
            return RedirectToAction("Müsteri");
        }

        public ActionResult UpdateMusteri()
        {
            int musteriId = Convert.ToInt32(Request.QueryString["id"]);
            TurizmDBEntities db = new TurizmDBEntities();
            Musteri musteri = db.Musteri.Where(p => p.MusteriId == musteriId).SingleOrDefault();
            return View(musteri);
        }
       

        public ActionResult UpdateMusteriler(UpdateMusterilerRequest request)
        {
            TurizmDBEntities db = new TurizmDBEntities();
            Musteri updateMusteriler = db.Musteri.Where(p => p.MusteriId == request.MusteriId).SingleOrDefault();
            updateMusteriler.Adi = request.Ad;
            updateMusteriler.Soyadi = request.Soyad;
            updateMusteriler.Email = request.Email;
            updateMusteriler.EvTel = request.EvTel;
            updateMusteriler.CepTel = request.CepTel;
            updateMusteriler.EvAdresi = request.EvAdres;
            db.SaveChanges();
            return RedirectToAction("Müsteri");
        }

        public ActionResult Fiyat()
        {
            TurizmDBEntities db = new TurizmDBEntities();
            List<Fiyatlar> allFiyatlar = db.Fiyatlar.ToList();
            ViewBag.Fiyatlar = allFiyatlar;
            return View();
        }

        public ActionResult Fiyatlar()
        {
            return View();

        }

        public ActionResult AddFiyatlar(AddFiyatlarRequest request)
        {
            Fiyatlar fiyatlar = new Fiyatlar();
            fiyatlar.VarisNoktaId = request.VarisNoktaId;
            fiyatlar.AracId = request.AracId;
            fiyatlar.Fiyat = request.Fiyat;
            TurizmDBEntities db = new TurizmDBEntities();
            db.Fiyatlar.Add(fiyatlar);
            db.SaveChanges();
            return RedirectToAction("Fiyat");
        }

        public ActionResult UpdateFiyat()
        {
            int fiyatId = Convert.ToInt32(Request.QueryString["id"]);
            TurizmDBEntities db = new TurizmDBEntities();
            Fiyatlar fiyat = db.Fiyatlar.Where(p => p.FiyatId == fiyatId).SingleOrDefault();
            return View(fiyat);
         
        }

        public ActionResult UpdateFiyatlar(UpdateFiyatlarRequest request)
        {
            TurizmDBEntities db = new TurizmDBEntities();
            Fiyatlar updateFiyat = db.Fiyatlar.Where(p => p.FiyatId == request.FiyatId).SingleOrDefault();
          
            updateFiyat.VarisNoktaId = request.VarisNoktaId;
            updateFiyat.AracId = request.AracId;
            updateFiyat.Fiyat = request.Fiyat;
            db.SaveChanges();
            return View("Fiyat");
        }

        public ActionResult Arac()
        {
            TurizmDBEntities db = new TurizmDBEntities();
            List<Araclar> allAraclar = db.Araclar.ToList();
            ViewBag.Araclar = allAraclar;
            return View();
        }

        public ActionResult Araclar()
        {
            return View();
        }

        public ActionResult AddAraclar(AddAraclarRequest request)
        {
            

            Araclar araclar = new Araclar();
            araclar.AracTipi = request.AracTipi;
            araclar.MaxKisi = request.MaxKisi;
            araclar.MinKisi = request.MinKisi;
            TurizmDBEntities db = new TurizmDBEntities();
            db.Araclar.Add(araclar);
            db.SaveChanges();
            return RedirectToAction("Arac");
        }

        public ActionResult UpdateArac()
        {

            int aracId = Convert.ToInt32(Request.QueryString["id"]);
            TurizmDBEntities db = new TurizmDBEntities();
            Araclar arac = db.Araclar.Where(p => p.AracId == aracId).SingleOrDefault();
            return View(arac);
      
        }

        public ActionResult UpdateAraclar(UpdateAraclarRequest request)
        {
            TurizmDBEntities db = new TurizmDBEntities();
            Araclar arac = db.Araclar.Where(p => p.AracId == request.AracId).SingleOrDefault();
            arac.AracTipi = request.AracTipi;
            arac.MaxKisi = request.MaxKisi;
            arac.MinKisi = request.MinKisi;
            db.SaveChanges();
            return View("Arac");

           

        }


        public ActionResult Rezervasyon()
        {
            TurizmDBEntities db = new TurizmDBEntities();
            List<Rezervasyon> allRezervasyon = db.Rezervasyon.ToList();
            ViewBag.Rezervasyon = allRezervasyon;
            return View();

         
        }

        public ActionResult Rezervasyonlar()
        {
            return View();
        }

        public ActionResult AddRezervasyon(AddRezervasyonRequest request)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.MusteriId = request.MusteriId;
            rezervasyon.FiyatId = request.FiyatId;
            rezervasyon.TransferTipi = request.TransferTipi;
            rezervasyon.Tarih = request.Tarih;
            rezervasyon.Saat = request.Saat;
            rezervasyon.Adres = request.Adres;
            rezervasyon.DonusAdres = request.DonusAdres;
            rezervasyon.KayitAdres = request.KayitAdres;
            rezervasyon.IpAdres = request.IpAdres;
            rezervasyon.CocukSayi = request.CocukSayi;
            rezervasyon.CocukKoltuk = request.CocukKoltuk;
            rezervasyon.VarisSaati = request.VarisSaati;
            rezervasyon.DonusSaati = request.DonusSaati;
            rezervasyon.UcusNo = request.UcusNo;
            rezervasyon.DonusTarihi = request.DonusTarihi;
            TurizmDBEntities db = new TurizmDBEntities();
            db.Rezervasyon.Add(rezervasyon);
            db.SaveChanges();
            return RedirectToAction("Rezervasyon");

         
        }

    }
}