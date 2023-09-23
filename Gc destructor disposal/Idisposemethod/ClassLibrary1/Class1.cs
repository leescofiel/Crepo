using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sample:System.IDisposable
    {
        //connstructor 
        public Sample()
        {
            Console.WriteLine("database connected");
        }

        //method
        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("data is disconnected");
        }

        public void DataMethod()
        {
            Console.WriteLine("the data base method");
        }
        //Dispose method
        public void Dispose()
        {
            Console.WriteLine("database disconnected");
        }

    }
}
