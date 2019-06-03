namespace FluentInterface
{
public class Wall : IWall
    {
        public int Thickness { get; set; }
        public string Color { get; set; }
 
        public int ReturnThickness()
        {
            return Thickness;
        }
 
        public string ReturnColor()
        {
            return Color;
        }
 
        public void SetThickness(int Thickness)
        {
            this.Thickness = Thickness;
        }
 
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
    }
}