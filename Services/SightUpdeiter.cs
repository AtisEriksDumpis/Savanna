using Interfaces;

namespace Services
{
    class SightUpdeiter
    {
        public IAnimal update(IAnimal animal, IAnimal animalInSight, int distance)
        {
            PartnerAdder partnerAdder = new PartnerAdder();
            PartnerRemover partnerRemover = new PartnerRemover();

            if (animalInSight.eatsMeat == animal.eatsMeat)
            {
                if (distance < 2 && distance !=0)
                {
                    animal = partnerAdder.addPartner(animal, animalInSight);
                }
                else animal = partnerRemover.removePartner(animal, animalInSight.UniqueID);
                if (animalInSight.X == animal.X && animalInSight.Y == (animal.Y - 1)) animal.blockedSides[0] = true;
                if (animalInSight.X == animal.X && animalInSight.Y == (animal.Y + 1)) animal.blockedSides[1] = true;
                if (animalInSight.X == (animal.X - 1) && animalInSight.Y == animal.Y) animal.blockedSides[2] = true;
                if (animalInSight.X == (animal.X + 1) && animalInSight.Y == animal.Y) animal.blockedSides[3] = true;
            }
            else
            {
                if (distance.Equals(0) && !animalInSight.eatsMeat)
                {
                    animal.targetInViev = true;
                    animal.targetDir = null;
                    animal.targetDist = 20;
                    animal.onAnimal = true;
                    animal.life = 15;
                    return animal;
                }
                else if (distance < animal.targetDist)
                {
                    animal.targetInViev = true;
                    animal.targetDist = distance;
                    if (animalInSight.X < animal.X){
                        if (animalInSight.Y < animal.Y) { animal.targetDir = animal.eatsMeat? 1:8; }
                        else if (animalInSight.Y == animal.Y) { animal.targetDir = animal.eatsMeat ? 2:7; }
                        else if (animalInSight.Y > animal.Y) { animal.targetDir = animal.eatsMeat ? 3:6; }
                    }
                    else if (animalInSight.X == animal.X)
                    {
                       if (animalInSight.Y < animal.Y) { animal.targetDir = animal.eatsMeat ? 4:5; }
                        else if(animalInSight.Y > animal.Y) { animal.targetDir = animal.eatsMeat ? 5:4; }
                    }
                    else if (animalInSight.X > animal.X) 
                    {
                       if (animalInSight.Y < animal.Y) { animal.targetDir = animal.eatsMeat ? 6:3; }
                        else if(animalInSight.Y == animal.Y) { animal.targetDir = animal.eatsMeat ? 7:2; }
                        else if(animalInSight.Y > animal.Y) { animal.targetDir = animal.eatsMeat ? 8:1; }
                    }
                }
            }
            animal.targetID = null;
            return animal;
        }
    }
}
