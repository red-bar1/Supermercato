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
    public class VenditaConfiguration : IEntityTypeConfiguration<Vendita>
    {
        public void Configure(EntityTypeBuilder<Vendita> builder)
        {
            builder.ToTable("Vendita");
            builder.HasKey(k => k.NumeroVendita);
            builder.Property("NumeroVendita").HasColumnType("int");
            builder.Property("Quantita").HasColumnType("int").IsRequired();
            builder.Property("DataVendita").HasColumnType("datetime2").IsRequired();

            builder.HasOne(v => v.Prodotto).WithMany(p => p.Vendite).HasForeignKey(f => f.CodiceProdotto);
        }
    }
}
