using System;
public class BProgram{
class Bird
    {
        protected string name;
        public Bird(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Bird Sound");
        }
    }

    class Parrot : Bird
    {
        public Parrot(string name) : base(name)
        {
            Console.WriteLine("Parrot");
        }

       public sealed override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine(name+" says: Squawk!");
        }
    }
    class Eagle :Parrot
    {
        public Eagle(string name) : base(name)
        {
            Console.WriteLine("Parrot");
        }

       public  sealed override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine(name+" says: Squawk!");
        }
    }
    
        public static void Main(string[] args)
        {
            Parrot p = new Parrot("Maci");
            p.MakeSound();
            
        }
}