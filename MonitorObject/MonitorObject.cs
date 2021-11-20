using System;
using System.Collections.Generic;
using System.Threading;

namespace MonitorObjectPattern {
    
    public class MonitorObject   {

        private Thread t;
        private ThreadStart threadStart;
        private List<Object> monitoredResourceList;

        public MonitorObject(ThreadStart tStart) {
            this.monitoredResourceList = new List<Object>();
            this.threadStart = tStart;
        }
       
        public void Run() {
            
            Action onThreadCompletedUnlockResources = () => {
                
                //On complete unlock resources
                UnlockResources();
            };

            //Thread execution start
            t = new Thread(() => {
                try {                    
                    //Block resources
                    LockResources();

                    //Execute procedure
                    this.threadStart.Invoke();                                                                                                      
                }
                catch (ThreadInterruptedException e) { /* Ignore it */}
                finally {
                    onThreadCompletedUnlockResources();
                }
            });

            t.Start();            
        }
        
        private void LockResources(){

            foreach (Object obj in monitoredResourceList){
                Monitor.Enter(obj);
            }

        }

        private void UnlockResources(){

            foreach (Object obj in monitoredResourceList){
                Monitor.Exit(obj);
            }

        }

        public void AddMonitoredResource(Object monitoredObject) {
            monitoredResourceList.Add(monitoredObject);
        }

        public void RemoveMonitoredResource(Object monitoredObject) {
            monitoredResourceList.Remove(monitoredObject);
        }


    }

}
