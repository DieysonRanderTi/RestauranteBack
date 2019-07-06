using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rest.Domain.Ententies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Infra.Data.Map
{
    public class PratoMap: IEntityTypeConfiguration<Prato>
    {
        public void Configure(EntityTypeBuilder<Prato> builder)
        {
            builder.ToTable("Prato");

            builder.HasKey(x => x.IdPrato);

            builder.Property(x => x.NomePrato)
                .HasColumnName("NomePrato")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.PrecoPrato)
               .HasColumnName("Preco")
               .IsRequired();
        }
    }
}
