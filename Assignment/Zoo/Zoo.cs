using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private readonly List<Animal> animals;

        public Zoo()
        {
            this.animals = new List<Animal>();
        }

        public void Starvation(Random random)
        {
            foreach (var animal in this.animals)
            {
                animal.Starving(random.Next(0, 20));
            }
        }

        public void Feeding(Random random)
        {
            foreach (var animal in this.animals.Where(x => x.IsDead == false))
            {
                animal.Feed(random.Next(5, 25));
            }
        }

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }

        public void AddAnimal(ICollection<Animal> animal)
        {
            this.animals.AddRange(animal);
        }

        public int Count()
        {
            return this.animals.Count(x => x.IsDead == false);
        }
    }
}
