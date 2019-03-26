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
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string UrunAdi { get; set; }
        public int? MarkaId { get; set; }
        public int ModelId { get; set; }
        [Required]
        [DefaultValue(1)]
        public int Miktar { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Fiyat { get; set; }
        [StringLength(100)]
        public string Resimyolu1 { get; set; }
        [StringLength(100)]
        public string Resimyolu2 { get; set; }
        public string UrunBilgisi { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        [ForeignKey("MarkaId")]
        public virtual Marka Marka { get; set; }
        [ForeignKey("ModelId")]
        public virtual Model Model { get; set; }
    }
}
