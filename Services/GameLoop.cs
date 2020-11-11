using Interfaces;
using models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Services
{
    class GameLoop
    {
        public List<IAnimal> animals = new List<IAnimal>();
        public int uniqueID = 0;
        public void runLoop()
        {
            PublicData publicData = new PublicData();
            ConsoleWrapper c = new ConsoleWrapper();
            FieldPrinter fieldPrinter = new FieldPrinter();
            Mover animalMover = new Mover();
            BabyMaker babyMaker = new BabyMaker();
            PluginLoder pluginLoder = new PluginLoder();
            bool shouldPause = true;
            do
            {
                pluginLoder.LoadPlugins();
                while (!Console.KeyAvailable)
                {
                    animals = animalMover.moveAmimals(animals);
                    animals = babyMaker.checkIfBabyCanBorn(animals);
                    c.ConsoleDefaoult();
                    Console.SetCursorPosition(0,1);
                    fieldPrinter.drawCurentState(animals);
                    Thread.Sleep(100);
                }
                ConsoleKey presed = Console.ReadKey(true).Key;
                switch (presed)
                {
                    case ConsoleKey.P:
                        shouldPause = false;
                        break;
                    default:
                        foreach(IAnimal aniType in PluginLoder.Plugins)
                        {
                            if(presed == aniType.activKey)
                            {
                                IAnimal newAnimal = aniType;
                                newAnimal.UniqueID = uniqueID;
                                uniqueID++;
                                newAnimal.moveDir = c.randomInt(4);
                                animals.Add(newAnimal);
                                break;
                            }
                        }
                        break;
                }
            } while (shouldPause);
        }
    }
}
