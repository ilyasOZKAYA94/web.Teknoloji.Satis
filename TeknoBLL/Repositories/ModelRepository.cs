using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoDAL.Context;

namespace TeknoBLL.Repositories
{
    public class ModelRepository : IModelRepository
    {
        TeknoContext ent = new TeknoContext();
        public bool ModelEkle(Model m)
        {
            throw new NotImplementedException();
        }
        public bool ModelGuncelle()
        {
            throw new NotImplementedException();
        }
        public List<Model> ModelListele()
        {
            return ent.Modeller.Where(m => m.Silindi == false).ToList();
        }
        public bool ModelSil(Model m)
        {
            throw new NotImplementedException();
        }

        public bool ModelSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
