using System;

namespace UnitTesting.Math
{
    public class Addition
    {
        public int AddTwoNumbers(int one, int two)
        {
            return one + two;
        }

        public int AddTwoNonZeroPositiveIntegers(int one, int two)
        {
            if (one < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(one));
            }

            if (two < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(two));
            }

            return one + two;
        }
    }
}