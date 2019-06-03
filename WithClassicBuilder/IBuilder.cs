namespace FluentInterface
{
    public interface IShopBuilder
    {
        void BuildFloor();
        void BuildRoof();
        void BuildWall();
        Shop getShop();
    }
}