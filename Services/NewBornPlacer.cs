using Interfaces;
using System.Collections.Generic;

namespace Services
{
    class NewBornPlacer
    {
        public int[] PlaceNewAnimal(IAnimal animal, List<IAnimal> otheranimals)
        {
            int[] cords = new int[2];
            foreach(IAnimal anim in otheranimals)
            {
                if (animal.X.Equals(anim.X) && animal.Y.Equals(anim.Y - 1)) animal.blockedSides[0] = true;
                if (animal.X.Equals(anim.X) && animal.Y.Equals(anim.Y + 1)) animal.blockedSides[1] = true;
                if (animal.X.Equals(anim.X - 1) && animal.Y.Equals(anim.Y)) animal.blockedSides[2] = true;
                if (animal.X.Equals(anim.X + 1) && animal.Y.Equals(anim.Y)) animal.blockedSides[3] = true;
            }

            if (!animal.blockedSides[0])
            {
                cords[0] = animal.X;
                cords[1] = animal.Y - 1;
            }
            else if (!animal.blockedSides[1])
            {
                cords[0] = animal.X;
                cords[1] = animal.Y + 1;
            }
            else if (!animal.blockedSides[2])
            {
                cords[0] = animal.X - 1;
                cords[1] = animal.Y;
            }
            else if (!animal.blockedSides[3])
            {
                cords[0] = animal.X + 1;
                cords[1] = animal.Y;
            }

            return cords;
        }
    }
}
