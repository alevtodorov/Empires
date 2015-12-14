using Empires.Core;
using Empires.Interfaces;

namespace Empires
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase db = new Database();
            IEngine e = new Engine(db);
            e.Run();
        }
    }
}
