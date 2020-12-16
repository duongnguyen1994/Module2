using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Point3D:Point2D
    {
        private float z;
        public float Z
        {
            get { return z; }
            set { z = value; }
        }
        public Point3D()
        {

        }
        public Point3D(float _x, float _y) : base(_x, _y)
        {
 
        }
        public Point3D(float _x, float _y, float _z):base(_x, _y)
        {
            z = _z;
        }
        public void SetXYZ(float _x, float _y, float _z)
        {
            X = _x;
            Y = _y;
            z = _z;
        }
        public float[] GetXYZ()
        {
            float[] arr = { X, Y, z };
            return arr;
        }
        public override string ToString()
        {
            return $"({X},{Y},{z})";
        }
    }
}
