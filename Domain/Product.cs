using System;
using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public Product(double price,
                       string name,
                       int count,
                       Seller seller,
                       Dictionary<string, string> propertys,
                       Category category)
        {
            this.Price = price;
            this.Name = name;
            this.Count = count;
            this.Seller = seller;
            this.Propertys = propertys;
            this.Category = category;
        }

        public int Id { get; private set; }

        public double Price { get; private set; }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Name Cannot be Null");

                _Name = value;
            }
        }

        public int Count { get; private set; }

        public virtual Seller Seller { get; private set; }

        public virtual List<BuyBasketProduct> BuyBasketProducts { get; private set; }

        public virtual Dictionary<string, string> Propertys { get; private set; }

        public virtual Category Category { get; private set; }

        public virtual List<Review> Reviews { get; private set; }

        public virtual List<OrderProduct> OrderProducts { get; private set; }

        //Functions

        public void ChangeName(string name)
        {
            this.Name = name;
        }

        public void ChangePrice(double price)
        {
            this.Price = price;
        }

        public void ChangeCountProduct(int count)
        {
            this.Count = count;
        }
    }
}
