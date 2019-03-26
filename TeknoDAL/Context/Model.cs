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
    [Table("Modeller")]
    public class Model
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Modeli { get; set; }
        public int MarkaId { get; set; }
        public string Aciklama { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        [ForeignKey("MarkaId")]
        public virtual Marka Marka { get; set; }
        public virtual List<Urun> Urunler { get; set; }
    }
}
