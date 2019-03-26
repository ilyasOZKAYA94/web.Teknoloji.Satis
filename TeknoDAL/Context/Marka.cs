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
    [Table("Markalar")]
    public class Marka
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Markasi { get; set; }
        public string Aciklama { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        public virtual List<Model> Modeller { get; set; }
        public virtual List<Urun> Urunler { get; set; }
    }
}
