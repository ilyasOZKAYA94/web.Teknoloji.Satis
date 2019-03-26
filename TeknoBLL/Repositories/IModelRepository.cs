using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoDAL.Context;

namespace TeknoBLL.Repositories
{
    public interface IModelRepository
    {
        bool ModelEkle(Model m);
        bool ModelGuncelle();
        bool ModelSil(Model m);
        bool ModelSil(int ID);
        List<Model> ModelListele();
    }
}
