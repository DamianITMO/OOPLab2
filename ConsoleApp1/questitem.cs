class Questitem : Item
{
    public Questitem(string tempname, string tempdesc)
    {
        name = tempname;
        description = tempdesc;
        questitcounter++;
    }
    public int howmanypotions()
    {
        return questitcounter;
    }
    public string givename()
    {
        return name;
    }
    public new string giveother()
    {
        return description;
    }
    private int questitcounter = 0;
    private string name;
    private string description;
}