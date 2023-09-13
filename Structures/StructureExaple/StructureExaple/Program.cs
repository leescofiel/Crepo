class Program
{
    static void Main()
    {
        //structure instances
        Categeory category=new Categeory(20,"general");

        //intialize properties
        //category.CategoryID = 20;
       // category.CategoryName = "Test";

        //acess the methods
        System.Console.WriteLine(category.CategoryID);
        System.Console.WriteLine(category.CategoryName);
        System.Console.WriteLine(category.GetCategoryNameLength());

        System.Console.ReadKey();

    }
}