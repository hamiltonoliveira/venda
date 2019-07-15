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
    public class ServicoUsuario : IServices<Usuario> 
    {

        private IRepositorio<Usuario> _repository;

        public ServicoUsuario(IRepositorio<Usuario> repository)

        {
            _repository = repository;
        }

        Task IServices.IServices<Usuario>.DeleteAsync(Usuario entity)
        {
            return _repository.DeleteAsync(entity);
        }

        Task<List<Usuario>> IServices.IServices<Usuario>.GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        Task<Usuario> IServices.IServices<Usuario>.GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        Task IServices.IServices<Usuario>.InsertAsync(Usuario entity)
        {
            entity.Senha = GerarSenha.Encrypt(entity.Senha);
            Random random = new Random();
            int codigo = Convert.ToInt32(random.Next(100, 9999).ToString());
            entity.CodigoUsuario = entity.Nome.Substring(0, 2).ToUpper() + codigo.ToString() + DateTime.Now.Day.ToString();
            return _repository.InsertAsync(entity);
        }

        Task IServices.IServices<Usuario>.UpdateAsync(Usuario entity)
        {
            return _repository.UpdateAsync(entity);
        }

        IEnumerable<Usuario> IServices.IServices<Usuario>.Where(Expression<Func<Usuario, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
