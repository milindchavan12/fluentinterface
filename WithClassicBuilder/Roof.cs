namespace FluentInterface
{
    public class Roof : IRoof
    {
        public int Height { get; set; }

        public int ReturnHeight()
        {
            return Height;
        }

        public void SetHeight(int Height)
        {
            this.Height = Height;
        }
    }
}