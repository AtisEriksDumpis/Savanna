using Interfaces;
using models;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class BabyMaker
    {
        public List<IAnimal> checkIfBabyCanBorn(List<IAnimal> animals)
        {
            GameLoop gameLoop = new GameLoop();
            ConsoleWrapper c = new ConsoleWrapper();
            RangeCalculator rangeCalculator = new RangeCalculator();
            SIdeBlocker sideBlocker = new SIdeBlocker();
            NewBornPlacer newBornPlacer = new NewBornPlacer();

            List<IAnimal> newList = new List<IAnimal>();
            for(int listItem = 0; listItem < animals.Count; listItem++)
            {
                bool confirmPartner = false;
                IAnimal animal = animals.ElementAt(listItem);
                if (animal.shouldMakeChild)
                {
                    
                    foreach(IAnimal anim in animals) if (anim.UniqueID == animal.partnersID && anim.shouldMakeChild) confirmPartner = true;

                    if (confirmPartner)
                    {
                        animal.shouldMakeChild = false;
                        if (animal.eatsMeat) {
                            Lion lion = new Lion();
                            int[] viewRanges = rangeCalculator.calculateRanges(animal.X, animal.Y, animal.vievDist);
                            animal = sideBlocker.blockSides(viewRanges, animal);
                            int[] cordinates = newBornPlacer.PlaceNewAnimal(animal, animals);
                            lion.X = cordinates[0];
                            lion.Y = cordinates[1];
                            lion.UniqueID = gameLoop.uniqueID;
                            lion.moveDir = c.randomInt(4);
                            newList.Add(lion);
                        }
                        else {
                            Antilope antilope = new Antilope();
                            int[] viewRanges = rangeCalculator.calculateRanges(animal.X, animal.Y, animal.vievDist);
                            animal = sideBlocker.blockSides(viewRanges, animal);
                            int[] cordinates = newBornPlacer.PlaceNewAnimal(animal, animals);
                            antilope.X = cordinates[0];
                            antilope.Y = cordinates[1];
                            antilope.UniqueID = gameLoop.uniqueID;
                            antilope.moveDir = c.randomInt(4);
                            newList.Add(antilope);
                        }
                        gameLoop.uniqueID++;
                    }

                }
                newList.Add(animal);
            }
            return newList;
        }
    }
}
