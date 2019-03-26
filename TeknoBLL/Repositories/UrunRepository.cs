using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoDAL.Context;

namespace TeknoBLL.Repositories
{
    public class UrunRepository : IUrunRepository
    {
        TeknoContext ent = new TeknoContext();
        public List<Urun> UrunListele()
        {
            return ent.Urunler.Where(u => u.Silindi == false).ToList();
        }
        public List<Urun> UrunListeleByMarka(int markaId)
        {
            return ent.Urunler.Where(u => u.MarkaId == markaId && u.Silindi == false).ToList();
        }
        public List<Urun> UrunListeleByMarkaAndModel(int markaId, int modelId)
        {
            return ent.Urunler.Where(u => u.MarkaId == markaId && u.ModelId == modelId && u.Silindi == false).ToList();
        }
        public bool UrunEkle(Urun u)
        {
            throw new NotImplementedException();
        }
        public bool UrunGuncelle()
        {
            throw new NotImplementedException();
        }
        public bool UrunSil(Urun u)
        {
            throw new NotImplementedException();
        }

        public bool UrunSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
