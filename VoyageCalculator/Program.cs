using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //app flow
            //
            DisplayWelcomeScreen();
            DisplayMainMenu();
            DisplayClosingScreen();
        }
        #region Menu methods
        static void DisplayMainMenu()
        {
            bool quitApplication = false;
            string menuChoice;
            do
            {
                //
                //menu
                //
                DisplayScreenHeader("\t\t\tMain Menu");
                //
                //get user menu method choice
                //
                Console.WriteLine("\t\t\ta) Anchor Scope Calculator");
                Console.WriteLine("\t\t\tb) Time Arrival Calculator");
                Console.WriteLine("\t\t\tc) Travel Distance Calculator");
                Console.WriteLine("\t\t\td) Knot Speed Calculator");
                Console.WriteLine("\t\t\tq) Quit");
                Console.Write("\t\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "a":
                        DisplayAnchorScope();
                        break;

                    case "b":
                        DisplayTimeArrivalCaluclator();
                        break;

                    case "c":
                        DisplayTravelDistanceCalculator();
                        break;

                    case "d":
                        DisplayKnotSpeedCalculator();
                        break;

                    case "q":
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }
        static void DisplayKnotSpeedCalculator()
        {
            //
            //variables
            //
            double nauticalMiles;
            double estimatedTime;
            bool validResponse = false;
            string userResponse;
            double knots;

            //************************************************
            //knot speed title screen
            //
            DisplayScreenHeader("\t\t\tKnot Speed Calculator");
            Console.WriteLine("\tCalculate Knot Speed");
            DisplayContinuePrompt();

            //**********************************************************
            //get speed screen
            //
            do
            {
                DisplayScreenHeader("\t\t\tKnot Speed");

                //
                //user input
                //
                Console.WriteLine("\tEnter distance till destintaion");
                Console.WriteLine();
                Console.Write("\tNautical Miles:");
                userResponse = Console.ReadLine();

                //
                //validate
                //
                if (double.TryParse(userResponse, out nauticalMiles))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\tResults");
                    Console.WriteLine();
                    Console.WriteLine(
                    "Nautical Miles".PadRight(5)
                        );
                    Console.WriteLine(
                         "--------------".PadRight(5)
                        );
                    Console.WriteLine($"{nauticalMiles}".PadRight(5));
                    DisplayContinuePrompt();
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);
            validResponse = false;

            //*************************************************
            //travel time screen
            //
            DisplayScreenHeader("\t\t\tArrival Time");
            Console.WriteLine("\tEnter time planed to travel");

            DisplayContinuePrompt();

            //***************************************************
            //get time screen
            //
            do
            {
                DisplayScreenHeader("\t\t\tNautical Distance");

                //
                //user input
                //
                Console.WriteLine("\tEnter Time to Travel");
                Console.WriteLine();
                Console.Write("\tHours:");
                userResponse = Console.ReadLine();

                //
                //validate
                //
                if (double.TryParse(userResponse, out estimatedTime))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\tResults");
                    Console.WriteLine();
                    Console.WriteLine(
                   "Nautical Miles".PadRight(5) +
                   "Travel Time".PadLeft(15)
                       );
                    Console.WriteLine(
                         "--------------".PadRight(5) +
                         "-----------".PadLeft(15)
                        );
                    Console.WriteLine($"{nauticalMiles}".PadRight(5) +
                        $"{estimatedTime} hours".PadLeft(22)
                        );
                    DisplayContinuePrompt();
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);

            //
            //calculation 
            //
            knots = nauticalMiles / estimatedTime;

            //*************************************************
            //calculation title screen
            //
            DisplayScreenHeader("\t\t\tArrival Time");
            Console.WriteLine("\tCalculate Arrival Time");
            DisplayContinuePrompt();

            //**************************************************
            //distance result screen
            //
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            DisplayScreenHeader("\t\tNautical Distance from Destination");
            Console.WriteLine();
            Console.WriteLine(
                  "Nautical Miles".PadRight(5) +
                  "Travel Time".PadLeft(15) +
                  "Knots".PadLeft(10)
                      );
            Console.WriteLine(
                 "--------------".PadRight(5) +
                 "-----------".PadLeft(15) +
                 "-----".PadLeft(10)
                );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nauticalMiles}".ToString().PadRight(5) +
                $"{estimatedTime} hours".ToString().PadLeft(22) +
                $"{knots:N2}".ToString().PadLeft(11)
                );
            DisplayContinuePrompt();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
        }

        static void DisplayTravelDistanceCalculator()
        {
            //
            //variables
            //
            double nauticalMiles;
            double estimatedTime;
            bool validResponse = false;
            string userResponse;
            double knots;

            //***********************************************************************
            //distance title screen
            //
            DisplayScreenHeader("\t\tNautical Distance Calculator");
            Console.WriteLine("\tEnter esitmated nautical mile distance");
            DisplayContinuePrompt();

            //*************************************************
            //get speed screen
            //
            do
            {
                DisplayScreenHeader("\t\tNautical Distance");

                //
                //user input
                //
                Console.WriteLine();
                Console.WriteLine("\tEnter knot speed");
                Console.WriteLine();
                Console.Write("\tKnot Speed:");
                userResponse = Console.ReadLine();

                //
                //validate
                //
                if (double.TryParse(userResponse, out knots))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\tResults");
                    Console.WriteLine();
                    Console.WriteLine(
                    "Knots".PadRight(5)
                        );
                    Console.WriteLine(
                         "-----".PadRight(5)
                        );
                    Console.WriteLine($"{knots}".PadRight(5));
                    DisplayContinuePrompt();
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);
            validResponse = false;

            //********************************************
            //time arrival screen
            //
            DisplayScreenHeader("\t\t\t\tArrival Time");
            Console.WriteLine("\tEnter Planed Time to Travel");
            DisplayContinuePrompt();

            do
            {
                DisplayScreenHeader("\t\t\t\tNautical Distance");

                //
                //user input
                //
                Console.WriteLine("\tEnter travel time");
                Console.WriteLine();
                Console.Write("\tHours:");
                userResponse = Console.ReadLine();

                //
                //validate
                //
                if (double.TryParse(userResponse, out estimatedTime))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\tResults");
                    Console.WriteLine();
                    Console.WriteLine(
                   "Knots".PadRight(5) +
                   "Travel Time".PadLeft(15)
                       );
                    Console.WriteLine(
                         "-----".PadRight(5) +
                         "-----------".PadLeft(15)
                        );
                    Console.WriteLine($"{knots}".PadRight(5) +
                        $"{estimatedTime} hours".PadLeft(12)
                        );
                    DisplayContinuePrompt();
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);
            //
            //calculation
            //
            nauticalMiles = knots * estimatedTime;

            //**********************************************
            //calculations screen
            //
            DisplayScreenHeader("\t\t\t\tArrival Time");
            Console.WriteLine("\tCalculate Arrival Time");
            DisplayContinuePrompt();

            //**********************************************
            //results screen
            //
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tNautical Distance from Destination");
            Console.WriteLine();
            Console.WriteLine(
                  "Knots".PadRight(5) +
                  "Travel Time".PadLeft(15) +
                  "Nautical Miles".PadLeft(20)
                      );
            Console.WriteLine(
                 "-----".PadRight(5) +
                 "-----------".PadLeft(15) +
                 "--------------".PadLeft(20)
                );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{knots}".ToString().PadRight(5) +
                $"{estimatedTime} hours".ToString().PadLeft(12) +
                $"{nauticalMiles}".ToString().PadLeft(12)
                );

            DisplayContinuePrompt();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        static void DisplayTimeArrivalCaluclator()
        {
            //
            //varibles
            //
            double nauticalMiles;
            double estimatedTime;
            bool validResponse = false;
            string userResponse;
            double knots;

            //***********************************************
            //arrival time title screen
            //
            DisplayScreenHeader("\t\tArrival Time Calculator");
            Console.WriteLine("\tEnter esitmated nautical mile distance");
            DisplayContinuePrompt();

            //***********************************************
            //get miles screen
            //
            do
            {
                DisplayScreenHeader("\t\t\t\tArrival Time");

                //
                //user inut
                //
                Console.WriteLine("\tEnter Distance to destination");
                Console.WriteLine();
                Console.Write("\tNautical miles:");
                userResponse = Console.ReadLine();

                //
                //validate
                //
                if (double.TryParse(userResponse, out nauticalMiles))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\tResults");
                    Console.WriteLine();
                    Console.WriteLine(
                    "Nautical miles".PadRight(5)
                    );
                    Console.WriteLine(
                    "---------------".PadRight(5)
                    );
                    Console.WriteLine(
                       $"{nauticalMiles}".ToString().PadRight(5)
                       );
                    DisplayContinuePrompt();
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);
            validResponse = false;

            //****************************************************
            //enter speed title screen
            //
            DisplayScreenHeader("\t\t\tArrival Time");
            Console.WriteLine("\tEnter estimated speed");
            DisplayContinuePrompt();

            //***************************************************
            //get knots title
            //
            do
            {
                DisplayScreenHeader("Arrival Time");

                //
                //user input
                //
                Console.WriteLine("\tEnter Speed");
                Console.WriteLine();
                Console.Write("\tKnots:");
                userResponse = Console.ReadLine();

                //*****************************************
                //validate
                //
                if (double.TryParse(userResponse, out knots))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\tResults");
                    Console.WriteLine();
                    Console.WriteLine(
                    "Nautical miles".PadRight(5) +
                    "Knots".PadLeft(10)
                        );
                    Console.WriteLine(
                    "--------------".PadRight(5) +
                    "-----".PadLeft(10)
                        );
                    Console.WriteLine(
                        $"{nauticalMiles}".ToString().PadRight(5) +
                        $"{knots}".ToString().PadLeft(18)
                        );
                    DisplayContinuePrompt();
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);
            //
            //calculation
            //
            estimatedTime = nauticalMiles / knots;

            //*************************************************
            //calculate title
            //
            DisplayScreenHeader("\t\t\t\tArrival Time");
            Console.WriteLine("\tCalculate Arrival Time");
            DisplayContinuePrompt();

            //*************************************************
            //results screen
            //
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\tResults");
            Console.WriteLine();
            Console.WriteLine(
                "Nautical miles".PadRight(5) +
                "Knots".PadLeft(10) +
                "Arrival Time".PadLeft(25)
                );

            Console.WriteLine(
               "--------------".PadRight(5) +
               "-----".PadLeft(10) +
               "------------".PadLeft(25)
               );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
             $"{nauticalMiles}".ToString().PadRight(5) +
             $"{knots}".ToString().PadLeft(18) +
             $"{estimatedTime:F2} hours".ToString().PadLeft(26)
            );
            DisplayContinuePrompt();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        static void DisplayAnchorScope()
        {
            int waterDepth;

            //
            //Title screen
            //
            DisplayScreenHeader("\t\t\tAnchor Scope Calculator");
            DisplayContinuePrompt();
            DisplayScreenHeader("\t\t\tINSTRUCTIONS");
            Console.WriteLine("\t\tCalculate The Correct Rode Length to Let Out.");
            Console.WriteLine();
            Console.WriteLine("\t\tType in the depth number and wind condtions for the correct rode length to let out.");
            DisplayContinuePrompt();

            //
            //app flow
            //
            waterDepth = DisplayGetWaterDepth();
            int bowHeight = DisplayGetBowHeight(waterDepth);
            DisplayGetConditions(waterDepth, bowHeight);

        }
        static void DisplayGetConditions(int waterDepth, int bowHeight)
        {
            //
            //varibles
            //
            bool validRepsonse = false;
            string windSpeed;
            string userResponse;
            int depthTotal;
            int strongWindsLength;
            int overNightLength;
            int num;
            int calmLength;
            depthTotal = waterDepth + bowHeight;
            strongWindsLength = depthTotal * 12;
            overNightLength = depthTotal * 8;
            calmLength = depthTotal * 6;

            //***********************************************
            //wind conditions screen
            //
            do
            {
                DisplayScreenHeader("Wind Conditions");
                Console.WriteLine();
                Console.Write("\tWhat are the wind conditions [strong, calm]");
                windSpeed = Console.ReadLine();

                //
                //validate
                //
                if (!int.TryParse(windSpeed, out num))
                {
                    if (windSpeed == "strong")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\tResults");
                        Console.WriteLine();
                        Console.WriteLine(
                            "Wind".PadRight(5) +
                            "Ratio".PadLeft(10) +
                            "WaterDepth".PadLeft(15) +
                            "BowHeight".PadLeft(15) +
                            "TotalHeight".PadLeft(15) +
                            "RodeLength".PadLeft(15)
                            );

                        Console.WriteLine(
                           "----".PadRight(5) +
                           "-----".PadLeft(10) +
                           "----------".PadLeft(15) +
                           "---------".PadLeft(15) +
                           "-----------".PadLeft(15) +
                           "----------".PadLeft(15)
                           );

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(
                         windSpeed.PadRight(5) +
                        "12:1".ToString().PadLeft(10) +
                        waterDepth.ToString().PadLeft(10) +
                        bowHeight.ToString().PadLeft(15) +
                        depthTotal.ToString().PadLeft(15) +
                        $"{strongWindsLength} feet".ToString().PadLeft(17)
                        );
                        DisplayContinuePrompt();
                        validRepsonse = true;
                    }
                    else if (windSpeed == "calm")
                    {
                        do
                        {
                            validRepsonse = false;
                            Console.Clear();
                            Console.Write("Are you staying over night? [yes, no]");
                            userResponse = Console.ReadLine();

                            if (userResponse == "yes")
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("\t\t\t\t\tResults");
                                Console.WriteLine();
                                Console.WriteLine(
                                    "Wind".PadRight(5) +
                                    "Ratio".PadLeft(10) +
                                    "WaterDepth".PadLeft(15) +
                                    "BowHeight".PadLeft(15) +
                                    "TotalHeight".PadLeft(15) +
                                    "RodeLength".PadLeft(15)
                                    );

                                Console.WriteLine(
                                   "----".PadRight(5) +
                                   "-----".PadLeft(10) +
                                   "----------".PadLeft(15) +
                                   "---------".PadLeft(15) +
                                   "-----------".PadLeft(15) +
                                   "----------".PadLeft(15)
                                   );

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(
                                 windSpeed.PadRight(5) +
                                "8:1".ToString().PadLeft(10) +
                                waterDepth.ToString().PadLeft(10) +
                                bowHeight.ToString().PadLeft(15) +
                                depthTotal.ToString().PadLeft(15) +
                                $"{overNightLength} feet".ToString().PadLeft(17)
                                );
                                DisplayContinuePrompt();
                                validRepsonse = true;
                            }
                            else if (userResponse == "no")
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("\t\t\t\t\tResults");
                                Console.WriteLine();
                                Console.WriteLine(
                                    "Wind".PadRight(5) +
                                    "Ratio".PadLeft(10) +
                                    "WaterDepth".PadLeft(15) +
                                    "BowHeight".PadLeft(15) +
                                    "TotalHeight".PadLeft(15) +
                                    "RodeLength".PadLeft(15)
                                    );

                                Console.WriteLine(
                                   "----".PadRight(5) +
                                   "-----".PadLeft(10) +
                                   "----------".PadLeft(15) +
                                   "---------".PadLeft(15) +
                                   "-----------".PadLeft(15) +
                                   "----------".PadLeft(15)
                                   );
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(
                                 windSpeed.PadRight(5) +
                                "6:1".ToString().PadLeft(10) +
                                waterDepth.ToString().PadLeft(10) +
                                bowHeight.ToString().PadLeft(15) +
                                depthTotal.ToString().PadLeft(15) +
                                $"{calmLength} feet".ToString().PadLeft(17)
                                );

                                DisplayContinuePrompt();
                                validRepsonse = true;
                            }
                            else
                            {
                                Console.WriteLine("Error");
                                DisplayContinuePrompt();
                            }
                        } while (!validRepsonse);

                    }
                }
                else
                {

                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();

                }

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                break;

            } while (!validRepsonse);

        }
        static int DisplayGetBowHeight(int waterDepth)
        {
            string userResponse;
            bool validResponse = false;
            int bowHeight;

            do
            {
                DisplayScreenHeader("\t\t\t\tBow Height");
                Console.WriteLine();

                Console.WriteLine("\tWhat is the bow height?");
                Console.WriteLine();
                Console.Write("\tFeet:");
                userResponse = Console.ReadLine();
                if (int.TryParse(userResponse, out bowHeight))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Water depth = {waterDepth} feet");
                    Console.WriteLine($"Bow Height  = {bowHeight}  feet");
                    int depthTotal = waterDepth + bowHeight;
                    Console.WriteLine($"Total Depth = {depthTotal} feet");

                    validResponse = true;

                    DisplayContinuePrompt();

                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();

                }

            } while (!validResponse);

            return bowHeight;
        }
        static int DisplayGetWaterDepth()
        {
            bool validResponse = false;
            int waterDepth;

            DisplayScreenHeader("\t\t\t\tWater Depth");
            Console.WriteLine();
            Console.WriteLine("\tUse depth finder and enter water depth");
            DisplayContinuePrompt();

            do
            {

                DisplayScreenHeader("\t\t\t\tWater Depth");

                string userResponse;
                Console.WriteLine("\tEnter water depth");
                Console.WriteLine();
                Console.Write("\tFeet:");
                userResponse = Console.ReadLine();
                if (int.TryParse(userResponse, out waterDepth))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Water depth = {userResponse} feet");

                    validResponse = true;

                    DisplayContinuePrompt();

                }
                else
                {
                    Console.WriteLine("Error try again");
                    DisplayContinuePrompt();

                }

            } while (!validResponse);

            return waterDepth;

        }
        #endregion

        #region Helper Methods

        static void DisplayWelcomeScreen()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tVoyage Applicaiton");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using my Voyage Application!");
            Console.WriteLine();


            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.Write("\tPress any key to continue.");
            Console.ReadKey();
            Console.CursorVisible = true;
        }

        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
