using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Services
{
   public class ServicoCategoria : IServices<Categoria>
    {
        private IRepositorio<Categoria> _repository;

        public ServicoCategoria(IRepositorio<Categoria> repository)
        {
            _repository = repository;
        }

        public Task DeleteAsync(Categoria entity)
        {
            return _repository.DeleteAsync(entity);
        }

        public Task<List<Categoria>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Categoria> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task InsertAsync(Categoria entity)
        {
           return _repository.InsertAsync(entity);
        }

        public Task UpdateAsync(Categoria entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public IEnumerable<Categoria> Where(Expression<Func<Categoria, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
