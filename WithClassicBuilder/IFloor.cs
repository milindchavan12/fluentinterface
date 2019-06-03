namespace FluentInterface
{
    public interface IFloor
    {
        int Lenght { get; set; }
        int NumberOfTiles { get; set; }
        string TypeGreatnessTiles { get; set; }

        int ReturnLenght();
        int ReturnNumberOfTiles();
        string ReturnTypeGreatnessTiles();

        void SetLenght(int Lenght);
        void SetNumberOfTiles(int NumberOfTiles);
        void SetTypeGreatnessTiles(string TypeGreatnessTiles);
    }
}