using System;

namespace Domain
{
    public class BuyBasketProduct
    {
        public BuyBasketProduct() { }
        public BuyBasketProduct(BuyBasket buyBasket, Product product)
        {
            this.BuyBasket = buyBasket;
            this.Product = product;
        }

        public int Id { get; private set; }

        public virtual BuyBasket BuyBasket { get; private set; }

        public virtual Product Product { get; private set; }
    }
}
