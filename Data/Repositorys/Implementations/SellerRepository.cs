using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;

namespace Data.Repositorys.Implementations
{
    public class SellerRepository : RepositoryBase<Seller> , ISellerRepository
    {
        private readonly Context _context;

        public SellerRepository(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
