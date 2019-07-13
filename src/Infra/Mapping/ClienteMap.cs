using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Mapping
{
    class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Nome).HasMaxLength(50);
            builder.Property(x => x.Contato).HasMaxLength(50);
            builder.Property(x => x.cnpjcpf).HasMaxLength(15);
            builder.Property(x => x.Telefone).HasMaxLength(15);
            builder.Property(x => x.Celular).HasMaxLength(15);
            builder.Property(x => x.Email).HasMaxLength(30);
            builder.Property(x => x.Endereco).HasMaxLength(60);
            builder.Property(x => x.Complemento).HasMaxLength(20);
            builder.Property(x => x.Bairro).HasMaxLength(30);
            builder.Property(x => x.Cidade).HasMaxLength(30);
            builder.Property(x => x.Estado).HasMaxLength(2);
            builder.Property(x => x.Cep).HasMaxLength(8);
            builder.Property(x => x.DataCadastro).HasColumnName("DataCadastro").HasColumnType("datetime");
            builder.HasQueryFilter(x => x.Ativo == true);
        }
    }
}
