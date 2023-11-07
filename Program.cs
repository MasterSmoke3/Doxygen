// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");






/*!
    \brief Краткое описание -
     Класс родителей героев
    
*/
public class Hero
{
    int lvl;
    int hp;
    int damage;
    int armor;



    public Hero (int lvl, int hp, int damage, int armor)
    {
        this.lvl = lvl;
        this.hp = hp;
        this.damage = damage;
        this.armor = armor;
    }

    public int GetHp()
    {
        return hp;
    }

    public int GetArmor()
    {
        return lvl*armor;
    }
}


/*!
    \brief Краткое описание -
     Подкласс "Воин"
    
*/
public class Warrior : Hero
{
    int lvl;
    int hp;
    int damage;
    int armor;

    public Warrior (int lvl, int hp, int damage, int armor) : base (lvl, hp, damage, armor)
    {
        this.lvl = lvl;
        this.hp = hp;
        this.damage = damage;
        this.armor = armor;
    }

    public int GetMoreDamage()
    {
        return lvl*damage*5;
    }

}



/*!
    \brief Краткое описание -
     Родитель щитов
    
*/
public class Shield
{
    int armor;
    int price;

    public Shield (int armor, int price)
    {
        this.armor = armor;
        this.price = price;
    }

    public int GetPrice()
    {
        return price;
    }
}
/*!
    \brief Краткое описание -
     Подкласс "Тяжелый щит"
    
*/


public class HeavyShield : Shield
{
    int armor;
    int price;
    int damage;

    public HeavyShield (int armor, int damage, int price) : base (armor, price)
    {
        this.armor = armor;
        this.damage = damage;
        this.price = price;
    }

    public int SpecialSpell()
    {
        return armor*damage;
    }
}
/*!
    \brief Краткое описание -
     Подкласс "Дегкий щит"
    
*/

public class LiteShield : Shield
{
    int armor;
    int price;

    public LiteShield(int armor, int price) : base (armor, price)
    {
        this.armor = armor;
        this.price = price;
    }

    public int SpecialSpellArmor()
    {
        return armor+10;
    }
}

/*!
    \brief Краткое описание
     Запуск кода
    
*/

public class Start
{
    public static void Main()
    {
        Warrior warrior = new Warrior(11, 66, 43, 49);
        LiteShield shield = new LiteShield(43, 1431);
        int allArmor = warrior.GetArmor() + shield.SpecialSpellArmor();
        Console.WriteLine("Hp: " + warrior.GetHp());
        Console.WriteLine("Armor: " + allArmor);
        Console.WriteLine("Damage: " + warrior.GetMoreDamage());
    }
}



