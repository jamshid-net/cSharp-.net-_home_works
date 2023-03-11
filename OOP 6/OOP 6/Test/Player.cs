namespace OOP_6.Test
{
    interface IMove
    { 
         void Move()
        {
            Console.WriteLine("move");
        }
       
        
    
    }

    class Personn : IMove
    {
        
    }
    interface IHasInfo
    {
        public void CheckInfo();
    }
    interface Iweapon
    {
        int Damage { get; }
        public void Fire();
    }
    abstract class Weapon : Iweapon, IHasInfo
    {
        abstract public int Damage { get; set; }
        abstract public void Fire();
        public void CheckInfo()
        {
            Console.WriteLine($"{GetType().Name} is fired");
            Console.WriteLine($"Damage:{Damage * -1}");
        }


    }
    class Awp : Weapon
    {
        public override int Damage { get; set; }
        
        public override void Fire()
        {
            Console.WriteLine("-->");
        }
    }
    class Ak47 : Weapon
    {
        public override int Damage { get { return 40; } set { } }

        public override void Fire()
        {
            Console.WriteLine("-->");
        }
    }
    class M4a4 : Weapon
    {
        public override int Damage { get { return 25; } set { } }

        public override void Fire()
        {
            Console.WriteLine("-->");
        }
    }

    class Player
    {
        public virtual void Stop()
        {
            Console.WriteLine("FAFAFA");
        }
        public void Info(IHasInfo ihasinfo)
        {
            ihasinfo.CheckInfo();
            
        }
        public void Fire(Iweapon iweapon)
        {
            iweapon.Fire();
        }
        

        
    }

}
