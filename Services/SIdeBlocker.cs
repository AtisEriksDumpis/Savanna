using Interfaces;

namespace Services
{
    class SIdeBlocker
    {
        public IAnimal blockSides(int[] viewRanges, IAnimal anim)
        {
            PublicData publicData = new PublicData();
            for (int fourSides = 0; fourSides < 4; fourSides++) anim.blockedSides[fourSides] = false;
            if (anim.X == 0) anim.blockedSides[2] = true;
            if (anim.Y == 0) anim.blockedSides[0] = true;
            if (anim.X == publicData.FieldAxisSize-1) anim.blockedSides[1] = true;
            if (anim.Y == publicData.FieldAxisSize-1) anim.blockedSides[3] = true;
            return anim;
        }
    }
}
