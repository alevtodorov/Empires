using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires.Other.Print
{
    public class FilePrintAllInfo : PrintAllInfo
    {
        private StreamWriter writer;

        public FilePrintAllInfo() : base()
        {
            writer = new StreamWriter("empire.txt", true);
        }

        public override void Print(IDatabase db)
        {
            writer.WriteLine(PrintTreasury(db));
            writer.WriteLine(PrintBuildings(db));
            writer.WriteLine(PrintUnits(db));
            writer.Close();
        }
    }
}
