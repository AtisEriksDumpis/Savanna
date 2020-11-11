using Interfaces;
using System;

namespace models
{
    public class Zebra : IAnimal
    {
        public string animalName { get; set; } = "Zebra";
        public int X { get; set; } = 7;
        public int Y { get; set; } = 7;
        public int vievDist { get; set; } = 3;
        public int moveDist { get; set; } = 1;
        public bool eatsMeat { get; set; } = false;
        public bool eatsGras { get; set; } = true;
        public int moveDir { get; set; }
        public int? targetDist { get; set; }
        public int? targetDir { get; set; }
        public bool targetInViev { get; set; } = false;
        public bool[] blockedSides { get; set; } = new bool[4];
        public int? targetID { get; set; }
        public bool onAnimal { get; set; } = false;
        public double life { get; set; } = 5;
        public int UniqueID { get; set; }
        public int? partnersID { get; set; }
        public int[] near1Turn { get; set; } = new int[25];
        public int[] near2Turns { get; set; } = new int[25];
        public int[] near3Turns { get; set; } = new int[25];
        public bool shouldMakeChild { get; set; } = false;
        public string fieldText { get; set; } = "Ze";
        public ConsoleKey activKey { get; set; } = ConsoleKey.Z;
        public void animalColor()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
