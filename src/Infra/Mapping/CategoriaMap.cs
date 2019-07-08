using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Mapping
{
    class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Nome).HasMaxLength(30);
            builder.Property(x => x.DataCadastro).HasColumnName("DataCadastro").HasColumnType("datetime");
        }
    }
}
