using System;
using System.Collections.Generic;
using System.Text;

namespace FacetedBuilder
{
    public class Person
    {
        //Address
        public string StreetAdress, PostCode, City;

        //Employment
        public string Company, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAdress)}: {StreetAdress},{nameof(PostCode)}: {nameof(City)} : {City} , {nameof(Company)} : {Company} , {nameof(Position)} : {Position} , {nameof(AnnualIncome)} : {AnnualIncome}";
        }
    }






}
