public class Manager : IEmployee,Iperson
{
    //field
    private string _department;
    private int _empID;
    private string _empName;
    private string _location;
  
    public int EmployeeID
    {
        set
        {
            if (value >= 10000 && value <= 2000)
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
   

   
    //cons child
    public Manager(int empID, string empName, string location, string department)
    {
        _department = department;
    }


    //method implementation
    public string GetHealthInsurance()
    {

        return "heath insurance amount is:1500";
    }
    //method
    public long GetTotaalSalesYear()
    {
        return 1000;
    }

    //method for Iperson.GetAge() method
     int Iperson.GetAge()
    {

        return 20;
    }

    //method for IEmployee.GetAge() method
    int IEmployee.GetAge()
    {
        return 40;
    }


}