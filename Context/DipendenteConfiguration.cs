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
    public class DipendenteConfiguration : IEntityTypeConfiguration<Dipendente>
    {
        public void Configure(EntityTypeBuilder<Dipendente> builder)
        {
            builder.ToTable("Dipendente");
            builder.HasKey(k => k.Codice);
            builder.Property("Codice").IsFixedLength().HasMaxLength(5);
            builder.Property("Nome").IsRequired();
            builder.Property("Cognome").IsRequired();
            builder.Property(d => d.DataNascita).HasColumnType("datetime2").IsRequired();

            builder.HasOne(d => d.Reparto).WithMany(r => r.Dipendenti).HasForeignKey(f => f.RepartoNumero);
        }
    }
}
