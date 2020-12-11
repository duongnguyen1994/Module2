using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Color = "yellow";
            fan1.On = true;
            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            Console.WriteLine("Fan 1:");
            fan1.DisplayFan(fan1);
            Console.WriteLine("\nFan 2:");
            fan2.DisplayFan(fan2);
        }
    }
    public class Fan
    {
        private const int _SLOW = 1;
        private const int _MEDIUM = 2;
        private const int _FAST = 3;
        public static int FAST => _FAST;
        public static int MEDIUM => _MEDIUM;
        public static int SLOW => _SLOW;

        private int _speed = SLOW;
        private bool _on = false;
        private double _radius = 5;
        private string _color = "blue";
        public int Speed {get => _speed; set => _speed = value;}
        public bool On
        {
            get{return _on;}
            set{_on = value;}
        }
        public double Radius
        {
            get{return _radius;}
            set{_radius = value;}
        }
        public string Color
        {
            get{return _color;}
            set{_color = value;}
        }
        public Fan()
        {}
        public void DisplayFan(Fan fan)
        {
            if(fan.On)
            {
                Console.WriteLine($"Speed: {fan.Speed}");
                Console.WriteLine($"Color: {fan.Color}");
                Console.WriteLine($"Radius: {fan.Radius}");
                Console.WriteLine("Fan is on");
            }
            else
            {
                Console.WriteLine($"Speed: {fan.Speed}");
                Console.WriteLine($"Color: {fan.Color}");
                Console.WriteLine($"Radius: {fan.Radius}");
                Console.WriteLine("Fan is off");
            }
        }
    }
}
