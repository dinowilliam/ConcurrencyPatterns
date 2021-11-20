using System;

namespace ConcurrencyPatterns.Resources
{
    internal class SharedObject {

        public SharedObject() { }

        public int RandomNumber(){
            return new Random().Next(1, 10);
        }
    }
}