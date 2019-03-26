using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoDAL.Context;

namespace TeknoBLL.Repositories
{
    public class MarkaRepository : IMarkaRepository
    {
        TeknoContext ent = new TeknoContext();
        public bool MarkaEkle(Marka m)
        {
            throw new NotImplementedException();
        }
        public bool MarkaGuncelle()
        {
            throw new NotImplementedException();
        }
        public List<Marka> MarkaListele()
        {
            return ent.Markalar.Where(m=>m.Silindi == false).ToList();
        }

        public bool MarkaSil(Marka m)
        {
            throw new NotImplementedException();
        }

        public bool MarkaSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
