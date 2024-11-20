using static Progression.GeneralFuncs;

namespace Progression
{
    class Strategy
    {
        private string _name;

        Strategy(string name)
        {
            _name = name;
        }
    }

    class Strategies
    {
        private List<Strategy> _strategies = new List<Strategy>();

        internal void ListStrategies()
        {
            NotImplemented();
        }
        internal void DisplayStrategy()
        {
            NotImplemented();
        }
        internal void EditStrategy()
        {
            NotImplemented();
        }
        internal void AddStrategy()
        {
            NotImplemented();
        }
        internal void DeleteStrategy()
        {
            NotImplemented();
        }
    }
}