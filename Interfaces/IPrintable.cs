using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Interfaces
{
    public interface IPrintable
    {
        string PrintTreasury(IDatabase db);
        string PrintBuildings(IDatabase db);
        string PrintUnits(IDatabase db);
    }
}
