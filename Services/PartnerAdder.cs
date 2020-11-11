using Interfaces;
using System;
using System.Linq;

namespace Services
{
    class PartnerAdder
    {
        public IAnimal addPartner(IAnimal maine, IAnimal comparative)
        {
            if (maine.near3Turns.Contains(comparative.UniqueID))
            {
                maine.shouldMakeChild = true;
                maine.near1Turn = new int[25];
                maine.near2Turns = new int[25];
                maine.near3Turns = new int[25];
                maine.partnersID = comparative.UniqueID;
            }
            else if (maine.near2Turns.Contains(comparative.UniqueID))
            {
                maine.near3Turns = maine.near3Turns.Concat(new int[] { comparative.UniqueID }).ToArray();
                maine.near2Turns = maine.near2Turns.Except(new int[] { comparative.UniqueID}).ToArray();

            }
            else if (maine.near1Turn.Contains(comparative.UniqueID))
            {
                maine.near2Turns = maine.near2Turns.Concat(new int[] { comparative.UniqueID }).ToArray();
                maine.near1Turn = maine.near1Turn.Except(new int[] { comparative.UniqueID }).ToArray();
            }
            else
            {
                maine.near1Turn = maine.near1Turn.Concat(new int[] { comparative.UniqueID }).ToArray();
            }
            return maine;
        }
    }
}
