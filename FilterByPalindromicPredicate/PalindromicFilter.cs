using System;
using FilterByPredicate;

namespace FilterByPalindromicPredicate
{
    /// <summary>
    /// Represents an class filter of the array on a given digit.
    /// </summary> 
    public class PalindromicFilter : Filter
    {
        /// <inheritdoc/>
        protected override bool IsMatch(int item)
        {
            {
                if (item < 0)
                {
                    return false;
                }

                int digitnum = GetNumberOfDigits(item);
                while (digitnum > 1)
                {
                    byte lustNum = (byte)(item % 10);
                    byte firstNum = (byte)(item / GetNumberOfZeroes(digitnum));
                    if (firstNum != lustNum)
                    {
                        return false;
                    }

                    item /= 10;
                    item = item % GetNumberOfZeroes(digitnum - 1);
                    digitnum -= 2;
                }

                return true;

                static int GetNumberOfDigits(int a) => a switch
                {
                    < 10 => 1,
                    < 100 => 2,
                    < 1000 => 3,
                    < 10000 => 4,
                    < 100000 => 5,
                    < 1000000 => 6,
                    < 10000000 => 7,
                    < 100000000 => 8,
                    < 1000000000 => 9,
                    _ => 10,
                };

                static int GetNumberOfZeroes(int a) => a switch
                {
                    2 => 10,
                    3 => 100,
                    4 => 1000,
                    5 => 10000,
                    6 => 100000,
                    7 => 1000000,
                    8 => 10000000,
                    9 => 100000000,
                    _ => 1000000000,
                };
            }
        }
    }
}
