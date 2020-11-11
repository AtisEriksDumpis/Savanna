using Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class Killer
    {
        public List<IAnimal> killAntilopes(List<IAnimal> animals)
        {
            int killedAnimals = 0;
            for (int listItem = 0; listItem < animals.Count; listItem++)
            {
                IAnimal animal = animals.ElementAt(listItem);
                if (animal.eatsMeat && animal.onAnimal)
                {
                    animal.onAnimal = false;
                    int x = animal.targetID ?? default(int);
                    animals.RemoveAt(x - killedAnimals);
                    killedAnimals++;
                }
            }
            return animals;
        }
        public List<IAnimal> killByHealthBar(List<IAnimal> animals)
        {
            int killedAnimals = 0;
            for (int listItem = 0; listItem < animals.Count; listItem++)
            {
                IAnimal animal = animals.ElementAt(listItem);
                if (animal.life.Equals(0))
                {
                    animals.RemoveAt(listItem - killedAnimals);
                    killedAnimals++;
                }
            }
            return animals;
        }
    }
}
