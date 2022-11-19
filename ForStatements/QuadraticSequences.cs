namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            long term = 0;
            uint i = 1;

            for (; term < maxTerm; i++)
            {
                term = (a * i * i) + (b * i) + c;
            }

            if (i > 0)
            {
                return i - 1;
            }

            return 0;
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            ulong result = 1;
            ulong term = 0;
            uint a = 7;
            uint b = 4;
            uint c = 2;
            uint myCount = count;

            for (uint i = 1; i <= count; i++)
            {
                term = (a * i * i) + (b * i) + c;

                if (myCount > 0)
                {
                    result *= term;
                    myCount--;
                }
            }

            return result;
        }

        public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
        {
            ulong result = 1;
            ulong term = 0;
            long i = 1;

            for (; i <= startN + count; i++)
            {
                term = (ulong)((a * i * i) + (b * i) + c);

                if (i >= startN && i < startN + count)
                {
                    result *= term;
                }
            }

            return result;
        }
    }
}
