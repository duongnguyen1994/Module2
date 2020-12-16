using System;
using System.Collections.Generic;
using System.Text;

namespace BT_PointAndMoveablePoint
{
    class MovablePoint:Point
    {
        private float xSpeed;
        public float XSpeed
        {
            get { return xSpeed; }
            set { xSpeed = value; }
        }
        private float ySpeed;
        public float YSpeed
        {
            get { return ySpeed; }
            set { ySpeed = value; }
        }
        public MovablePoint()
        {

        }
        public MovablePoint(float _x, float _y,float _xSpeed, float _ySpeed):base(_x,_y)
        {
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }
        public float[] GetSpeed()
        {
            float[] arr = { xSpeed, ySpeed };
            return arr;
        }
        public override string ToString()
        {
            return $"Position: {base.ToString()}\t\tSpeed:({xSpeed},{ySpeed})";
        }
        public void Move()
        {
            X += xSpeed;
            Y += ySpeed;
        }
    }
}
