using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoDAL.Context;

namespace TeknoBLL.Repositories
{
    public interface IUrunRepository
    {
        bool UrunEkle(Urun u);
        bool UrunGuncelle();
        bool UrunSil(Urun u);
        bool UrunSil(int ID);
        List<Urun> UrunListele();
        List<Urun> UrunListeleByMarka(int markaId);
        List<Urun> UrunListeleByMarkaAndModel(int markaId, int modelId);
    }
}
