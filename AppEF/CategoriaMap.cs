using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEF
{
    public class CategoriaMap : EntityTypeConfiguration<CategoriaEstabelecimento>
    {
        public CategoriaMap()
        {
            ToTable("categorias_estabelecimentos");
            HasKey(m => m.Id);

            Property(m => m.Id).HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.Nome).HasColumnName("nome");
            Property(m => m.Imagem).HasColumnName("imagem");
        }
    }
}
