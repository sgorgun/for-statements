namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public static int SumFactorialDigits(int n)
        {
            int sum = 0;

            if (n == 0)
            {
                return 1;
            }

            int product = 1;
            int i = 1;

            for (; i <= n; i++)
            {
                product *= i;
            }

            for (; product > 0; product /= 10)
            {
                sum += product % 10;
            }

            return sum;
        }
    }
}
