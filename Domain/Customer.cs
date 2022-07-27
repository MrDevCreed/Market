using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain
{
    public class Customer
    {
        public Customer(string userId)
        {
            this.UserId = userId;
        }

        public int Id { get; private set; }

        public string UserId { get; private set; }

        public virtual List<Order> Orders { get; private set; }

        public virtual BuyBasket BuyBasket { get; private set; }
    }
}
