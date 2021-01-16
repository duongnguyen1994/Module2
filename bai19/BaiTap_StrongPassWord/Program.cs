using System;
using System.Collections.Generic;

namespace BaiTap_StrongPassWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "NguyenTrungDu0ng.";    
            if(CheckPassWord(password))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        static bool CheckPassWord(string pass)
        {
            string symbols = @"!@#$%^&()-_+[{}]\|:;'<>,./?" + '"';
            bool checkNumber = false;
            bool checkSymbol = false;
            int testNumber;
            List<string> passChar = new List<string>();
            foreach(char items in pass)
            {
                passChar.Add($"{items}");
            }
            List<string> symbolChar = new List<string>();
            foreach(char items in symbols)
            {
                symbolChar.Add($"{items}");
            }
            if(pass.ToLower()==pass)
            {
                return false;
            }
            if(pass.ToUpper() == pass)
            {
                return false;
            }
            for(int i =0;i< passChar.Count;i++)
            {
                checkNumber = int.TryParse(passChar[i], out testNumber);
                if (checkNumber)
                {
                    break;
                }
            }
            foreach(string items in symbolChar)
            {
                if(passChar.Contains(items))
                {
                    checkSymbol = true;
                }
            }
            if(!checkNumber)
            {
                return false;
            }
            if(!checkSymbol)
            {
                return false;
            }
            if(passChar.Count<8)
            {
                return false;
            }
            return true;
        }
    }
}
