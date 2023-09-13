public interface IEmployee
{
    //no fields methods in interface

    //abstract method
    string GetHealthInsurance();
    int GetAge();


    //properties
    int EmployeeID
    {
        set;
        get;
    }
    string EmployeeName
    {
        get;
        set;
    }
    string Location
    {
        get;
        set;
    }

}