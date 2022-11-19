namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            bool result = true;
            uint i = 2;
            if (n <= 1)
            {
                result = false;
            }

            for (; i < n; i++)
            {
                if (n % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            int sum = 0;
            int n = end;
            if (n > 1)
            {
                for (; n > start; n--)
                {
                    int i;
                    for (i = 2; i < n; i++)
                    {
                        for (; n % i == 0; n--)
                        {
                            i = 2;
                        }
                    }

                    if (n > 1)
                    {
                        for (int j = n; j > 0; j /= 10)
                        {
                            sum += j % 10;
                        }
                    }
                }
            }

            return (ulong)sum;
        }
    }
}
