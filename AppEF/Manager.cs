using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEF
{
    public class Manager
    {
        private DatabaseContext db = new DatabaseContext();

        public IQueryable<CategoriaEstabelecimento> ListAll()
        {
            return db.CategoriasEstabelecimentos;
        }
    }
}
