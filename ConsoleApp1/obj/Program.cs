using System;
using System.Management;
internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Cat IntertainmentTM 2025");
        Console.WriteLine("Inventory options:");
        Console.WriteLine(" ");
        Console.WriteLine("1 - See active items");
        Console.WriteLine("2 - See all items");
        Console.WriteLine("3 - Add items");
        Console.WriteLine("4 - Combine potions");
        int howmanyactive = 0; int howmanyweapons = 0; int howmanypotions = 0; int howmanyarmors = 0; int howmanyquestitems = 0;
        Weapon[] weapontr = new Weapon[100]; Armor[] armortr = new Armor[100]; Potion[] potiontr = new Potion[100]; Questitem[] questittr = new Questitem[100]; ActiveItem[] activetr = new ActiveItem[100];
        schtrechbreker:
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                for (int i = 0; i < howmanyactive; i++)
                {
                    Console.WriteLine(activetr[i]);
                }
                choice = 0;
                break;

            case 2:
                for (int i = 0; i < howmanyweapons; i++)
                {
                    Console.WriteLine(weapontr[i].givename(), weapontr[i].giveother());
                }
                for (int i = 0; i < howmanyarmors; i++)
                {
                    Console.WriteLine(armortr[i].givename(), armortr[i].giveother());
                }
                for (int i = 0; i < howmanypotions; i++)
                {
                    Console.WriteLine(potiontr[i].givename(), potiontr[i].giveother());
                }
                for (int i = 0; i < howmanyquestitems; i++)
                {
                    Console.WriteLine(questittr[i].givename(), questittr[i].giveother());
                }
                choice = 0;
                break;

            case 3:
                /* Types: 1 = weapon, 2 = armor, 3 = potion, 4 = questiem*/
                int choicetwo = Convert.ToInt32(Console.ReadLine());
                switch (choicetwo)
                {
                    case 1:
                        string tempname = Console.ReadLine();
                        int temppower = Convert.ToInt32(Console.ReadLine());
                        weapontr[howmanyweapons] = new Weapon(tempname, temppower);
                        howmanyweapons++;
                        break;
                    case 2:
                        tempname = Console.ReadLine();
                        int tempdefence = Convert.ToInt32(Console.ReadLine());
                        armortr[howmanyarmors] = new Armor(tempname, tempdefence);
                        howmanyarmors++;
                        break;
                    case 3:
                        tempname = Console.ReadLine();
                        string tempeffect = Console.ReadLine();
                        potiontr[howmanypotions] = new Potion(tempname, tempeffect);
                        howmanypotions++;
                        break;
                    case 4:
                        tempname = Console.ReadLine();
                        string tempdesc = Console.ReadLine();
                        questittr[howmanyquestitems] = new Questitem(tempname, tempdesc);
                        howmanyquestitems++;
                        break;
                }
                choice = 0;
                break;

            case 4:
                /* which potions to mix? IDs */
                int IDone = Convert.ToInt32(Console.ReadLine());
                int IDtwo = Convert.ToInt32(Console.ReadLine());
                string newname = potiontr[IDone].givename() + potiontr[IDtwo].givename();
                string neweffect = potiontr[IDone].giveother() + potiontr[IDtwo].giveother();
                potiontr[IDone] = new Potion(newname, neweffect);
                var tempList = potiontr.ToList();
                tempList.RemoveAt(IDtwo);
                potiontr = tempList.ToArray();
                choice = 0;
                break;
            default:
                break;
        }
        goto schtrechbreker;
    }
}