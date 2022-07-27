using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;

namespace Data.Repositorys.Implementations
{
    public class CustomerRepository : RepositoryBase<Customer> , ICustomerRepository
    {
        private readonly Context _context;

        public CustomerRepository(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
