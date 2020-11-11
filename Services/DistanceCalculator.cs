using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class DistanceCalculator
    {
        public int calculateDistance(int xAnimal, int yAnimal, int xCord, int yCord)
        {
            int distance = 0;
            if (xAnimal > xCord) distance = xAnimal - xCord;
            else distance = xCord - xAnimal;
            if (yAnimal > yCord) distance += yAnimal - yCord;
            else distance += yCord - yAnimal;
            return distance;
        }
    }
}
