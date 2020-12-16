using System;

namespace BT_PointAndMoveablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point test
            Point point = new Point(10, 10);
            Console.WriteLine(point.ToString());

            // MovablePoint test
            MovablePoint movablePoint = new MovablePoint(5,5,10,10);
            Console.WriteLine(movablePoint.ToString());
            movablePoint.Move();
            Console.WriteLine(movablePoint.ToString());
        }
    }
}
