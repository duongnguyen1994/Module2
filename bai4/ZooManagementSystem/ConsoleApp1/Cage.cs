using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cage
    {
        private int cageNumber;
        public int CageNumber
        { 
            get { return cageNumber; }
            set { cageNumber = value; }
        }
        public Animal[] AnimalList = new Animal[0];
        public void AddAnimal(Animal species)
        {
            Array.Resize(ref AnimalList, AnimalList.Length + 1);
            AnimalList[AnimalList.Length - 1] = species;
        }
        public void RemoveAnimal(string name)
        {
            for(int i = 0;i<AnimalList.Length;i++)
            {
                if(AnimalList[i].Name == name)
                {
                    for(int j =i;j<AnimalList.Length-1;j++)
                    {
                        AnimalList[j] = AnimalList[j + 1];
                    }
                    Array.Resize(ref AnimalList, AnimalList.Length - 1);
                }
            }
        }
        public void ShowInfoCage()
        {
            for(int i = 0;i<AnimalList.Length;i++)
            {
                Console.WriteLine($"{AnimalList[i].ViewInfo()}");
            }
        }
    }
}
