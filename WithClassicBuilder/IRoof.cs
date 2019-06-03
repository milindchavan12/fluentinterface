namespace FluentInterface
{
    public interface IRoof
    {
        int Height { get; set; }

        int ReturnHeight();

        void SetHeight(int Height);
    }
}