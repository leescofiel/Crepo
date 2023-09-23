using System;
using System.Dynamic;
using ClassLibrary1;

namespace Idisposemethod
{
    internal class Program
    {
        static void DOWork()
        {
            //create object using dec
            using Sample s=new Sample();
            s.DisplayDataFromDatabase();
        }//dispose gets called
        static void Main(string[] args)
        {
            DOWork();
            //create object by using structure
            using(Sample s=new Sample())
            
            {

                s.DisplayDataFromDatabase();
                s.DataMethod();


            }
            Console.WriteLine("some other work");
            Console.ReadKey();
        }
    }
}
