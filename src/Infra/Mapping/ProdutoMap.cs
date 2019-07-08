using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Nome).HasMaxLength(100);
            builder.Property(x => x.CodigoBarra).HasMaxLength(15);
            builder.Property(x => x.Volume).HasMaxLength(20);
            builder.Property(x => x.PrecoCompra).HasColumnType("decimal(7,2)").IsRequired(true);
            builder.Property(x => x.PrecoVenda).HasColumnType("decimal(7,2)").IsRequired(true);
            builder.Property(x => x.DataCadastro).HasColumnName("DataCadastro").HasColumnType("datetime");
            builder.Property(x => x.DataSaida).HasColumnName("DataSaida").HasColumnType("datetime");
            builder.HasQueryFilter(x => x.Ativo == true);
        }
    }
}
