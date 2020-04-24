namespace HelloAutofac
{
    public class DataProvider : IDataProvider
    {
        public string Get()
        {
            return "Test data IoC container Autofac!";
        }
    }
}
