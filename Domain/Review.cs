using System;

namespace Domain
{
    public class Review
    {
        public Review(string text, double star, Customer customer, Product product)
        {
            this.Text = text;
            this.Star = star;
            this.Customer = customer;
            this.Product = product;
        }

        public int Id { get; private set; }

        private string _Text;

        public string Text
        {
            get { return _Text; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Text Cannot be Null");

                if (value.Length < 5 || value.Length > 750)
                    throw new ArgumentOutOfRangeException("Text Length Should Between [5-750]");

                _Text = value;
            }
        }

        private double _Star;

        public double Star
        {
            get { return _Star; }

            private set
            {
                if (value == null)
                    throw new ArgumentNullException("Text Cannot be Null");

                if (value < 0 || value > 5)
                    throw new ArgumentOutOfRangeException("Star Count Should Between [0-5]");

                _Star = value;
            }
        }

        public virtual Customer Customer { get; private set; }

        public virtual Product Product { get; private set; }
    }
}
