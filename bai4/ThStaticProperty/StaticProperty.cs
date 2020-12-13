using System;

namespace ThStaticProperty
{
    class Car
    {
        private string name;
        private string engine;
        public static int numberOfCar;
        
        public Car(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberOfCar++;
        }
    }
}