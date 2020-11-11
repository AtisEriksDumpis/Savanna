using Interfaces;
using System.Linq;

namespace Services
{
    class PartnerRemover
    {
        public IAnimal removePartner(IAnimal animal, int cemovableID)
        {
            animal.near1Turn = animal.near1Turn.Except(new int[] { cemovableID }).ToArray();
            animal.near2Turns = animal.near2Turns.Except(new int[] { cemovableID }).ToArray();
            animal.near3Turns = animal.near3Turns.Except(new int[] { cemovableID }).ToArray();
            return animal;
        }
    }
}
