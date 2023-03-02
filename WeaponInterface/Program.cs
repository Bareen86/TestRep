abstract class Weapon
{
    public abstract int Damage { get; }
    public abstract void Fire();

    public void ShowInfo()
    {
        Console.WriteLine($"{GetType().Name} Damage : {Damage}"); // выводит тип данных
    }
}

class Gun : Weapon
{
    public override int Damage
    {
        get { return 5; }
    }

    public override void Fire()
    {
        Console.WriteLine("Пау-Пау!");
    }
}
class Laser : Weapon
{
    public override int Damage { get { return 30; } }

    public override void Fire()
    {
        Console.WriteLine("Д-з-з-з-з");
    }
}
class Bow : Weapon
{
    public override int Damage => 10;

    public override void Fire()
    {
        Console.WriteLine("Стрела выпущена!");
    }
}

class Player
{
    public void Fire(Weapon weapon)
    {
        weapon.Fire();
    }

    public void CheckInfo(Weapon weapon)
    {
        weapon.ShowInfo();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Weapon[] inventory = { new Gun(), new Laser(), new Bow() };
        foreach (var item in inventory)
        {
            player.CheckInfo(item);
            player.Fire(item);
            Console.WriteLine();
        }
    }

}