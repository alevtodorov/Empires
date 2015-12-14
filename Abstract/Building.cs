using Empires.Core;
using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Abstract
{
    public abstract class Building : IBuilding
    {
        private IList<IUnit> producedUnits;
        private IList<Resource> producedResources;
        private IEngine engine;

        protected Building(IEngine e) 
        {
            producedUnits = new List<IUnit>();
            producedResources = new List<Resource>();
            engine = e;
            e.OnTurn += ReduceTurns;
        }

        public IList<IUnit> ProducedUnits { get { return producedUnits; } }
        public IList<Resource> ProducedResources { get { return producedResources; } }
        public int TurnsForUnits { get; set; }
        public int TurnsForResources { get; set; }
        public int TurnsAlive { get; set; }

        public abstract void ProduceUnit();
        public abstract void ProduceResource();

        private void ReduceTurns(object sender, EventArgs args)
        {
            TurnsForResources--;
            ProduceResource();
            TurnsForUnits--;
            ProduceUnit();
            TurnsAlive++;
        }

    }
}
