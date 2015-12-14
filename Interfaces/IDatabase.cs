using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Interfaces
{
    public interface IDatabase
    {
        IList<IBuilding> AllBuildings { get; }
        void AddBuilding(IBuilding building);
    }
}
