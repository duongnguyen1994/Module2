using System;
using System.Collections.Generic;
using System.Text;

namespace TH_IComparable
{
    class ComperableCircle : Circle, IComparable<ComperableCircle>
    {
        public ComperableCircle() { }
        public ComperableCircle(int radius) : base(radius) { }
        public int CompareTo(ComperableCircle o)
        {
            if (Radius > o.Radius) return 1;
            else if (Radius < o.Radius) return -1;
            return 0;
        }
    }
}
