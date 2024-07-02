namespace Project.WebUI.AppCode
{
    public interface IRandomNumberGenerator
    {
        public int Random { get; set; }
        public Guid Guid { get; set; }
    }
}
