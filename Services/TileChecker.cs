using Interfaces;
using System.Collections.Generic;

namespace Services
{
    class TileChecker
    {
        public IAnimal serchAnimalInTile(List<IAnimal> animals, int xAxis, int yAxis)
        {
            foreach(IAnimal animal in animals)
            {
                if(animal.X.Equals(xAxis) && animal.Y.Equals(yAxis))
                {
                    return animal;
                }
            }
            return null;
        }
    }
}
