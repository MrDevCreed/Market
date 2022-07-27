using Data.Repositorys.Common;
using Domain;
using System.Collections.Generic;

namespace Data.Repositorys.Interfaces
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        List<Category> GetList();
    }
}
