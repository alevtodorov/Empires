using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Units
{
    using Abstract;

    public class Archer : Unit
    {
        private const int DefaultDamage = 7;

        public Archer() : base(25, DefaultDamage)
        {}
    }
}
