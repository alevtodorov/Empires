using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires
{
    public static class Validator
    {
        public static void Validation<T>(T value, string type) where T : IComparable<T>
        {
            if(value.CompareTo(default(T)) < 0)
            {
                throw new ArgumentOutOfRangeException("The {0} cannot be negative", type);
            }
        }
    }
}
