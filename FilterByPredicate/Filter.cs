﻿using System;

namespace FilterByPredicate
{
    /// <summary>
    /// Base class for the array filter.
    /// </summary>
    public abstract class Filter
    {
        /// <summary>
        /// Filters array according to the specified condition.
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <returns>A filtered array.</returns>
        /// <exception cref="ArgumentNullException">Throws when the array is null.</exception>
        /// <exception cref="ArgumentException">Throws when the array is empty.</exception>
        public int[] Select(int[]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "Array is null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("array is empty.");
            }

            List<int> result = new List<int>();
            foreach (var item in source)
            {
                if (this.IsMatch(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Presents predicate logic.
        /// </summary>
        /// <param name="item">Source item.</param>
        /// <returns>true if item satisfy some condition, false otherwise.</returns>
        protected abstract bool IsMatch(int item);
    }
}
