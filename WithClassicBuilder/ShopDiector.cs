namespace FluentInterface
{
    public class ShopDirector
    {
        private IShopBuilder shopbuilder;

        public ShopDirector(IShopBuilder shopbuilder)
        {
            this.shopbuilder = shopbuilder;
        }

        public void buildShop()
        {
            shopbuilder.BuildFloor();
            shopbuilder.BuildRoof();
            shopbuilder.BuildWall();
        }

        public Shop getShop()
        {
            return shopbuilder.getShop();
        }
    }
}