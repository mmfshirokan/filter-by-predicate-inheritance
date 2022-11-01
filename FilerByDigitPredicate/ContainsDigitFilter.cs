using System;
using FilterByPredicate;

namespace FilterByDigitPredicate
{
    /// <summary>
    /// Represents an class filter of the array on a given digit.
    /// </summary>
    public class ContainsDigitFilter : Filter
    {
        private int digit;

        /// <summary>
        /// Gets or sets a digit.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when Digit more than 9 or less than 0.</exception>
        public int Digit
        {
            get
            {
                return this.digit;
            }
    
            set
            {
                if (value > 9 || value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this.digit = value;
            }
        }

        /// <inheritdoc/>
        protected override bool IsMatch(int item)
        {
            long val = item;

            if (val < 0)
            {
                val = -val;
            }

            long rest = val % 10;
            do
            {
                if (rest == this.Digit)
                {
                    return true;
                }

                val /= 10;
                rest = val % 10;
            }
            while (val != 0);

            return false;
        }
    }
}
