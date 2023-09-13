FILE 1 .CS
namespace Warehouse
{
    public partial class Product
    {
        //private field
        private int _productID;

        //public property
        public int ProductID
        {
            set { _productID = value; }
            get { return _productID; }
        }
    }
}
-----------------------
FILE2.CS


namespace Warehouse
{
    public partial class Product
    {
        //private field
        private double _cost;

        //public property
        public double Cost
        {
            set
            {
                _cost = value;
            }
            get { return _cost; }
        }
    }
}
-------------------------------------
FILE 3.CS
namespace Warehouse
{
    public partial class Product
    {
        //public method 
        public double GetTax()
        {
            double tax = Cost * 10 / 100;
            return tax;
        }
    }
}
----------------
PROGRAM.CS
using static System.Console;
using Warehouse;

class Program
{
    static void Main()
    {
        //create an object
        Product p= new Product();

        //acess properties
        p.ProductID = 101;
        p.Cost = 100;

        //acess methods
        WriteLine(p.GetTax());

        ReadKey();
        
    }
}