using ActiveObjectPattern;
using ConcurrencyPatterns.POCS;
using System;
using System.Linq;

namespace ConcurrencyPatterns {
    class Program  {
        static void Main(string[] args) {
            DrawMainScreen();
          
            
        }

        public static void DrawMainScreen() {

            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                       Exercises from Design Patterns                         |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("| Options                                                                      |");
            Console.WriteLine("|      1 - ActiveObject Concurrency Pattern                                    |");            
            Console.WriteLine("|      2 - MonitorObject Concurrency Pattern                                   |");
            Console.WriteLine("|      3 - Concurrency Pattern                                                 |");
            Console.WriteLine("|      4 - Decorator Pattern                                                   |");
            Console.WriteLine("|      5 - Facade Pattern                                                      |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("| Choose one option to continue...                                             |");
            Console.WriteLine("|******************************************************************************|");

            var option = Console.ReadLine();

            ExecuteTheOption(option);
        }

        public static void ExecuteTheOption(string option)
        {
            if (!String.IsNullOrWhiteSpace(option))
            {
                int value = Int32.Parse(option);

                switch (value)
                {
                    case 1:
                        var pocActiveObject = new PocActiveObject();
                        pocActiveObject.StartActiveObjectTest();

                        DrawMainScreen();
                        break;

                    case 2:

                        var pocMonitorObject = new PocMonitorObject();
                        pocMonitorObject.StartMonitorObjectTest();

                        DrawMainScreen();
                        break;

                    case 3:                        

                        DrawMainScreen();
                        break;

                    case 4:
                        
                        DrawMainScreen();
                        break;

                    case 5:                        

                        DrawMainScreen();
                        break;

                    default:
                        DrawMainScreen();
                        break;
                }
            }
            else
            {
                DrawMainScreen();
            }
        }

    }
}
