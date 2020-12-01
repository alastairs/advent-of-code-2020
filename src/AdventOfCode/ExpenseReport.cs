using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class ExpenseReport
    {
        public IEnumerable<int> Find2020(IEnumerable<int> input)
        {
            var inputList = input.ToList();
            return inputList.SelectMany(i => inputList.Where(j => 2020 - i - j == 0)).Take(2);
        }
    }
}
