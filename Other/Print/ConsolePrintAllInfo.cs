using Empires.Interfaces;
using System;

namespace Empires.Other.Print
{
    class ConsolePrintAllInfo : PrintAllInfo
    {
        public ConsolePrintAllInfo() : base()
        {}

        public override void Print(IDatabase db)
        {
            Console.WriteLine(PrintTreasury(db));
            Console.WriteLine(PrintBuildings(db));
            Console.WriteLine(PrintUnits(db));
        }
    }
}
