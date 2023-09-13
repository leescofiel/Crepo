using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main()
    {
        //create obj
        Sample sample=new Sample();
        Employee emp = new Employee() { Salary = 1000 };
        Student stu = new Student() { Marks = 80 };

        //call the genric method
        sample.PrintData<Employee>(emp);
        sample.PrintData<Student>(stu);

        System.Console.ReadKey();
    }
}