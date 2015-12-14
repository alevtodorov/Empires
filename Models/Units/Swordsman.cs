using Empires.Abstract;

namespace Empires.Models.Units
{
    public class Swordsman : Unit
    {
        private const int DefaultDamage = 13;

        public Swordsman() : base(40, DefaultDamage)
        {}
    }
}
