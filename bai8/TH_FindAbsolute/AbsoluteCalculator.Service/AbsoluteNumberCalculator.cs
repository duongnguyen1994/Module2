using System;

namespace AbsoluteCalculator.Service
{
    public class AbsoluteNumberCalculator
    {
        public int FindAbsolute(int number)
        {
            if(number<0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
    }
}
