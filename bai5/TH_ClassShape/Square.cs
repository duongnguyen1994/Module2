using System;
using System.Collections.Generic;
using System.Text;

namespace TH_ClassShape
{
    class Square:Rectangle
    {
        public double Side
        {
            get { return Length; }
            set { Side = Length; }
        }
        public Square():base()
        { 
        
        }
        public Square(double _side) : base(_side, _side)
        {  
            
        }
        public Square(string _color, bool _filled, double _side):base(_color,_filled, _side,_side)
        {

        }
        public override string ToString()
        {
            return $"A Square with side = {Side}, which is a subclass of {base.ToString()}";
        }
    }
}
