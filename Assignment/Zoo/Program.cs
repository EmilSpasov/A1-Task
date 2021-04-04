using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            var zoo = new Zoo();

            var animals = new List<Animal>
            {
                new Lion(),
                new Lion(),
                new Lion(),
                new Lion(),
                new Lion(),

                new Elephant(),
                new Elephant(),
                new Elephant(),
                new Elephant(),
                new Elephant(),

                new Monkey(),
                new Monkey(),
                new Monkey(),
                new Monkey(),
                new Monkey(),
            };

            zoo.AddAnimals(animals);
            
            zoo.Starvation(r);

            zoo.Feeding(r);

            Console.WriteLine(zoo.Count());
        }
    }
}
