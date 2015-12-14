namespace Empires.Models.Resources
{
    public class Steel : Resource
    {
        private const int SteelQuantity = 10;

        public Steel() : base(ResourceType.Steel, SteelQuantity)
        {}
    }
}
