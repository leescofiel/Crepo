public readonly struct Marvel
{
    //fields
    private readonly string _charactername;

    //public readonly prop

    public string CharacterName
    {
        get { return _charactername; }
    }

    //public method
    public void PrintCharacter()
    {
        System.Console.WriteLine(this.CharacterName);
    }

    //constructor
    public Marvel(string characterName)
    {
        _charactername = characterName;
    }

}