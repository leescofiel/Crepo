public class Person
{
    public string PersonName { get; set; }
    public string Email { get; set; }
    public AgeGroupEnumration AgeGroup { get; set; } 

}

public enum AgeGroupEnumration:short 
{
    child=100,
    teenager,
    adult=100,
    senior
}
