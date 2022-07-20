using System;

namespace Domain
{
    public class OrderProduct
    {
        public OrderProduct(Product product,Order order)
        {
            this.Product = product;
            this.Order = order;
        }

        public virtual Product Product { get; private set; }

        public virtual Order Order { get; private set; }
    }
}
