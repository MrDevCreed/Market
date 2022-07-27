using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;

namespace Data.Repositorys.Implementations
{
    public class ProductRepository : RepositoryBase<Product> , IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
