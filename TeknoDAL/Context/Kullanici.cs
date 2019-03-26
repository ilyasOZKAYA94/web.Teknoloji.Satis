using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoDAL.Context
{
    [Table("Kullanicilar")]
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Admin { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        [Required]
        [MaxLength(11), MinLength(11)]
        public string TCKimlikNo { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
    }
}
