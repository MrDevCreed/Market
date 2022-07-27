using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;

namespace Data.Repositorys.Implementations
{
    public class BuyBasketProductRepository : RepositoryBase<BuyBasketProduct> , IBuyBasketProductRepository
    {
        private readonly Context _context;

        public BuyBasketProductRepository(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
