using Data.Repositorys.Common;
using Domain;
using System.Collections.Generic;

namespace Data.Repositorys.Interfaces
{
    public interface IReviewRepository : IRepositoryBase<Review>
    {
        List<Review> GetList(int PageSize,int PageNumber);
    }
}
