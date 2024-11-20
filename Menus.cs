namespace Progression
{
    //class Menu
    //{
    //     readonly List<string> items = [];

    //     Menu(List<string> newItems)
    //     {
    //         items.AddRange(newItems);
    //     }
    // }

    static class Menus
    {
        static readonly string[] MainMenuItems = [
                "Elements", "Strategies", "Intervals", "Sports", "Plans", "Athletes", "Sessions",
            "Program", "Form tracker", "Program summary", "Program details"
                ];
        static readonly string[] ElementsMenuItems = [
                "List elements", "Display element", "Edit element", "Add element", "Delete element"
                ];

        static readonly string[] StrategiesMenuItems = [
                "List Strategies", "Display Strategy", "Edit Strategy", "Add Strategy", "Delete Strategy"
        ];
        static readonly string[] IntervalsMenuItems = [
                "List intervals", "Display interval", "Edit interval", "Add interval", "Delete interval"
        ];

        static readonly string[] SportsMenuItems = [
                "List sports", "Display sport", "Edit sport", "Add sport", "Delete sport"
        ];

        static readonly string[] PlansMenuItems = [
                "List plans", "Display plan", "Edit plan", "Add plan", "Delete plan"
        ];

        static readonly string[] AthletesMenuItems = [
                "List athletes", "Display athlete", "Edit athlete", "Add athlete", "Delete athlete"
        ];

        static readonly string[] SessionsMenuItems = [
                "List sessions", "Display session", "Edit session", "Add session", "Delete session"
        ];

        static readonly string[] ProgramPlannerMenuItems = [
            "PLAN: Intervals Counter",
            "PLAN: Primary Element Duration",
            "PLAN: Secondary Element Duration",
            "PLAN: Tertiary Element Duration",
            "PLAN: Elements Combined Load",
            "PLAN: Sessions WU Duration",
            "PLAN: Sessions WU Load",
            "PLAN: Sessions WD Duration",
            "PLAN: Sessions WD Load",
            "PLAN: Session Recoveries Duration",
            "PLAN: Session Recoveries Load",
            "EVALUATION: Total Duration",
            "EVALUATION: Training Load",
            "FINAL: Adjusted Session Durations",
            "FINAL: Primary Element Duration",
            "FINAL: Secondary Element Duration",
            "FINAL: Tertiary Element Duration",
            "FINAL: Total Effort Duration",
            "FINAL: Sessions WU Duration",
            "FINAL: Sessions WD Duration",
            "FINAL: Total Session Durations",
            "FINAL: Total Session Load",
            "DISPLAY: Intervals Name",
            "DISPLAY: Intervals Braekdown",
            "DISPLAY: Nutrition Summary",
            "DISPLAY: Nutrition Description",
            "DISPLAY: Raw Summary Abreviation",
            "DISPLAY: Summary Abreviation",
        ];

        private static string DisplayMenuGetResponse(string menuName, string[] menuItems)
        {
            Console.Clear();
            Console.WriteLine($"{menuName} Menu:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i]}");
            }
            Console.WriteLine("B. Back");
            Console.Write("Please select an option: ");

            return Console.ReadLine();
        }

        public static void MainMenu(Data data)
        {
            bool exit = false;
            while (!exit)
            {
                string response = DisplayMenuGetResponse("Main", MainMenuItems);

                switch (response)
                {
                    case "1":
                        ElementsMenu(data.ElementsData);
                        break;
                    case "2":
                        StrategiesMenu(data.StrategiesData);
                        break;
                    case "3":
                        IntervalsMenu(data.IntervalsData);
                        break;
                    case "4":
                        SportsMenu(data.SportsData);
                        break;
                    case "5":
                        PlansMenu(data.PlansData);
                        break;
                    case "6":
                        AthletesMenu(data.AthletesData);
                        break;
                    case "7":
                        SessionsMenu(data.SessionsData);
                        break;
                    case "8":
                        ProgramPlannerMenu();
                        break;
                    case "9":
                        FormTrackerCalcs.DisplayFormTracker();
                        break;
                    case "10":
                        ProgramSummaryCalcs.DisplayProgramSummary();
                        break;
                    case "11":
                        ProgramDetailsCalcs.DisplayProgramDetails();
                        break;
                    case "B":
                    case "b":
                        exit = true; // Exit the program
                        Console.WriteLine("Quiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        static void ElementsMenu(Elements elementsData)
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Elements", ElementsMenuItems);

                switch (response)
                {
                    case "1":
                        elementsData.ListElements();
                        break;
                    case "2":
                        elementsData.DisplayElement();
                        break;
                    case "3":
                        elementsData.EditElement();
                        break;
                    case "4":
                        elementsData.AddElement();
                        break;
                    case "5":
                        elementsData.DeleteElement();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void StrategiesMenu(Strategies strategiesData)
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Strategies", StrategiesMenuItems);

                switch (response)
                {
                    case "1":
                        strategiesData.ListStrategies();
                        break;
                    case "2":
                        strategiesData.DisplayStrategy();
                        break;
                    case "3":
                        strategiesData.EditStrategy();
                        break;
                    case "4":
                        strategiesData.AddStrategy();
                        break;
                    case "5":
                        strategiesData.DeleteStrategy();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        static void IntervalsMenu(Intervals intervalsData)
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Intervals", IntervalsMenuItems);

                switch (response)
                {
                    case "1":
                        intervalsData.ListIntervals();
                        break;
                    case "2":
                        intervalsData.DisplayInterval();
                        break;
                    case "3":
                        intervalsData.EditInterval();
                        break;
                    case "4":
                        intervalsData.AddInterval();
                        break;
                    case "5":
                        intervalsData.DeleteInterval();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        static void SportsMenu(Sports sportsData)
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Sports", SportsMenuItems);

                switch (response)
                {
                    case "1":
                        sportsData.ListSports();
                        break;
                    case "2":
                        sportsData.DisplaySport();
                        break;
                    case "3":
                        sportsData.EditSport();
                        break;
                    case "4":
                        sportsData.AddSport();
                        break;
                    case "5":
                        sportsData.DeleteSport();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        static void PlansMenu(Plans plansData)
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Plans", PlansMenuItems);

                switch (response)
                {
                    case "1":
                        plansData.ListPlans();
                        break;
                    case "2":
                        plansData.DisplayPlan();
                        break;
                    case "3":
                        plansData.EditPlan();
                        break;
                    case "4":
                        plansData.AddPlan();
                        break;
                    case "5":
                        plansData.DeletePlan();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        
        static void AthletesMenu(Athletes athletesData)
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Athletes", AthletesMenuItems);

                switch (response)
                {
                    case "1":
                        athletesData.ListAthletes();
                        break;
                    case "2":
                        athletesData.DisplayAthlete();
                        break;
                    case "3":
                        athletesData.EditAthlete();
                        break;
                    case "4":
                        athletesData.AddAthlete();
                        break;
                    case "5":
                        athletesData.DeleteAthlete();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        
        static void SessionsMenu(Sessions sessionsData)
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Sessions", SessionsMenuItems);

                switch (response)
                {
                    case "1":
                        sessionsData.ListSessions();
                        break;
                    case "2":
                        sessionsData.DisplaySession();
                        break;
                    case "3":
                        sessionsData.EditSession();
                        break;
                    case "4":
                        sessionsData.AddSession();
                        break;
                    case "5":
                        sessionsData.DeleteSession();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void ProgramPlannerMenu()
        {
            bool backToMain = false;

            while (!backToMain)
            {
                string response = DisplayMenuGetResponse("Program planner", ProgramPlannerMenuItems);

                switch (response)
                {
                    case "1":
                        ProgramPlanner.DisplayProgramPlanner();
                        break;
                    case "B":
                    case "b":
                        backToMain = true; // Go back to the main menu
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}

// static void Level2Menu()
// {
//     bool backToLevel1 = false;

//     while (!backToLevel1)
//     {
//         // Display the Level 2 menu
//         Console.Clear();
//         Console.WriteLine("Level 2 Menu");
//         Console.WriteLine("1. Option A");
//         Console.WriteLine("2. Option B");
//         Console.WriteLine("3. Go Back to Level 1 Menu");
//         Console.Write("Please select an option (1-3): ");

//         string level2Choice = Console.ReadLine();

//         switch (level2Choice)
//         {
//             case "1":
//                 Console.WriteLine("You selected Option A.");
//                 break;
//             case "2":
//                 Console.WriteLine("You selected Option B.");
//                 break;
//             case "3":
//                 backToLevel1 = true; // Go back to Level 1 menu
//                 break;
//             default:
//                 Console.WriteLine("Invalid option, please try again.");
//                 break;
//         }
//     }
// }