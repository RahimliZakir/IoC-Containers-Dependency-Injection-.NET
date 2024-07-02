
namespace Project.WebUI.AppCode
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int Random { get; set; }
        public Guid Guid { get; set; }

        public RandomNumberGenerator()
        {
            this.Random = new Random().Next(25);
            this.Guid = Guid.NewGuid();
        }
    }
}
