using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x=>x.id);
            builder.Property(x => x.Nome).HasMaxLength(80);
            builder.Property(x => x.CodigoUsuario).HasMaxLength(15);
            builder.Property(x => x.CnpjCpf).HasMaxLength(15);
            builder.Property(x => x.Email).HasMaxLength(40);
            builder.Property(x => x.Senha).HasMaxLength(200);
            builder.Property(x => x.DataCadastro).HasColumnName("DataCadastro").HasColumnType("datetime");
            builder.Property(x => x.DataUltimoLog).HasColumnName("DataUltimoLog").HasColumnType("datetime");
            builder.HasQueryFilter(x => x.Ativo == true);
        }
    }
}


