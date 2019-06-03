namespace FluentInterface
{
    public interface IWall
    {
        int Thickness { get; set; }
        string Color { get; set; }

        int ReturnThickness();
        string ReturnColor();

        void SetThickness(int Thickness);
        void SetColor(string Color);
    }
}