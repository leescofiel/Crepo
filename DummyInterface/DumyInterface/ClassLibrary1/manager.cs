public class  manager : Employee
{

    private int _empID;
    private string _location;
   public  int EmpID
    {
        set {
            _empID = value;
                }
        get
        {
            return _empID;
        }
    }
   public  string location
    {
        set { _location = value; }
        get
        {
            return _location;
        }
    }

    public string GetData()
    {
        return "data 100";
    }


}
