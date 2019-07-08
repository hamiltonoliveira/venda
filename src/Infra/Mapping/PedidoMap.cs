using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapping
{
    public class PedidoMap:IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Numero).HasMaxLength(100);
            builder.Property(x => x.DataCadastro).HasColumnName("DataCadastro").HasColumnType("datetime");
            builder.Property(x => x.DataPedido).HasColumnName("DataPedido").HasColumnType("datetime");
            builder.Property(x => x.DataEntrega).HasColumnName("DataEntrega").HasColumnType("datetime");
            builder.Property(x => x.DataDevolucao).HasColumnName("DataDevolucao").HasColumnType("datetime");
            builder.Property(x => x.Observacao).HasMaxLength(2000); 
        }
    }
}
