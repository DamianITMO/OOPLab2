class Questitem : Item
{
    public Questitem(string tempname, string tempdesc)
    {
        name = tempname;
        description = tempdesc;
    }
    public string givename()
    {
        return name;
    }
    public new string giveother()
    {
        return description;
    }
    private string name;
    private string description;

}
