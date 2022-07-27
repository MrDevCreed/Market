using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;

namespace Data.Repositorys.Implementations
{
    public class BuyBasketRepository : RepositoryBase<BuyBasket>, IBuyBasketRpository
    {
        private readonly Context _context;

        public BuyBasketRepository(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
