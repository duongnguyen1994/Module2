namespace BT_AccessModifier
{
    class Circle
    {
        private double radius = 1.0;
        private string color = "red";
        public Circle(){}
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public string GetColor()
        {
            return color;
        }
    }
}