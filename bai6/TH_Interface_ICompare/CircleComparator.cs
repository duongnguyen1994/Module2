using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TH_Interface_ICompare
{
    class CircleComparator: IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.Radius > c2.Radius)
            {
                return 1;
            }
            else if (c1.Radius < c2.Radius)
            {
                return -1;
            }
            return 0;
        }      
    }
}
