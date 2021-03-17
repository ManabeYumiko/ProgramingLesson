using System;

namespace Lesson1.ConsoleApp
{
    public class Airplane : Vehicle
    {
        public Airplane(string name) : base(name, "Avion")
        {
            if (true)
            {
            }
            else
            {
            }
        }

        public string Start(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Starting in {i}");
                Console.WriteLine(Started());
            }
            return "";
        }

        public string Stop(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"stopping in {i}");
                Console.WriteLine(Stopped());
            }
            return "";
        }
    }

    public class Vehicle
    {
        public Vehicle(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }

        public string Started()
        {
            return $"{Type} {Name} started";
        }

        public string Stopped()
        {
            return $"{Type} {Name} stopped";
        }
    }
}