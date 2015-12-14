namespace Empires.Models.Buildings
{
    using Abstract;
    using Interfaces;
    using Resources;
    using Units;

    public class Barracks : Building
    {
        private const int DefaultTurnsForResources = 3;
        private const int DefaultTurnsForUnits = 4;

        public Barracks(IEngine e) : base(e)
        {
            TurnsForResources = DefaultTurnsForResources + 1;
            TurnsForUnits = DefaultTurnsForUnits + 1;
        }

        public override void ProduceResource()
        {
            if(TurnsForResources == 0)
            {
                ProducedResources.Add(new Steel());
                TurnsForResources = DefaultTurnsForResources;
            }
        }

        public override void ProduceUnit()
        {
            if(TurnsForUnits == 0)
            {
                ProducedUnits.Add(new Swordsman());
                TurnsForUnits = DefaultTurnsForUnits;
            }
        }
    }
}
