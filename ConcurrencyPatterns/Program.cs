using ActiveObjectPattern;
using System;
using System.Linq;

namespace ConcurrencyPatterns {
    class Program  {
        static void Main(string[] args) {

            var print = new PrinterTask();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                        
            for (; ; ){
                print.Print(new string(Enumerable.Repeat(chars, 1).Select(s => s[new Random().Next(s.Length)]).ToArray()), 
                            (ConsoleColor) new Random().Next(0,16));                
            }
            
        }
    }
}
