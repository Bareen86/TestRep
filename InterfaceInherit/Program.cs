using System.Numerics;
using System.Reflection.Emit;

interface IWeapon
{
    void Fire();
}

interface IThrowingWeapon : IWeapon
{
    void Throw();
}

class Gun: IWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name}: Пыщ!");
    }
}

class LaserGun : IWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name}: Пыщ!");
    }
}

class SuperKnife : IThrowingWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name}: П-р-р-р-р");
    }

    public void Throw()
    {
        Console.WriteLine($"{GetType().Name}: Бросок!");
    }
}

class Knife : IThrowingWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name}: Пыщ!");
    }

    public void Throw()
    {
        Console.WriteLine($"{GetType().Name}: Фьють!");
    }
}

class Player
{
    public void Fire(IWeapon weapon)
    {
        weapon.Fire();
    }

    public void Throw(IThrowingWeapon throwingWeapon)
    {
        throwingWeapon.Throw();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        IWeapon[] inventory = {new Gun(),new LaserGun(), new Knife(), new SuperKnife()};

        foreach (var item in inventory)
        {
            player.Fire(item);
            Console.WriteLine();
        }
        player.Throw(new Knife());
        Console.WriteLine();
        player.Throw(new SuperKnife());
    } 
}