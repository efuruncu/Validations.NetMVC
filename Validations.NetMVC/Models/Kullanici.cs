using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validations.NetMVC.Models
{
    public class Kullanici
    {
        // Data Annotations
      
        [DisplayName("Adınız"),Required(),StringLength(15)]
        public string Ad { get; set; }
        [DisplayName("Soyadınız"), StringLength(20)]
        public string Soyad { get; set; }
        [DisplayName("Kullanıcı Adı"), MinLength(5, ErrorMessage = "{0} min {1} karakter olmalıdır.")
            , MaxLength(25, ErrorMessage = "{0} max {1} karakter olmalıdır."), Required(ErrorMessage = "Lütfen bir {0} giriniz.")]
        public string KullaniciAdi { get; set; }
        [DisplayName("Şifre"), Required(ErrorMessage ="Lütfen {0} giriniz.")
            ,MinLength(5,ErrorMessage ="{0} min {1} karakter olmalıdır.")
            ,MaxLength(15,ErrorMessage = "{0} max {1} karakter olmalıdır."),DataType(DataType.Password)]
        public string Sifre { get; set; }
        [DisplayName("Şifre (Tekrar)"), Required(ErrorMessage = "Lütfen {0} giriniz."), MinLength(6), MaxLength(16), DataType(DataType.Password),Compare(nameof(Sifre),ErrorMessage ="{0} ile Şifre uyuşmuyor.")]
        public string Sifre2 { get; set; }
        [DisplayName("Yaş"),Range(1,110),Required(ErrorMessage ="Lütfen bir {0} değeri giriniz.")]
        public int Yas { get; set; }
        [DisplayName("E-posta"), Required(ErrorMessage ="Lütfen bir {0} giriniz."),MaxLength(60),DataType(DataType.EmailAddress)]
        public string Eposta { get; set; }
        [DisplayName("E-posta (Tekrar)"), Required(ErrorMessage = "Lütfen bir {0} giriniz."), MaxLength(60),DataType(DataType.EmailAddress),Compare(nameof(Eposta),ErrorMessage ="{0} ile E-posta uyuşmuyor")]
        public string Eposta2 { get; set; }
        [DisplayName("Spor Takımınız"),MaxLength(25)]
        public string Takiminiz { get; set; }

    }
}