using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductPropertis
    {
        public int Id { get; private set; }

        private string _Key;
        public string Key
        {
            get { return _Key; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Key Cannot be Null");

                _Key = value;
            }
        }

        private string _Value;
        public string Value
        {
            get { return _Value; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Value Cannot be Null");

                _Value = value;
            }
        }

        public virtual Product Product { get; private set; }
    }
}
