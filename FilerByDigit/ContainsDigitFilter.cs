﻿using System;
using FilterByVariousPredicate;

namespace FilterByDigitPredicate
{
    /// <summary>
    /// Represents an array filter on a given digit.
    /// </summary>
    public class ContainsDigitFilter : Filter
    {
        /// <summary>
        /// Gets or sets a digit.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when Digit more than 9 or less than 0.</exception>
        public int Digit
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        protected override bool Verify(int item)
        {
            throw new NotImplementedException();
        }
    }
}
