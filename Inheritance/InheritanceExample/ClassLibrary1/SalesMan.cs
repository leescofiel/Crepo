public class SalesMan : IEmployee, Iperson
{
    //fields
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;

    //properties
    public int EmployeeID
    {
        set
        {
            if (value >= 500 && value < 1000)
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }
    public string Location
    {
        set { _location = value; }
        get { return _location; }
    }
    public string EmployeeName
    {
        set { _empName = value; }
        get { return _empName; }
    }

    //constructor for salesman
    public SalesMan(int empID, string empName, string location, string region)
    {
        _empID = empID;
        _empName = empName;
        _location = location;
        _region = region;
    }

    //method overriding the abstract method 
    public string GetHealthInsurance()
    {

        return "heath insurance amount is:500";
    }

    //property
    public string Region
    {
        get { return _region; }
        set { _region = value; }
    }

    //method
    public long GetSalesOfTheCurrentMonth()
    {
        return 10000;
    }
    public int GetAge()
    {

        return 20;
    }
}