using Interfaces;

namespace Services
{
    class TilePrinter
    {
        public void printTile(IAnimal animal)
        {
            ConsoleWrapper c = new ConsoleWrapper();
            PublicData publicData = new PublicData();

            if (animal == null)
            {
                c.ConsoleGreen();
                c.PrintInLine(publicData.grass);
            }
            else
            {
                animal.animalColor();
                c.PrintInLine(animal.fieldText);
            }
        }
    }
}
