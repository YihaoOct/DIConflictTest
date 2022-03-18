using System;

namespace DIConflictTest.GoodNight
{
    public class GoodNightService
    {
        private readonly IHaveName _nameProvider;

        public GoodNightService(IHaveName nameProvider)
        {
            _nameProvider = nameProvider;
        }

        public void SayGoodNight()
        {
            Console.WriteLine($"{_nameProvider.Name} says good night!");
        }
    }
}