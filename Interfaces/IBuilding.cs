using Empires.Models.Units;
using System.Collections.Generic;

namespace Empires.Interfaces
{
    public interface IBuilding
    {
        int TurnsForUnits { get; set; }
        int TurnsForResources { get; set; }
        int TurnsAlive { get; set; }
        IList<IUnit> ProducedUnits { get; }
        IList<Resource> ProducedResources { get; }
        void ProduceUnit();
        void ProduceResource();
    }
}
