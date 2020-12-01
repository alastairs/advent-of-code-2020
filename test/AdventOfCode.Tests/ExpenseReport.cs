using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AdventOfCode.Tests
{
    public class ExpenseReport
    {
        [Theory, MemberData(nameof(Input))]
        public void Find2020_finds_the_items(IEnumerable<int> input, IList<int> expected)
        {
            Assert.Equal(expected.OrderBy(i => i), Find2020(input).OrderBy(i => i));
        }

        private IEnumerable<int> Find2020(IEnumerable<int> input)
        {
            var inputList = input.ToList();
            return inputList.SelectMany(i => inputList.Where(j => 2020 - i - j == 0)).Take(2);
        }

        public static IEnumerable<object[]> Input
        {
            get
            {
                yield return new object[]
                {
                    new[] { 1721, 979, 366, 299, 675, 1456 },
                    new [] { 1721, 299 }
                };

                yield return new object[]
                {
                    new[] { 1010, 1010, 366, 299, 675, 1456 },
                    new[] { 1010, 1010 }
                };

                yield return new object[]
                {
                    new[] { 2019, 1, 366, 299, 675, 1456 },
                    new[] { 2019, 1 }
                };

                yield return new object[]
                {
                    new[] { 2020, 0, 366, 299, 675, 1456 },
                    new[] { 2020, 0 }
                };

                yield return new object[]
                {
                    new[] { 1041, 979, 366, 299, 675, 1456 },
                    new[] { 1041, 979 }
                };

                yield return new object[]
                {
                    new[] { 1654, 979, 366, 299, 675, 1456 },
                    new[] { 1654, 366 }
                };

                yield return new object[]
                {
                    new[] { 1345, 979, 366, 299, 675, 1456 },
                    new[] { 1345, 675 }
                };

                yield return new object[]
                {
                    new[] { 564, 979, 366, 299, 675, 1456 },
                    new[] { 564, 1456 }
                };
            }
        }
    }
}
