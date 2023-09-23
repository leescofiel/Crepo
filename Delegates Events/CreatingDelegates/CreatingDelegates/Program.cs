using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace CreatingDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object for sample class
            Sample s=new Sample();

            //create a delegate
            MyDelegate mydelegate;

            //add method referemce
           mydelegate=new MyDelegate(s.Add);

            //invoke method
            Console.WriteLine(mydelegate.Invoke(30,40));

            Console.ReadKey();
        }
    }
}
