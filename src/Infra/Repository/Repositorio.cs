using ApplicationCore.Interfaces;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class Repositorio<Tentity> : IRepositorio<Tentity> where Tentity : class
    {
        public DbSet<Tentity> DbSet
        {
            get;
            set;
        }

        protected readonly ConextoDB _dbcontext;
        public Repositorio(ConextoDB dbcontext)
        {
            _dbcontext = dbcontext;
        }

       public async Task<List<Tentity>> GetAllAsync()
        {
            return await _dbcontext.Set<Tentity>().ToListAsync();
        }

        public async Task<Tentity> GetByIdAsync(int id)
        {
            return await _dbcontext.Set<Tentity>().FindAsync(id);
        }

        public async Task InsertAsync(Tentity entity)
        {
             _dbcontext.Set<Tentity>().Add(entity);
            await _dbcontext.SalvarBco();
        }

        public async Task UpdateAsync(Tentity entity)
        {
            _dbcontext.Entry(entity).State = EntityState.Modified;
            _dbcontext.Update(entity);
             await _dbcontext.SalvarBco();
        }

        public async Task DeleteAsync(Tentity entity)
        {
            _dbcontext.Set<Tentity>().Remove(entity);
            await _dbcontext.SalvarBco();
        }

        public IEnumerable<Tentity> Where(Expression<Func<Tentity, bool>> expression)
        {
             return _dbcontext.Set<Tentity>().Where(expression);
        }
      }
    }

