using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Point2D
    {
        private float x;
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        private float y;
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point2D()
        {

        }
        public Point2D(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        public void SetXY(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        public float[] GetXY()
        {
            float[] arr = { x, y };
            return arr;
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
