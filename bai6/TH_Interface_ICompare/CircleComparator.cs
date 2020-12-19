using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Interface_ICompare
{
    class CircleComparator: IComparer<Circle>
    {
        public int Comparer(Circle circle1, Circle circle2)
        {
            if(circle1.Radius>circle2.Radius)
            {
                return 1;
            }
            else if(circle1.Radius < circle2.Radius)
            {
                return -1;
            }
            return 0;
        }
    }
}
