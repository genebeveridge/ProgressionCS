using System.Collections;
using System.ComponentModel;

namespace Progression
{
    public class ProgressionApp
    {

        static void Main()
        {
            Console.Write("Program started./n");
            
            Data _data = new Data();
            
            Menus.MainMenu(_data);

            Console.Write("Program finished.");
        } 
    }

    internal class Data
    {
        public readonly Elements ElementsData;
        public readonly Strategies StrategiesData;
        public readonly Intervals IntervalsData;
        public readonly Sports SportsData;
        public readonly Plans PlansData;
        public readonly Athletes AthletesData;
        public readonly Sessions SessionsData;

        public Data()
        {
            ElementsData = new Elements();
            StrategiesData = new Strategies();
            IntervalsData = new Intervals();
            SportsData = new Sports();
            PlansData = new Plans();
            AthletesData = new Athletes();
            SessionsData = new Sessions();
        }
    }
}
