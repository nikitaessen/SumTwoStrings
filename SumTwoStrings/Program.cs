namespace SumTwoStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            string x = "12345678901234567890";
            string y = "23232323232323232324";

            var calc = new Calculator();
            var sum = calc.SumTwoStrings(x, y);
        }
    }
}
