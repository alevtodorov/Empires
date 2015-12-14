using System;

namespace Empires.Interfaces
{
    public interface IEngine
    {
        void Run();
        event EventHandler OnTurn;
    }
}
