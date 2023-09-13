using System;
class Program
{
    static void Main()
    {
        //create structure instance
        Structure1 structure1;
        structure1.x = 10;
        structure1.y = 20;

        //create an obj
        Class1 class1;
        class1=new Class1();

        //create an another structure instance
        Structure1 structure2= new Structure1();

        //create reference variable of class1
        Class1 class2;

        //copy of data from class1 to clas2
        class2 = class1;

        //modify data of object
        class2.x = 100;
        class2.y = 200;



        //copy data from structure1 to structure 2
        structure2 = structure1;

        //modify data of structure
        structure2.x = 100;
        structure2.y = 200;

        //print the value of st1 and st2
        Console.WriteLine(structure2.x);
        Console.WriteLine(structure2.y);
        Console.WriteLine(structure1.x);
        Console.WriteLine(structure1.y);

        Console.WriteLine(class2.x);
        Console.WriteLine(class2.y);
        Console.WriteLine(class1.x);
        Console.WriteLine(class1.y);

        Console.ReadKey();


    }
}