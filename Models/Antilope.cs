using Interfaces;
using System;

namespace models
{
    public class Antilope : IAnimal
    {
        public string animalName { get; set; } = "Antilope";
        public int X { get; set; } = 9;
        public int Y { get; set; } = 9;
        public int vievDist { get; set; } = 3;
        public int moveDist { get; set; } = 2;
        public bool eatsMeat { get; set; } = false;
        public bool eatsGras { get; set; } = true;
        public int moveDir { get; set; }
        public int? targetDist { get; set; }
        public int? targetDir { get; set; }
        public bool targetInViev { get; set; } = false;
        public bool[] blockedSides { get; set; } = new bool[4];
        public int? targetID { get; set; }
        public bool onAnimal { get; set; } = false;
        public double life { get; set; } = 20;
        public int UniqueID { get; set; }
        public int? partnersID { get; set; }
        public int[] near1Turn { get; set; } = new int[25];
        public int[] near2Turns { get; set; } = new int[25];
        public int[] near3Turns { get; set; } = new int[25];
        public bool shouldMakeChild { get; set; } = false;
        public string fieldText { get; set; } = "An";
        public ConsoleKey activKey { get; set; } = ConsoleKey.A;
        public void animalColor()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
    }
}
