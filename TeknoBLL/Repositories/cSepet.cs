using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoBLL.Repositories
{
    public class cSepet
    {
        public int SepetId { get; set; }
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }

        public List<cSepet> BosSepet()
        {
            return new List<cSepet>();
        }
        public int ToplamAdet(List<cSepet> sepet)
        {
            int TopAdet = 0;
            foreach (cSepet urun in sepet)
            {
                TopAdet += urun.Adet;
            }
            return TopAdet;
        }
        public decimal ToplamTutar(List<cSepet> sepet)
        {
            decimal TopTutar = 0;
            foreach (cSepet urun in sepet)
            {
                TopTutar += urun.Tutar;
            }
            return TopTutar;
        }

    }
}
