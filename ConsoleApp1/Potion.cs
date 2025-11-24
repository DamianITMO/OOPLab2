class Potion : Item
{
    public Potion(string tempname, string tempeffect)
    {
        name = tempname;
        effect = tempeffect;
        potioncounter++;
    }
    public int howmanypotions()
    {
        return potioncounter;
    }
    public string givename()
    {
        return name;
    }
    public new string giveother()
    {
        return effect;
    }
    private int potioncounter = 0;
    private string name;
    private string effect;
}