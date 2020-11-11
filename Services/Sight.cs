using Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class Sight
    {
        public IAnimal checkVision(IAnimal animal, List<IAnimal> animals, int[] ranges)
        {
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            SightUpdeiter sightUpdeiter = new SightUpdeiter();
            Carnevourreset carnevourreset = new Carnevourreset();

            int listCounter = 0;
            animal = carnevourreset.resetAnimal(animal);
            for (int listItem = 0; listItem < animals.Count; listItem++)
            {
                IAnimal otherAnimal = animals.ElementAt(listItem);
                if (otherAnimal.X >= ranges[0] && otherAnimal.X <= ranges[1] && otherAnimal.Y >= ranges[2] && otherAnimal.Y <= ranges[3])
                {
                    int distance = distanceCalculator.calculateDistance(otherAnimal.X, otherAnimal.Y, animal.X, animal.Y);
                    animal.targetID = listCounter;
                    animal = sightUpdeiter.update(animal, otherAnimal, distance);
                }
                listCounter++;
            }
            return animal;
        }
    }
}
