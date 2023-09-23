using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public double SecuredMarks;
        public double MaxMarks;
        public double Percentage;
    }

    //outerclass
    public class MarkCalculation
    {
        public void CalculatePercentage(Student s)
        {
            //create an object
            CaluclulationHelper ch=new CaluclulationHelper();
          //  s.Percentage = s.SecuredMarks / s.MaxMarks * 100;
            s.Percentage = s.SecuredMarks / ch.Multiply(s.MaxMarks,100);
        }

        //inner class
      public  class CaluclulationHelper
        {
            public int Multiply(int n1,int n2)
            {
                return n1 * n2;
            }
        }
    }
}
