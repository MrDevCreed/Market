using System.Collections.Generic;

namespace Domain
{
    public class BuyBasket
    {
        public BuyBasket(Customer customer)
        {
            this.Customer = customer;
        }

        public int Id { get; private set; }

        public virtual List<Product> Products { get; private set; }

        public virtual Customer Customer { get; private set; }
    }
}
