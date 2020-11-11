using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Services
{
    class Mover
    {
        public List<IAnimal> moveAmimals(List<IAnimal> animals)
        {
            ConsoleWrapper c = new ConsoleWrapper();
            Killer antilopeKiller = new Killer();
            FieldPrinter fieldPrinter = new FieldPrinter();
            PublicData publicData = new PublicData();
            IndividualMover individualMover = new IndividualMover();

            List<IAnimal> newList = new List<IAnimal>();
            for (int listItem = 0; listItem < animals.Count; listItem++)
            {
                IAnimal animal = animals.ElementAt(listItem);
                if (animal.eatsMeat && !animal.life.Equals(0))
                {
                    animal.targetID = null;
                    animal.moveDir = c.randomInt(4);
                    newList.Add(individualMover.move(animal, animals));

                }
                else newList.Add(animal);
            }
            newList = antilopeKiller.killAntilopes(newList);
            Console.SetCursorPosition(0, 1);
            //c.clear();
            //c.Print(publicData.headerText);
            fieldPrinter.drawCurentState(animals);
            Thread.Sleep(100);
            for (int listItem = 0; listItem < newList.Count; listItem++)
            {
                IAnimal animal = animals.ElementAt(listItem);
                if (!animal.eatsMeat)
                {
                    animal.moveDir = c.randomInt(4);
                    newList.RemoveAt(listItem);
                    newList.Add(individualMover.move(animal, animals));
                }
            }
            newList = antilopeKiller.killByHealthBar(newList);
            return newList;
        }
    }
}
