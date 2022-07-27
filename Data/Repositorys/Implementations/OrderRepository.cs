using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorys.Implementations
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        private readonly Context _context;

        public OrderRepository(Context context) : base(context)
        {
            this._context = context;
        }

        public void ChangeOrderState(int id, OrderState orderState)
        {
            _context.Orders.Where(P => P.Id == id).First().ChangeOrderState(orderState);
        }

        public List<Order> GetList(int PageSize, int PageNumber)
        {
            return _context.Orders.OrderByDescending(P => P.CreatedAt)
                                                     .Skip(PageNumber * PageSize - PageSize)
                                                     .Include(P => P.Customer)
                                                     .Include(P => P.Seller)
                                                     .Include(P => P.OrderProducts)
                                                     .ToList();
        }
    }
}
