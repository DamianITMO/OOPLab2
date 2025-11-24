class ActiveItem : Item
{
    public ActiveItem(string tempname, int temppower, int tempdefense, string tempeffect, string tempdesc)
    {
        name = tempname;
        power = temppower;
        defence = tempdefense;
        effect = tempeffect;
        desc = tempdesc;
    }
    private string name;
    private int power;
    private int defence;
    private string effect;
    private string desc;
}