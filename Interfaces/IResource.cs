namespace Empires.Interfaces
{
    public interface IResource<T>
    {
        T Type { get; set; }
        int Quantity { get; set; }
    }
}
