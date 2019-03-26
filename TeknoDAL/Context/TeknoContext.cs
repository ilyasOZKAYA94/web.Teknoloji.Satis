using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoDAL.Context
{
    public class TeknoContext : DbContext
    {


        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }
        public virtual DbSet<Model> Modeller { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
    }
}
