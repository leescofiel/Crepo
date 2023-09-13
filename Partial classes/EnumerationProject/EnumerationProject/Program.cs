using System;

class Program
{
    static void Main()
    {
        //create object of person
        Person person = new Person();
        person.PersonName = "john";
        person.Email = "jhon@gmail.com";
        person.AgeGroup = AgeGroupEnumration.child;
        Console.WriteLine(person.AgeGroup);
        Console.ReadKey();
    }
}