using Interfaces;
using System;

namespace models
{
    public class Hiena : IAnimal
    {
        public int X { get; set; } = 6;
        public int Y { get; set; } = 6;
        public int vievDist { get; set; } = 7;
        public int moveDist { get; set; } = 1;
        public bool eatsMeat { get; set; } = true;
        public bool eatsGras { get; set; } = false;
        public int moveDir { get; set; }
        public int? targetDist { get; set; }
        public int? targetDir { get; set; }
        public bool targetInViev { get; set; } = false;
        public bool[] blockedSides { get; set; }
        public int? targetID { get; set; }
        public bool onAnimal { get; set; } = false;
        public double life { get; set; } = 100;
        public int UniqueID { get; set; }
        public int? partnersID { get; set; }
        public int[] near1Turn { get; set; } = new int[25];
        public int[] near2Turns { get; set; } = new int[25];
        public int[] near3Turns { get; set; } = new int[25];
        public bool shouldMakeChild { get; set; } = false;
        public string fieldText { get; set; } = "Hi";
        public string animalName { get; set; } = "Hiena";
        public ConsoleKey activKey { get; set; } = ConsoleKey.H;
        public void animalColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
    }
}
