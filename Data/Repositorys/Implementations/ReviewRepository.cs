using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorys.Implementations
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        private readonly Context _context;

        public ReviewRepository(Context context) : base(context)
        {
            this._context = context;
        }

        public List<Review> GetList(int PageSize, int PageNumber)
        {
            return _context.Reviews.OrderByDescending(P => P.CreatedAt)
                                                     .Skip(PageNumber * PageSize - PageSize)
                                                     .Include(P => P.Customer)
                                                     .Include(P => P.Product)
                                                     .ToList();
        }
    }
}
