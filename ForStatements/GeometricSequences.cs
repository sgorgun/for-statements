using System.Globalization;

namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            uint product = 1;
            uint i = 0;

            for (; i < n; i++)
            {
                uint rpow = 1;
                uint j = 0;

                for (; j < i; j++)
                {
                    rpow *= r;
                }

                product *= a * rpow;
            }

            return product;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            uint sum = 0;
            uint a = 5;
            uint r = 3;
            uint i = 0;

            for (; i < n; i++)
            {
                uint rpow = 1;
                uint j = 0;

                for (; j < i; j++)
                {
                    rpow *= r;
                }

                sum += a * rpow;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            ulong term = a;
            ulong i = 0;

            for (; term <= maxTerm;)
            {
                i++;
                ulong rpow = 1;
                ulong j = 0;
                for (; j < i; j++)
                {
                    rpow *= r;
                }

                term = a * rpow;
            }

            return i;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            uint i = n - 1;
            for (; ;)
            {
                uint rpow = 1;

                for (uint j = 0; j < i; j++)
                {
                    rpow *= r;
                }

                uint term = a * rpow;

                if (term < minTerm && i == n - 1)
                {
                    return 0;
                }

                if (term <= minTerm || i == 0)
                {
                    break;
                }

                i--;
            }

            return n - i;
        }
    }
}
