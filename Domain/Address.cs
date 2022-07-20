using System;

namespace Domain
{
    public class Address
    {
        public Address(string city, string postCode, string fullAddress)
        {
            this.City = city;
            this.PostCode = postCode;
            this.FullAddress = fullAddress;
        }

        public int Id { get; private set; }

        private string _City;

        public string City
        {
            get { return _City; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("City Cannot be Null");

                _City = value;
            }
        }

        private string _PostCode;

        public string PostCode
        {
            get { return _PostCode; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("PostCode Cannot be Null");

                if (value.Length != 10)
                    throw new ArgumentOutOfRangeException("PostCode Length Should be 10");

                _PostCode = value;
            }
        }

        private string _FullAddress;

        public string FullAddress
        {
            get { return _FullAddress; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("FullAddress Cannot be Null");

                _FullAddress = value;
            }
        }

        //Functions

        public void ChangeAddress(string city, string fullAddress, string postCode)
        {
            this.City = city;
            this.FullAddress = fullAddress;
            this.PostCode = postCode;
        }
    }
}
