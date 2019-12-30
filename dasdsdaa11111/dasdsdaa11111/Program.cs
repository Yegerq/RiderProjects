using System;

namespace dasdsdaa11111
{
    class Program
    {
        class Car
        {
            public string Name;
            public int Weight;
            public int Power;
        }


        class Lorry : Car
        {
            public string Name;
            public int Weight = 500;
            public int Power = 3000;
        }

        class Main_Method
        {
            static void Main(string[] args)
            {
                Lorry d = new Lorry();
                var dName = d.Name;
                var dWeight = d.Weight;
                var dPower = d.Power;

                Console.WriteLine("Full information about Lorry: ");
                Console.WriteLine("Weight is: ");
                Console.WriteLine(d.Weight);
            }
        }
    }
}
