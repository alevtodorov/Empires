using System.Linq;
using Empires.Interfaces;
using System;
using System.Text;

namespace Empires.Other
{
    public abstract class PrintAllInfo : IPrintable
    {
        private StringBuilder sb { get; set; }
        private string str = "";

        protected PrintAllInfo()
        {
            sb = new StringBuilder();
        }

        public abstract void Print(IDatabase db);

        public virtual string PrintTreasury(IDatabase db)
        {
            int allGolds = 0;
            int allSteels = 0;

            foreach (IBuilding b in db.AllBuildings)
            {
                foreach (IResource<ResourceType> r in b.ProducedResources)
                {
                    if(r.Type == ResourceType.Gold)
                    {
                        allGolds += r.Quantity;
                    }
                    else
                    {
                        allSteels += r.Quantity;
                    }
                }
            }
            str += 
                "Treasury:" + Environment.NewLine + 
                string.Format("--Gold: {0}{1}", allGolds, Environment.NewLine) +
                string.Format("--Steel: {0}", allSteels);
            sb.Insert(0, str);
            return sb.ToString();
        }

        public virtual string PrintBuildings(IDatabase db)
        {
            int turnsAlive = 0;
            int turnsToUnit = 0;
            int turnsToResorce = 0;
            sb.Clear();
            str = "Buildings:" + Environment.NewLine;
            foreach (IBuilding b in db.AllBuildings)
            {
                turnsAlive = b.TurnsAlive - 1;
                turnsToUnit = b.TurnsForUnits;
                turnsToResorce = b.TurnsForResources;
                str += string.Format("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5}){6}",
                                b.GetType().Name, 
                                turnsAlive, 
                                turnsToUnit, 
                                b.GetType().Name == "Archery" ? "Archer" : "Swordsman",
                                turnsToResorce,
                                b.GetType().Name == "Archery" ? "Gold" : "Steel",
                                Environment.NewLine);
            }
            str = str.Trim();
            sb.Insert(0, str);
            return sb.ToString();
        }

        public virtual string PrintUnits(IDatabase db)
        {
            int archers = 0;
            int swordsman = 0;
            bool IsArcherFirst = false;
            sb.Clear();
            str = "Units:" + Environment.NewLine;

            foreach (IBuilding b in db.AllBuildings)
            {
                foreach (IUnit unit in b.ProducedUnits)
                {
                    if(unit.GetType().Name == "Archer")
                    {
                        archers++;
                    }
                    else
                    {
                        swordsman++;
                    }
                }
            }

            var firstBuilding = db.AllBuildings.FirstOrDefault();
            var u = firstBuilding.GetType().Name;
            if(u == "Archery")
            {
                IsArcherFirst = true;
            }

            if(archers > 0 && IsArcherFirst)
            {
                str += string.Format("--Archer: {0}{1}", archers, Environment.NewLine);
                if(swordsman > 0)
                {
                    str += string.Format("--Swordsman: {0}{1}", swordsman, Environment.NewLine);
                }
            }
            if(swordsman > 0 && IsArcherFirst == false)
            {
                str += string.Format("--Swordsman: {0}{1}", swordsman, Environment.NewLine);
                if(archers > 0)
                {
                    str += string.Format("--Archer: {0}{1}", archers, Environment.NewLine);
                }
            }
            if(archers == 0 && swordsman == 0)
            {
                str += "N/A" + Environment.NewLine;
            }
            str = str.Trim();
            sb.Insert(0, str);
            return sb.ToString();
        }
    }
}