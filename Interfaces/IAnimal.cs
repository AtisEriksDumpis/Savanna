using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IAnimal
    {
        int X { get; set; }
        int Y { get; set; }
        int vievDist { get; set; }
        int moveDist { get; set; }
        bool eatsMeat { get; set; }
        bool eatsGras { get; set; }
        int moveDir { get; set; }
        int? targetDist { get; set; }
        int? targetDir { get; set; }
        bool targetInViev { get; set; }
        bool[] blockedSides { get; set; } 
        int? targetID { get; set; }
        bool onAnimal { get; set; }
        double life { get; set; }
        int UniqueID { get; set; }
        int? partnersID { get; set; }
        int[] near1Turn { get; set; }
        int[] near2Turns { get; set; }
        int[] near3Turns { get; set; }
        bool shouldMakeChild { get; set; }
        string fieldText { get; set; }
        string animalName { get; set; }
        ConsoleKey activKey { get; set; }
        void animalColor();
    }
}
