using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Core
{
    public class Database : IDatabase
    {
        private IList<IBuilding> allBuildings = new List<IBuilding>();
        public IList<IBuilding> AllBuildings { get { return allBuildings; } }
        public void AddBuilding(IBuilding building)
        {
            allBuildings.Add(building);
        }
    }
}
