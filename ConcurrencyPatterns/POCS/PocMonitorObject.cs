using ConcurrencyPatterns.Resources;
using MonitorObjectPattern;
using System;
using System.Threading;

namespace ConcurrencyPatterns.POCS
{
    internal class PocMonitorObject
    {
        SharedObject sharedObject = new SharedObject();

        public PocMonitorObject(){
            
        }

        public void StartMonitorObjectTest() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                Exercise about Monitor Object Concurrency Pattern             |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            RunMonitor();

            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            Console.ResetColor();

        }

        private void RunMonitor() {         

            var monitorWriter1 = new MonitorObject(WriteC);
            var monitorWriter2 = new MonitorObject(WriteT);
            var monitorWriter3 = new MonitorObject(WriteA);
            var monitorWriter4 = new MonitorObject(WriteG);

            //monitorWriter1.AddMonitoredResource(sharedObject);
            monitorWriter2.AddMonitoredResource(sharedObject);
            monitorWriter3.AddMonitoredResource(sharedObject);
            monitorWriter4.AddMonitoredResource(sharedObject);

            monitorWriter1.Run();
            monitorWriter2.Run();
            monitorWriter3.Run();
            monitorWriter4.Run();

            //monitorWriter1.Wait();
            //monitorWriter2.Wait();
            //monitorWriter3.Wait();
            //monitorWriter4.Wait();
        }

        private void WriteC() {
            
            for (int i = 0; i < 150; i++){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("C");
                Thread.Sleep(sharedObject.RandomNumber());
            }

        }

        private void WriteT() {                        

            for (int i = 0; i < 150; i++){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("T");
                Thread.Sleep(sharedObject.RandomNumber());
            }

        }

        private void WriteA() {

            for (int i = 0; i < 150; i++){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("A");
                Thread.Sleep(sharedObject.RandomNumber());
            }

        }

        private void WriteG() {

            for (int i = 0; i < 150; i++) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("G");
                Thread.Sleep(sharedObject.RandomNumber());
            }

        }
    }
}
