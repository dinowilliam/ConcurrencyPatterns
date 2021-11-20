using System;

namespace ActiveObjectPattern {
    public class PrinterTask : ActiveObject {
        
        public void Print(string Message) {
            Accept( () => {
                        Console.WriteLine(Message);
                    }
            );
        }

    }
}
