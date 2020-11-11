using Interfaces;

namespace Services
{
    class Carnevourreset
    {
        public IAnimal resetAnimal(IAnimal animal)
        {
            if (animal.eatsMeat) {
                animal.targetInViev = false;
                animal.targetDir = null;
                animal.targetDist = 20;
            }

            return animal;
        }
    }
}
