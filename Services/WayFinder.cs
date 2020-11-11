using Interfaces;

namespace Services
{
    class WayFinder
    {
        public IAnimal returnMoveAlteringSatats(IAnimal animal)
        {
            ConsoleWrapper c = new ConsoleWrapper();
            PublicData publicData = new PublicData();

            if (animal.targetInViev)
            {
                switch (animal.targetDir)
                {
                case null:
                    return animal;
                case 1:
                    if (animal.blockedSides[0] && animal.blockedSides[2]) break;
                    else if (animal.blockedSides[0]) animal.X = animal.X - 1;
                    else if (animal.blockedSides[2]) animal.Y = animal.Y - 1;
                    else if (c.randomInt(2) == 1) animal.X -= 1; else animal.Y -= 1;
                    break;
                case 2:
                    if (animal.blockedSides[2]) break;
                    else animal.X -= 1;
                    break;
                case 3:
                    if (animal.blockedSides[1] && animal.blockedSides[2]) break;
                    else if (animal.blockedSides[1]) animal.X -= 1;
                    else if (animal.blockedSides[2]) animal.Y += 1;
                    else if (c.randomInt(2) == 1) animal.X -= 1; else animal.Y += 1;
                    break;
                case 4:
                    if (animal.blockedSides[0]) break;
                    else animal.Y -= 1;
                    break;
                case 5:
                    if (animal.blockedSides[1]) break;
                    else animal.Y += 1;
                    break;
                case 6:
                    if (animal.blockedSides[0] && animal.blockedSides[3]) break;
                    else if (animal.blockedSides[0]) animal.X += 1;
                    else if (animal.blockedSides[3]) animal.Y -= 1;
                    else if (c.randomInt(2) == 1) animal.X += 1; else animal.Y -= 1;
                    break;
                case 7:
                    if (animal.blockedSides[3]) break;
                    else animal.X += 1;
                    break;
                case 8:
                    if (animal.blockedSides[0] && animal.blockedSides[3]) break; 
                    else if (animal.blockedSides[3]) animal.Y += 1;
                    else if (animal.blockedSides[1]) animal.X += 1;
                    else if (c.randomInt(2) == 1) animal.X += 1; else animal.Y += 1;
                    break;
                }

            }
            else
            {
                switch (animal.moveDir)
                {
                    case 1:
                    if (animal.blockedSides[0]) 
                    {
                        int random = c.randomInt(3);
                        if (random.Equals(1) && !animal.blockedSides[1]) 
                        { 
                            animal.Y += 1;
                            animal.moveDir = 4;
                        }
                        else if (random.Equals(2) && !animal.blockedSides[2]) 
                        {
                            animal.X -= 1; 
                            animal.moveDir = 2;
                        }
                        else if (random.Equals(3) && !animal.blockedSides[3]) 
                        {
                            animal.X += 1;
                            animal.moveDir = 3;
                        }
                    }
                    else animal.Y -= 1;
                        break;

                    case 2:
                    if (animal.blockedSides[2])
                    {
                        int random = c.randomInt(3);
                        if (random.Equals(1) && !animal.blockedSides[3])
                        {
                            animal.X += 1;
                            animal.moveDir = 3;
                        }
                        else if (random.Equals(2) && !animal.blockedSides[0])
                        {
                            animal.Y -= 1;
                            animal.moveDir = 1;
                        }
                        else if (random.Equals(3) && !animal.blockedSides[1])
                        {
                            animal.Y += 1;
                            animal.moveDir = 4;
                        }
                    }
                    else animal.X -= 1;
                    break;
                case 3:
                    if (animal.blockedSides[3])
                    {
                        int random = c.randomInt(3);
                        if (random.Equals(1) && !animal.blockedSides[0])
                        {
                            animal.Y -= 1;
                            animal.moveDir = 1;
                        }
                        else if (random.Equals(2) && !animal.blockedSides[1])
                        {
                            animal.Y += 1;
                            animal.moveDir = 4;
                        }
                        else if (random.Equals(3) && !animal.blockedSides[2])
                        {
                            animal.X -= 1;
                            animal.moveDir = 2;
                        }
                    }
                    else animal.X += 1;
                    break;
                case 4:
                    if (animal.blockedSides[1])
                    {
                        int random = c.randomInt(3);
                        if (random.Equals(1) && !animal.blockedSides[2])
                        {
                            animal.X -= 1;
                            animal.moveDir = 2;
                        }
                        else if (random.Equals(2) && !animal.blockedSides[3])
                        {
                            animal.X += 1;
                            animal.moveDir = 3;
                        }
                        else if (random.Equals(3) && !animal.blockedSides[0])
                        {
                            animal.Y -= 1;
                            animal.moveDir = 1;
                        }
                    }
                    else animal.Y += 1;
                    break;

                }
            }
            animal.Y = animal.Y < 0 ? 0 : animal.Y;
            animal.X = animal.X < 0 ? 0 : animal.X;
            animal.Y = animal.Y >= publicData.FieldAxisSize ? publicData.FieldAxisSize-1 : animal.Y;
            animal.X = animal.X >= publicData.FieldAxisSize ? publicData.FieldAxisSize - 1 : animal.X;

            return animal;
        }
    }
}
