using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.SupermercatoEF.Models;

namespace Week6.SupermercatoEF.Context
{
    public class ProdottoConfiguration : IEntityTypeConfiguration<Prodotto>
    {
        public void Configure(EntityTypeBuilder<Prodotto> builder)
        {
            builder.ToTable("Prodotto");
            builder.HasKey(k => k.Codice);
            builder.Property("Codice").IsFixedLength().HasMaxLength(5);
            builder.Property("Descrizione").IsRequired();
            builder.Property("Prezzo").HasColumnType("decimal").IsRequired();

            builder.HasOne(p => p.Reparto).WithMany(r => r.Prodotti).HasForeignKey(f => f.RepartoNumero);

            //per gestire la gerarchia
            builder.HasDiscriminator<string>("prodotto_type")
                        .HasValue<Prodotto>("prodotto")
                        .HasValue<ProdottoAlimentare>("alimentare")
                        .HasValue<Prodotto>("casalingo");

            ////con discriminante intero
            //builder.HasDiscriminator<int>("prodotto_type")
            //        .HasValue<Prodotto>(1)
            //        .HasValue<ProdottoAlimentare>(2)
            //        .HasValue<ProdottoCasalingo>(3);
        }
    }
}
