using ActiveObjectPattern;
using System;
using System.Linq;

namespace ConcurrencyPatterns.POCS
{
    internal class PocActiveObject
    {
        public PocActiveObject(){
            
        }

        public void StartActiveObjectTest() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                Exercise about Active Object Concurrency Pattern              |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            var print = new PrinterTask();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            for (int i=0;i < 55000 ; i++){
                print.Print(new string(Enumerable.Repeat(chars, 1).Select(s => s[new Random().Next(s.Length)]).ToArray()),
                            (ConsoleColor)new Random().Next(0, 16));
            }
            
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            Console.ResetColor();

        }
    }
}
