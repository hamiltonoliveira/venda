using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Services
{
   public class ServicoCliente : IServices<Cliente>
    {
        private IRepositorio<Cliente> _repository;

        public ServicoCliente(IRepositorio<Cliente> repository)
        {
            _repository = repository;
        }

        public Task DeleteAsync(Cliente entity)
        {
            return _repository.DeleteAsync(entity);
        }

        public Task<List<Cliente>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Cliente> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task InsertAsync(Cliente entity)
        {
           return _repository.InsertAsync(entity);
        }

        public Task UpdateAsync(Cliente entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public IEnumerable<Cliente> Where(Expression<Func<Cliente, bool>> expression)
        {
             return _repository.Where(expression);
        }


    }
}
