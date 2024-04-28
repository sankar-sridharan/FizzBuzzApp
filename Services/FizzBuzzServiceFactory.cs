namespace FizzBuzzApp.Services
{
    public class FizzBuzzServiceFactory
    {
        public FizzBuzzService CreateFizzBuzzService()
        {
             return new FizzBuzzService();
        }
    }
}
