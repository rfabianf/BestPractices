using System;

namespace ICloneableBad
{
    public class Address : ICloneable
    {
        public readonly string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            this.StreetName = streetName;
            this.HouseNumber = houseNumber;
        }

        public object Clone()
        {
            return new Address(StreetName, HouseNumber);
        }

        public override string ToString()
        {
            return $"{nameof(Address)}:{nameof(StreetName)}:{StreetName},{nameof(HouseNumber)} :{HouseNumber}";
        }
    }


}