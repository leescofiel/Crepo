public struct Categeory
{
    //private fields
    private int _categoryID;
    private string _categoryName;

    //public fields
    public int CategoryID
    {
        set
        {
            if (value >= 1 && value <= 100)
            {
                _categoryID = value;
            }
            
        }
        get
        {
            return _categoryID;
        }
    }
    public string CategoryName
    {
        set
        {
            if (value.Length <= 40)
            {
                  _categoryName = value;
            }
        }
        get
        {
            return _categoryName;
        }
       
}
    public int GetCategoryNameLength()
    {
        return this._categoryName.Length;
    }


}
-----------------------------------------
PROGRAM.CS
class Program
{
    static void Main()
    {
        //structure instances
        Categeory category=new Categeory();

        //intialize properties
        category.CategoryID = 20;
        category.CategoryName = "Test";

        //acess the methods
        System.Console.WriteLine(category.CategoryID);
        System.Console.WriteLine(category.CategoryName);
        System.Console.WriteLine(category.GetCategoryNameLength());

        System.Console.ReadKey();

    }
}