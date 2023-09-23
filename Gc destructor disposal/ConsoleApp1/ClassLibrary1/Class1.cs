using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sample
    {
        //constructor
        public Sample()
        {
            //filr & db connection
            Console.WriteLine("file is opened");

        }
        //destructor
        ~Sample()
        {
            Console.Write("destructor is executed");
        }
    }
}
