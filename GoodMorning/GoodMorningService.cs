using System;

namespace DIConflictTest.GoodMorning
{
    public class GoodMorningService
    {
        private readonly IHaveName _nameProvider;

        public GoodMorningService(IHaveName nameProvider)
        {
            _nameProvider = nameProvider;
        }

        public void SayGoodMorning()
        {
            Console.WriteLine($"{_nameProvider.Name} says good morning!");
        }
    }
}