namespace Empires.Models.Resources
{
    public class Gold : Resource
    {
        private const int GoldQuantity = 5;

        public Gold() : base(ResourceType.Gold, GoldQuantity)
        {}
    }
}
