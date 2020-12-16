using System;
using System.Collections.Generic;
using System.Text;

namespace TH_ClassShape
{
    class Shape
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private bool filled;
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }
        public Shape()
        {
            color = "green";
            filled = true;
        }
        public Shape(string _color, bool _filled)
        {
            color = _color;
            filled = _filled;
        }
        public override string ToString()
        {
            if(filled)
            {
                return $"A Shape with color of {color} and filled";
            }
            else
            return $"A Shape with color of {color} and not filled";
        }
    }
}
