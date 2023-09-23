using System;
using ClassLibrary1;


namespace InnerClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an obj for ijnner
            ClassLibrary1.MarkCalculation.CaluclulationHelper ch = new
             ClassLibrary1.MarkCalculation.CaluclulationHelper();

            //call the inner class method
            Console.WriteLine(ch.Multiply(10, 5));

            //outer class
            ClassLibrary1.MarkCalculation mc = new ClassLibrary1.MarkCalculation();

            Student s=new Student() { SecuredMarks=30,MaxMarks=100};

            mc.CalculatePercentage(s);
            Console.WriteLine(s.Percentage;

            Console.ReadKey();

            
        }
    }
}
