namespace Empires.Interfaces
{
    public interface IUnit
    {
        int Health { get; set; }
        int Damage { get; set; }
        void Attack(IUnit other);
        void ReceiveDamage(IUnit other);
    }
}
