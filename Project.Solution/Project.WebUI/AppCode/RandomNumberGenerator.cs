namespace Project.WebUI.AppCode
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public string GenerateRandomNumber()
        {
            return new Random().Next(24).ToString();
        }
    }
}
