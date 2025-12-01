class Armor : Item
{
    public Armor(string tempname, int tempdefence)
    {
        name = tempname;
        defence = tempdefence;
        armorcounter++;
    }
    public string givename()
    {
        return name;
    }
    public new int giveother()
    {
        return defence;
    }
    private string name;
    private int defence;

}
