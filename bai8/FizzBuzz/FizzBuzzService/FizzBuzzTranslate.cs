namespace FizzBuzz.Service
{
    public class FizzBuzzTranslate
    {      
        public string TranslateNumber(int number)
        {
            if(number==0)
            {
                return "khong";
            }
            if (number<10)
            {
                return TranslateNumberUnder10(number);
            }
            if (number==10)
            {
                return "muoi";
            }
            if (number>10&&number<20)
            {
                return $"muoi {TranslateNumberUnder10(number%10)}";
            }
            if (number>20&&number<100)
            {
                return $"{TranslateNumberUnder10((number/10)%10)} muoi {TranslateNumberUnder10(number%10)}";
            }
            return "";
        }
        public string TranslateNumberUnder10(int number)
        {
            switch(number)
            {
                case 1: 
                return "mot";
                case 2:
                return "hai";
                case 3:
                return "ba";
                case 4:
                return "bon";
                case 5:
                return "nam";
                case 6:
                return "sau";
                case 7:
                return "bay";
                case 8:
                return "tam";
                default:
                return "chin";
            }
        }
    }
}