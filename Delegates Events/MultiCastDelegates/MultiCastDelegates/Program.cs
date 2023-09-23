using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace MultiCastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object of sample 
            Sample s=new Sample();

            //create reference
            MyDelegate mydelegatetype;

            //add reference from method
            mydelegatetype = s.Add;

            //add reference for the multiply
            mydelegatetype += s.Multiply;

            //invoking both method
            mydelegatetype.Invoke(40, 10);

            Console.ReadKey();
        }
    }
}
