using System;
using FilterByPredicate;

namespace FilterByPositivePredicate
{
        public class PositiveNumberFilter : Filter
        {
            protected override bool IsMatch(int item)
            {
                if (item > 0)
                {
                    return true;
                }

                return false;
            }
        }
    }
