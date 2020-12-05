using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class ExpenseReport
    {
        public IEnumerable<int> Find2020(IEnumerable<int> input, int number = 2, int sum = 2020)
        {
            var inputList = input.ToList();

            var orderedList = inputList.OrderBy(i => i).ToList();

            // Q(orderedList.Count, 2020)
            // A = orderedList.Sum(i => i < 0); B = orderedList.Sum(i => i > 0);
            // Array<Q(i, s)> where i = 1 <= orderedList.Count; s = A <= s <= B
            // Q(1, 2020) = orderedList.First() == 2020
            // Q(2..orderedList.Count, 2020) =

            return number switch
            {
                2 => inputList.SelectMany(
                    i => inputList.Where(j => sum - i - j == 0)).Take(2),
                _ => Array.Empty<int>()
            };
        }

        private bool Find2020(IList<int> input, int sum = 2020, int index = 0)
        {
            var inputList = input.ToList();
            var sumNegatives = inputList.Where(i => i < 0).Sum();
            var sumPositives = inputList.Where(i => i > 0).Sum();

            if (sum < sumNegatives || sum > sumPositives)
            {
                return false;
            }


            var qArray = new bool[inputList.Count];

            qArray[index - 1] = index switch
            {
                1 => inputList[0] == sum,
                _ => Enumerable.Range(sumNegatives, sumPositives).ToList().ForEach(
                    i => Find2020(inputList, sum, index: i - 1) || inputList[i - 1] == sum || Find2020(i - 1, sum: sum - inputList [i-1])
            };
        }
    }

    internal class EnumerableEqualityComparer<T> : IEqualityComparer<IEnumerable<T>>
    {
        public bool Equals(IEnumerable<T>? x, IEnumerable<T>? y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return new HashSet<T>(x).SetEquals(y);
        }

        public int GetHashCode(IEnumerable<T> obj)
        {
            unchecked
            {
                return obj.Aggregate(17, (hash, o) => hash * 23 + o!.GetHashCode());
            }
        }
    }
}
