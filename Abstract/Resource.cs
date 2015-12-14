using Empires.Interfaces;

namespace Empires
{
    public abstract class Resource : IResource<ResourceType>
    {
        protected Resource(ResourceType type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public ResourceType Type { get; set; }
        public int Quantity { get; set; }
    }
}
