using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BT_List
{
    class SortAnimal : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            char[] temp1 = x.Type.ToCharArray();
            char[] temp2 = y.Type.ToCharArray();
            if (temp1 == null || temp2 == null)
            {
                throw new Exception();
            }
            else
            {                
                if(temp1[0]>temp2[0])
                {
                    return 1;
                }
                else if(temp1[0] == temp2[0])
                {
                    return 0;
                }
                return -1;
            }
        }
    }
}
