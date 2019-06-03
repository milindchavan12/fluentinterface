namespace FluentInterface
{
    class BigShopTesco : IShopBuilder
    {
        private Shop shop;

        public BigShopTesco()
        {
            this.shop = new Shop();
        }

        public void BuildFloor()
        {
            IFloor floor = new Floor();

            floor.SetLenght(20);
            floor.SetNumberOfTiles(100);
            floor.SetTypeGreatnessTiles("Big");

            shop.SetFloor(floor);
        }

        public void BuildRoof()
        {
            IRoof roof = new Roof();

            roof.SetHeight(10);

            shop.SetRoof(roof);
        }

        public void BuildWall()
        {
            IWall wall = new Wall();

            wall.SetThickness(1);
            wall.SetColor("Green");

            shop.SetWall(wall);
        }

        public Shop getShop()
        {
            return shop;
        }
    }
}