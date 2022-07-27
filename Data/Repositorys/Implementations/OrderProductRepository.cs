using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorys.Implementations
{
    public class OrderProductRepository : RepositoryBase<OrderProduct>, IOrderProductRepository
    {
        private readonly Context _context;

        public OrderProductRepository(Context context) : base(context)
        {
            this._context = context;
        }

    }
}
