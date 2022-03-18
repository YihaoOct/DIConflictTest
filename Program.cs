using Autofac;
using DIConflictTest.GoodMorning;
using DIConflictTest.GoodNight;

namespace DIConflictTest
{
    internal class Program
    {
        private static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<GoodMorning.Module>();
            builder.RegisterModule<GoodNight.Module>();
            var container = builder.Build();

            var goodMorningService = container.Resolve<GoodMorningService>();
            var goodNightService = container.Resolve<GoodNightService>();
            
            goodMorningService.SayGoodMorning();
            goodNightService.SayGoodNight();
            
            // Expected:
            //   Sun says good morning!
            //   Moon says good night!
            //
            // Got:
            //   Moon says good morning!
            //   Moon says good night!
        }
    }
}
