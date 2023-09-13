using System;
using ClassLibrary1;
using Extensiondupes;

namespace Extensiondupe
{
  class Program
    {
        static void Main(string[] args)
        {
            Class1 cl=new Class1() { mark=100,total=100};
         Console.WriteLine(cl.GetData());
            System.Console.ReadKey();
        }
    }
}
