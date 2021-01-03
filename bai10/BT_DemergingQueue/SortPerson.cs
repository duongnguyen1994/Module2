using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BT_DemergingQueue
{
    class SortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x == null || y == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if(((Person)x).DayOfBirth> ((Person)y).DayOfBirth)
                {
                    return 1;
                }
                else if (((Person)x).DayOfBirth < ((Person)y).DayOfBirth)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
