using System;
using System.Collections.Generic;
using Interfaces;
using models;

namespace Services
{
    public class MainProcess
    {
        Dictionary<string, IAnimal> newAnimalList = new Dictionary<string, IAnimal>();
        static void Main(string[] args)
        {
            GameLoop gameLoop = new GameLoop();
            PublicData publicData = new PublicData();
            ConsoleWrapper c = new ConsoleWrapper();
            PluginLoder pluginLoder = new PluginLoder();


            pluginLoder.LoadPlugins();

            c.Print(publicData.headerText);

            bool shouldStop = false;
            do
            {

                gameLoop.runLoop();
                c.ConsoleDefaoult();
                c.Print(publicData.pauseScreenText);
                var input = c.KeyRead();
                switch (input.Key)
                {
                    case ConsoleKey.Escape:
                        shouldStop = true;
                        break;
                }
            } while (!shouldStop);
        }
    }
}
