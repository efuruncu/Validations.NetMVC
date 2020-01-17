using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validations.NetMVC.Models;

namespace Validations.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Kullanici());
        }
        [HttpPost]
        public ActionResult Index(Kullanici model)
        {
            if(model.KullaniciAdi == "Elif")
            {
                //Veritabanından kullanıcı adı kullanılıyor mu? kontrolü yapmak için
                ModelState.AddModelError("KullaniciAdi","Bu kullanıcı adı kullanılıyor.");

                // eğer AddModelError da key yanlış verilmiş ise hatayı
                //hiçbir box ın altına yazdıramayacağı için en üstte yazdırır.

                //hata yönetmek için key bize lazım.
            }
            return View(model);
        }
    }
}