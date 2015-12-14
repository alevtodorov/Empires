using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Buildings
{
    using Abstract;
    using Units;
    using Resources;
    using Interfaces;

    public class Archery : Building
    {
        private const int DefaultTurnsForResources = 2;
        private const int DefaultTurnsForUnits = 3;

        public Archery(IEngine e) : base(e)
        {
            TurnsForResources = DefaultTurnsForResources + 1;
            TurnsForUnits = DefaultTurnsForUnits + 1;
        }

        public override void ProduceResource()
        {
            if(TurnsForResources == 0)
            {
                ProducedResources.Add(new Gold());
                TurnsForResources = DefaultTurnsForResources;
            }
        }

        public override void ProduceUnit()
        {
            if(TurnsForUnits == 0)
            {
                ProducedUnits.Add(new Archer());
                TurnsForUnits = DefaultTurnsForUnits;
            }
        }
    }
}
