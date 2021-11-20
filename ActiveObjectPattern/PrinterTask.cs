using System;

namespace ActiveObjectPattern {
    public class PrinterTask : ActiveObject {
        
        public void Print(string Message, ConsoleColor Color) {
            Accept( () => {
                        Console.ForegroundColor = Color;
                        Console.Write(Message);
                    }
            );
        }

    }
}
