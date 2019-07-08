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
    public class ServicoProduto : IServices<Produto>
    {
        private IRepositorio<Produto> _repository;

        public ServicoProduto(IRepositorio<Produto> repository)
        {
            _repository = repository;
        }

        public Task DeleteAsync(Produto entity)
        {
            return _repository.DeleteAsync(entity);
        }

        public Task<List<Produto>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Produto> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task InsertAsync(Produto entity)
        {
            return _repository.InsertAsync(entity);
        }

        public Task UpdateAsync(Produto entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public IEnumerable<Produto> Where(Expression<Func<Produto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }

}
