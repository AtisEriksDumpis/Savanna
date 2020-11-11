using System;
using Interfaces;

namespace models
{
    public class Lion : IAnimal
    {
        public string animalName { get; set; } = "Lion";
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int vievDist { get; set; } = 5;
        public int moveDist { get; set; } = 3;
        public bool eatsMeat { get; set; } = true;
        public bool eatsGras { get; set; } = false;
        public int moveDir { get; set; }
        public int? targetDist { get; set; }
        public int? targetDir { get; set; }
        public bool targetInViev { get; set; } = false;
        public bool[] blockedSides { get; set; } = new bool[4];
        public int? targetID { get; set; }
        public bool onAnimal { get; set; } = false;
        public double life { get; set; } = 10;
        public int UniqueID { get; set; }
        public int? partnersID { get; set; }
        public int[] near1Turn { get; set; } = new int[25];
        public int[] near2Turns { get; set; } = new int[25];
        public int[] near3Turns { get; set; } = new int[25];
        public bool shouldMakeChild { get; set; } = false;
        public string fieldText { get; set; } = "Li";
        public ConsoleKey activKey { get; set; } = ConsoleKey.L;
        public void animalColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
    };
}
