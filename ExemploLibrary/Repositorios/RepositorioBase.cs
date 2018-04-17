using System.Collections.Generic;
using System.Linq;
using ExemploLibrary.Contextos;
using ExemploLibrary.Entidades;

namespace ExemploLibrary.Repositorios
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class, IEntidade
    {
        private readonly DataContext _context;

        public RepositorioBase(DataContext context)
        {
            this._context = context;
        }
        public virtual void Add(T entidade)
        {
            _context.Set<T>().Add(entidade);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Find(long id)
        {
            return _context.Set<T>().FirstOrDefault(c => c.Id == id);
        }

        public virtual void Remove(long id)
        {
            var entidade = _context.Set<T>().First(c => c.Id == id);
            _context.Set<T>().Remove(entidade);
            _context.SaveChanges();
        }

        public virtual void Update(T entidade)
        {
            _context.Set<T>().Update(entidade);
        }
    }
}
