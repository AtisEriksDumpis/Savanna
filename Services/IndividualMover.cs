using Interfaces;
using System.Collections.Generic;

namespace Services
{
    class IndividualMover
    {
        public IAnimal move(IAnimal animal, List<IAnimal> animals)
        {
            RangeCalculator rangeCalculator = new RangeCalculator();
            Sight sight = new Sight();
            SIdeBlocker sideBlocker = new SIdeBlocker();
            WayFinder wayFinder = new WayFinder();

            animal.life -= 0.5;
            for (int move = 0; move < animal.moveDist; move++)
            {
                int[] viewRanges = rangeCalculator.calculateRanges(animal.X, animal.Y, animal.vievDist);
                animal.blockedSides = new bool[4];
                animal = sideBlocker.blockSides(viewRanges, animal);
                animal.targetInViev = false;
                animal = sight.checkVision(animal, animals, viewRanges);
                animal = wayFinder.returnMoveAlteringSatats(animal);
            }
            return animal;
        }
    }
}
