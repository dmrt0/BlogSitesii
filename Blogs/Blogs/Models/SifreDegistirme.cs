using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blogs.Models
{
    public class SifreDegistirme
    {
        [Required]
        [DisplayName("Şimdi ki Şifre")]
        public string OldPassword { get; set; }
        [Required]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Şifreniz En Az 5 Karekter Olmalı")]
        [DisplayName("Yeni Şifre")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("NewPassword",ErrorMessage ="Şifreler Aynı Değil")]
        public string ConNewPassword { get; set; }

    }
}