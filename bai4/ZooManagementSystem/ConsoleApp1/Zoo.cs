using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Zoo
    {
        public Cage[] CageList = new Cage[0];
        public void AddCage(Cage cage)
        {
            Array.Resize(ref CageList, CageList.Length + 1);
            CageList[CageList.Length-1] = cage;
        }
        public void RemoveCage(int cageNumber)
        {
            for(int i = 0;i<CageList.Length;i++)
            {
                if(CageList[i].CageNumber== cageNumber)
                {
                    for(int j = i; j < CageList.Length - 1; j++)
                    {
                        CageList[j] = CageList[j + 1];
                    }
                    Array.Resize(ref CageList, CageList.Length - 1);
                }
            }
        }
        public bool checkCageNumber(int number)
        {
            for(int i = 0; i< CageList.Length;i++)
            {
                if(number == CageList[i].CageNumber)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
