using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.UnitOfwork;
using Infra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class ConextoDB : DbContext , IUnitOfWork
    {
        public ConextoDB(DbContextOptions<ConextoDB> options)
        :base(options)
        {}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public async Task SalvarBco()
        {
            await base.SaveChangesAsync();
        }

        #region configuração nas tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
        }
        #endregion


    }
}
