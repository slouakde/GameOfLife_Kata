namespace GameOfLife_Kata.FizzBuzz
{
    public static class FizzBuzzEngine
    {
        public static string GetFizzBuzzResult(int i)
        {
            var fizz = i.IsMultipleOf(3);
            var buzz = i.IsMultipleOf(5);

            if (fizz && buzz)
                return "FizzBuzz";

            if (fizz)
                return "Fizz";

            if (buzz)
                return "Buzz";

            return i.ToString();
        }
        
        public static bool IsMultipleOf(this int input, int divisor)
        {
            return input % divisor == 0;
        }
    }
}
