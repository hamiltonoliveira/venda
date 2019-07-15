using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services.IServices;
using Recurso.Validacao;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Services
{
    public class ServicoPedido: IServices<Pedido>
    {
        private IRepositorio<Pedido> _repository;

        public ServicoPedido(IRepositorio<Pedido> repository)
        {
            _repository = repository;
        }

        public Task DeleteAsync(Pedido entity)
        {
            return _repository.DeleteAsync(entity);
        }

        public Task<List<Pedido>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Pedido> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task InsertAsync(Pedido entity)
        {
            return _repository.InsertAsync(entity);
        }

        public Task UpdateAsync(Pedido entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public IEnumerable<Pedido> Where(Expression<Func<Pedido, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }

}
