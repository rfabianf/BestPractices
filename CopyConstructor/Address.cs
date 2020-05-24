using System;

namespace CopyConstructor
{
    public class Address 
    {
        public readonly string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            this.StreetName = streetName;
            this.HouseNumber = houseNumber;
        }

        public Address(Address address)
        {
            StreetName = address.StreetName;
            HouseNumber = address.HouseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(Address)}:{nameof(StreetName)}:{StreetName},{nameof(HouseNumber)} :{HouseNumber}";
        }
    }


}