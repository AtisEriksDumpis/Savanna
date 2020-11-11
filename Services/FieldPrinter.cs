using Interfaces;
using System.Collections.Generic;

namespace Services
{
    class FieldPrinter
    {
        public void drawCurentState(List<IAnimal> animals)
        {
            PublicData publicData = new PublicData();
            ConsoleWrapper c = new ConsoleWrapper();
            TileChecker tileChecker = new TileChecker();
            TilePrinter tilePrinter = new TilePrinter();

            int caount = animals.Count;
            c.Print("Alive animals" + caount);
            for (int yAxis = 0; yAxis < publicData.FieldAxisSize; yAxis++)
            {
                for (int xAxis = 0; xAxis < publicData.FieldAxisSize; xAxis++)
                {
                    IAnimal tile = tileChecker.serchAnimalInTile(animals, xAxis, yAxis);
                    tilePrinter.printTile(tile);
                }
                c.newLine();

            }
            c.ConsoleDefaoult();
        }
    }
}
