﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicallyTypedvariable
{
    internal class Program
    {
        class Student
        {
            public string StudentName { get; set; }
        }
        static void Main(string[] args)
        {
            //duynamically typed
            dynamic x;
            x = 100;
            x = "hello";

            x=new Student() { StudentName="harsha"};

            Console.WriteLine(x.StudentName);
            Console.ReadKey();
        }
    }
}
