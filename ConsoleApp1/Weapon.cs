using System.Diagnostics;

class Weapon : Item
{
    public Weapon (string tempname, int temppower)
    {
        name = tempname;
        power = temppower;
    }
    public string givename()
    {
        return name;
    }
    public new int giveother()
    {
        return power;
    }
    public string printstats()
    {
        string toreturn;
        toreturn = name + "|  Power = " + power;
        return toreturn;
    }
    private string name;
    private int power;

}
