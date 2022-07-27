using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BuyBasket
    {
        public BuyBasket() { }
        public BuyBasket(Customer customer)
        {
            this.Customer = customer;
        }

        public int Id { get; private set; }

        public virtual List<BuyBasketProduct> Products { get; private set; }

        public int CustomerId { get; private set; }

        public virtual Customer Customer { get; private set; }
    }
}
