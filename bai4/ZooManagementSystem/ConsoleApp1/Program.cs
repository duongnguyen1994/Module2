using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            bool checkChoice = true;
            Zoo ThaoCamVien = new Zoo();
            do
            {
                MenuAction();
                checkChoice = int.TryParse(Console.ReadLine(), out choice);
                switch(choice)
                {
                    case 1:
                        AddCase(ThaoCamVien);
                        break;
                    case 2:
                        RemoveCage(ThaoCamVien);
                        break;
                    case 3:
                        AddAnimal(ThaoCamVien);
                        break;
                    case 4:
                        RemoveAnimal(ThaoCamVien);
                        break;
                    case 5:
                        IterateAnimal(ThaoCamVien);
                        break;
                    default:
                        Environment.Exit(6);
                        break;
                }
            } while(!checkChoice||choice!=6);
        }

        private static void IterateAnimal(Zoo ThaoCamVien)
        {
            for (int i = 0; i < ThaoCamVien.CageList.Length; i++)
            {
                Console.WriteLine($"Cage Number {ThaoCamVien.CageList[i].CageNumber}");
                Console.WriteLine("Name\t\tAge\t\tDescription\t\tSpeaker");
                ThaoCamVien.CageList[i].ShowInfoCage();
            }
            Console.ReadLine();
        }

        private static void RemoveAnimal(Zoo ThaoCamVien)
        {
            bool check = true;
            int cageNumber;
            string name;
            do
            {
                Console.WriteLine("Enter cage number");
                check = int.TryParse(Console.ReadLine(), out cageNumber);
                if (ThaoCamVien.checkCageNumber(cageNumber))
                {
                    Console.WriteLine($"Cage Number {cageNumber} is not exist!");
                }
            } while (!check || ThaoCamVien.checkCageNumber(cageNumber));
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            for (int i = 0; i < ThaoCamVien.CageList.Length; i++)
            {
                if (name == ThaoCamVien.CageList[i].AnimalList[0].Name)
                {
                    ThaoCamVien.CageList[i].RemoveAnimal(name);
                    Console.WriteLine("Complete!");
                    Console.ReadLine();
                }
            }
        }

        private static void AddAnimal(Zoo ThaoCamVien)
        {
            int species;
            bool check = true;
            int cageNumber;
            string name;
            int age;
            string description;
            do
            {
                Console.WriteLine("Enter cage number");
                check = int.TryParse(Console.ReadLine(), out cageNumber);
                if (ThaoCamVien.checkCageNumber(cageNumber))
                {
                    Console.WriteLine($"Cage Number {cageNumber} is not exist!");
                }
            } while (!check || ThaoCamVien.checkCageNumber(cageNumber));
            do
            {
                Console.WriteLine("Enter species\n1. Tiger\n2. Cat\n3. Dog");
                check = int.TryParse(Console.ReadLine(), out species);
            } while (!check || species > 3 || species < 1);
            if (ThaoCamVien.CageList.Length == 0)
            {
                Console.WriteLine($"No cage in zoo! Please add cage");
            }
            else
            {
                switch (species)
                {
                    case 1:
                        AddInfoOfSpecies(out check, out name, out age, out description);
                        Tiger tiger = new Tiger(name, age, description);
                        AddSpecies(ThaoCamVien, cageNumber, tiger);
                        break;
                    case 2:
                        AddInfoOfSpecies(out check, out name, out age, out description);
                        Cat cat = new Cat(name, age, description);
                        AddSpecies(ThaoCamVien, cageNumber, cat);
                        break;
                    default:
                        AddInfoOfSpecies(out check, out name, out age, out description);
                        Dog dog = new Dog(name, age, description);
                        AddSpecies(ThaoCamVien, cageNumber, dog);
                        break;
                }
            }
        }

        private static void AddSpecies(Zoo ThaoCamVien, int cageNumber, Animal animal)
        {
            for (int i = 0; i < ThaoCamVien.CageList.Length; i++)
            {
                if (ThaoCamVien.CageList[i].CageNumber == cageNumber)
                {
                    ThaoCamVien.CageList[i].AddAnimal(animal);
                    Console.WriteLine("Complete!");
                    Console.ReadLine();
                }
            }
        }

        private static void AddInfoOfSpecies(out bool check, out string name, out int age, out string description)
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter age:");
                check = int.TryParse(Console.ReadLine(), out age);
            } while (!check || age <= 0);
            Console.WriteLine("Enter description");
            description = Console.ReadLine();
        }

        private static void RemoveCage(Zoo ThaoCamVien)
        {
            bool check = true;
            int cageNumber = 0;
            do
            {
                Console.WriteLine("Enter cage's number want to remove");
                check = int.TryParse(Console.ReadLine(), out cageNumber);
                if (ThaoCamVien.CageList.Length == 0)
                {
                    Console.WriteLine($"No cage in zoo!\nPlease add cage first");
                    Console.ReadLine();
                    break;
                }
                else if (ThaoCamVien.checkCageNumber(cageNumber))
                {
                    Console.WriteLine($"Cage Number {cageNumber} is not exit");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Complete!");
                    Console.ReadLine();
                }
            } while (!check || ThaoCamVien.checkCageNumber(cageNumber));
            ThaoCamVien.RemoveCage(cageNumber);
        }

        private static void AddCase(Zoo ThaoCamVien)
        {
            bool check = true;
            int number = 0;
            Cage cage = new Cage();
            do
            {
                Console.WriteLine("Enter cage's number");
                check = int.TryParse(Console.ReadLine(), out number);
                for(int i =0;i<ThaoCamVien.CageList.Length;i++)
                {
                    if(number == ThaoCamVien.CageList[i].CageNumber)
                    {
                        Console.WriteLine($"Cage number {number} is already!");
                        Console.ReadLine();
                        check = false;
                    }
                }
            } while (!check || number <= 0);
            cage.CageNumber = number;
            ThaoCamVien.AddCage(cage);
            Console.WriteLine("Complete!\nPlease enter to continued");
            Console.ReadLine();
        }

        static void MenuAction()
        {
            Console.Clear();
            Console.WriteLine("ZOO MANAGEMENT SYSTEM");
            Console.WriteLine("\n1. Add cage");
            Console.WriteLine("2. Remove cage");
            Console.WriteLine("3. Add animal");
            Console.WriteLine("4. Remove animal");
            Console.WriteLine("5. Iterate animals");
            Console.WriteLine("6. Exit");
        }
    }
}
