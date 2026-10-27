using System;
public class BirdProgram{
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

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine(name+" says: Squawk!");
        }
    }
    class Sparrow : Bird
    {
        public Sparrow(string name) : base(name)
        {
            Console.WriteLine("Sparrow");
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine(name +" says: Chrip!");
        }
    }
        public static void Main(string[] args)
        {
            Parrot p = new Parrot("Maci");
            p.MakeSound();
            Sparrow s = new Sparrow("Jack");
            s.MakeSound();
        }
}