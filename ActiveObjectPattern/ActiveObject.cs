using System.Collections.Concurrent;
using System.Threading;

namespace ActiveObjectPattern {
    public class ActiveObject {

        private Thread t;
        private BlockingCollection<ThreadStart> requestQueue;

        public ActiveObject() {
            
            requestQueue = new BlockingCollection<ThreadStart>();

            t = new Thread( () => { 
                    try {
                        while (t.IsAlive) {

                            requestQueue.Take().Invoke();

                        }
                    } catch(ThreadInterruptedException e) { /* Ignore it */}
                }
            );

            t.Start();
        }

        public void Accept(ThreadStart request) {
            try {

                requestQueue.Add(request);
                
            } catch(ThreadInterruptedException e) { /* Ignore it */}
        }

    }
}
