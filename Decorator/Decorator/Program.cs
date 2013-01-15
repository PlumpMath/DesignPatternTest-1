using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Female("female").GiveBirth(new Male("male")).Name);
            Console.WriteLine(new BioRobot("bioRobot").GiveBirth(new Male("male")).Name);
            
            Console.ReadKey();
        }
    }

    public class BioSolder : BioRobot
    {
        public BioSolder(string name) : base(name)
        {
        }

        public Person Transform(Person person)
        {
            return new BioSolder("Solder of " + person.Name);
        }
    }

    public class BioRobot : Person
    {
        public BioRobot(string name) : base(name)
        {
        }

        public Person GiveBirth(Person person)
        {
            return new Person("BioRobotSon of " + person.Name + " and " + Name);
        }
    }

    public class Female : Person
    {
        public Female(string name) : base(name)
        {
        }

        public Person GiveBirth(Male male)
        {
            return  new Person("Son of " + male.Name + " and " + Name);
        }
    }

    public class Male : Person
    {
        public Male(string name)
            : base(name)
        {
        }
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }

}
