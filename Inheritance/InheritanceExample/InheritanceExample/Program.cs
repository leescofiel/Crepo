using Microsoft.Win32;

class Program
{
    static void Main()
    {
        /// create reference variavle of abstract class
        IEmployee emp;
        emp = new Manager(103, "aswin", "lee", "astro");
        emp.GetAge();
        System.Console.WriteLine(emp.GetAge());
        System.Console.WriteLine(emp.GetHealthInsurance());
        
        

        //Iperson interface

        Iperson person;

        person=new Manager(102,"aswin","lee","east");
     person.GetAge();
        System.Console.WriteLine();


        System.Console.WriteLine(person.GetAge());
        System.Console.WriteLine();




      


        //create object
       emp= new SalesMan(103,"deva","ranodm","weather");
      
        System.Console.WriteLine(emp.GetHealthInsurance());
        System.Console.WriteLine();


        System.Console.ReadKey();


    }
}
