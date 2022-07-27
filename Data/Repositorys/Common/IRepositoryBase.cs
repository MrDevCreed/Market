namespace Data.Repositorys.Common
{
    public interface IRepositoryBase<T>
    {
        void SaveChanges();

        void Add(T DbSet);

        void Delete(T DbSet);

        void Edit(T DbSet);

        T Find(T DbSet);
    }
}
