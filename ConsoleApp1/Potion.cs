class Potion : Item
{
    public Potion(string tempname, string tempeffect)
    {
        name = tempname;
        effect = tempeffect;
    }
    public string givename()
    {
        return name;
    }
    public new string giveother()
    {
        return effect;
    }
    private string name;
    private string effect;

}
