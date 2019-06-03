using System;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            WithFluentInterface();

            WithClassicBuilder();
        }

        private static void WithFluentInterface()
        {
            Client client = new Client.Builder()
                .FirstName("Slawomir")
                .LastName("Kowalski")
                .ZipCode("34 174")
                .MyWallet(456.32)
                .HomeNumber(23)
                .Town("Cambridge")
                .Street("botolph lane")
                .build();

            Console.WriteLine("Data client: " + "\nFirstName: " + client.FirstName +
                "\nKowalski: " + client.LastName +
                "\nZip code: " + client.ZipCode +
                "\nWallet: " + client.MyWallet +
                "\nHome number: " + client.HomeNumber +
                "\nTown: " + client.Town +
                "\nStreet: " + client.Street);

            Console.ReadKey();
        }

        private static void WithClassicBuilder()
        {
            IShopBuilder shopbuilder = new BigShopTesco();
            ShopDirector shopdirector = new ShopDirector(shopbuilder);
            shopdirector.buildShop();

            Shop shop = shopdirector.getShop();
            Console.WriteLine("Shop color: " + shop.GetWall().ReturnColor() +
               "\nThickness of the shop wall: " + shop.GetWall().ReturnThickness() +
               "\nThe height of the roof: " + shop.GetRoof().ReturnHeight() +
               "\nNumber of tiles: " + shop.GetFloor().ReturnNumberOfTiles() +
               "\nThe length of the floor: " + shop.GetFloor().ReturnLenght() +
               "\nThe type of tile size: " + shop.GetFloor().ReturnTypeGreatnessTiles());

            Console.ReadKey();
        }

    }
}
