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
        p.CallGetTax();

        ReadKey();
        
    }
}