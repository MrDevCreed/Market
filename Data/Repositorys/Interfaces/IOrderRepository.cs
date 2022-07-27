using Data.Repositorys.Common;
using Domain;
using System.Collections.Generic;

namespace Data.Repositorys.Interfaces
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        List<Order> GetList(int PageSize,int PageNumber);

        void ChangeOrderState(int id, OrderState orderState);
    }
}
