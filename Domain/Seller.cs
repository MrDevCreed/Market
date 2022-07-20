using System.Collections.Generic;

namespace Domain
{
    public class Seller
    {
        public Seller(User user)
        {
            this.User = user;
        }

        public int Id { get; private set; }

        public virtual User User { get; private set; }

        public virtual List<Order> Orders { get; private set; }

        public virtual List<Product> Products { get; private set; }
    }
}
