using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEF
{
    public class CategoriaEstabelecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
    }
}
