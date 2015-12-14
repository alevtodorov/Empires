using Empires.Interfaces;

namespace Empires.Abstract
{
    public abstract class Unit : IUnit
    {
        private int health;
        private int damage;

        protected Unit(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public int Health
        {
            get { return health; }
            set
            {
                Validator.Validation(value, "Health");
                health = value;
            }
        }
        public int Damage
        {
            get { return damage; }
            set
            {
                Validator.Validation(value, "Damage");
                damage = value;
            }
        }

        public void Attack(IUnit other)
        {
            other.Health -= Damage;
        }

        public void ReceiveDamage(IUnit other)
        {
            Health -= other.Damage;
        }
    }
}
