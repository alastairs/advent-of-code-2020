using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class ExpenseReport
    {
        public IEnumerable<int> Find2020(IEnumerable<int> input, int number = 2, int sum = 2020)
        {
            var array = input.ToArray();

            if (number == 2)
            {
                return array.Where(j => array.Any(k => k + j == 2020));
            }

            return array.Select((item, index) =>
            {
                var laterNumbers = array[index..];
                return Paula(item, laterNumbers, sum);
            }).First(x => x.Any());
        }

        private static IEnumerable<int> Paula(int z, IReadOnlyList<int> input, int sum = 2020)
        {
            for (var i = 0; i < input.Count - 1; i++)
            {
                var x = input[i + 1];
                for (var j = 0; j < input.Count - 2; j++)
                {
                    var y = input[j + 2];
                    if (x + y + z == sum)
                    {
                        return new [] { x, y, z };
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}
