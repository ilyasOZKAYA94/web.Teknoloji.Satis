using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoDAL.Context;

namespace TeknoBLL.Repositories
{
    public interface IMarkaRepository
    {
        bool MarkaEkle(Marka m);
        bool MarkaGuncelle();
        bool MarkaSil(Marka m);
        bool MarkaSil(int ID);
        List<Marka> MarkaListele();
    }
}
