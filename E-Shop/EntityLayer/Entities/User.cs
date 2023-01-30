using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olamalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olamalıdır.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Kullanıcı Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olamalıdır.")]
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
   
        public string RePassword { get; set; }
        [StringLength(10, ErrorMessage = "Max 10 karakter olamalıdır.")]
        public string Role { get; set; }






    }
}
