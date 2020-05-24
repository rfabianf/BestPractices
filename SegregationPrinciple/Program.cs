using System;

namespace SegregationPrinciple
{
    public class Document
    {
        public static void Main()
        {

        }
    }

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public interface IPrint
    {
        void Print(Document d);
    }

    public interface ICopy
    {
        void Copy(Document d);
    }

    public interface IScan
    {
        void Scan(Document d);
    }
    public interface IFax
    {
        void Fax();
    }




 



}
