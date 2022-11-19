namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            int termOne = 0;
            int termTwo = 1;
            if (n == 0)
            {
                return termOne;
            }

            for (int i = 2; i <= n; i++)
            {
                int temp = termOne + termTwo;
                termOne = termTwo;
                termTwo = temp;
            }

            return termTwo;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            ulong product = 1;
            ulong termOne = 0;
            ulong termTwo = 1;
            if (n == 0)
            {
                return 0;
            }

            for (ulong i = 2; i <= n; i++)
            {
                ulong temp = termOne + termTwo;
                termOne = termTwo;
                termTwo = temp;
            }

            for (; termTwo > 0; termTwo /= 10)
            {
                product *= termTwo % 10;
            }

            return product;
        }
    }
}
