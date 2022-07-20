using System;
using System.Collections.Generic;

namespace Domain
{
    public class Category
    {
        public Category(string name)
        {
            this.Name = name;
            this.Products = new List<Product>();
        }

        public int Id { get; private set; }

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

        public List<Product> Products { get; private set; }

        //Functions

        public void ChangeCategoryName(string name)
        {
            this.Name = name;
        }
    }
}
