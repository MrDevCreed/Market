using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain
{
    public class Seller
    {
        public Seller(string userId)
        {
            this.UserId = userId;
        }

        public int Id { get; private set; }

        public string UserId { get; private set; }

        public virtual List<Order> Orders { get; private set; }

        public virtual List<Product> Products { get; private set; }
    }
}
