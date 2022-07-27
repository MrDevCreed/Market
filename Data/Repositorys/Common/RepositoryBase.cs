using Data.Database;
using Data.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repositorys.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly Context _context;

        protected DbSet<T> _dbSet;

        public RepositoryBase(Context context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T DbSet)
        {
            _dbSet.Add(DbSet);
        }

        public void Delete(T DbSet)
        {
            _dbSet.Remove(DbSet);
        }

        public void Edit(T DbSet)
        {
            _dbSet.Update(DbSet);
        }

        public T Find(T DbSet)
        {
            return _dbSet.Find(DbSet);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
