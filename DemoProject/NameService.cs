namespace DemoProject
{
    public class NameService
    {
        private string[] Names { get; }
            = new[]
        {
            "John",
            "Jim",
            "Maria",
            "Yana"
        };
        public SomeOtherService SomeOtherService { get; }

        private Random random = new Random();
        public NameService(SomeOtherService someOtherService) 
        {
            SomeOtherService = someOtherService;
        }
        public string GetRandomName()
        {
            return Names[random.Next(Names.Length)];
        }
    }
}
