using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private readonly List<Animal> animals;
        private readonly Dictionary<string, int> dictionary;

        public Zoo()
        {
            this.animals = new List<Animal>();
            this.dictionary = new Dictionary<string, int>();
        }

        public void Starvation(Random random)
        {
            foreach (var animal in this.animals)
            {
                animal.Starving(random.Next(0, 20));
            }
        }

        public void Feeding()
        {
            var random = new Random();

            foreach (var animal in this.animals.Where(x => x.IsDead == false))
            {
                if (!dictionary.ContainsKey(animal.GetType().Name))
                {
                    int value = random.Next(5, 26);

                    dictionary.Add(animal.GetType().Name, value);
                }

                animal.Feed(dictionary[animal.GetType().Name]);
            }

            dictionary.Clear();
        }

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }

        public void AddAnimals(ICollection<Animal> animalsToAdd)
        {
            this.animals.AddRange(animalsToAdd);
        }

        public int Count()
        {
            return this.animals.Count(x => x.IsDead == false);
        }
    }
}
