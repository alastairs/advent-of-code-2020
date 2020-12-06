﻿using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode.Tests
{
    public class NavigationFacts
    {
        public NavigationFacts(ITestOutputHelper console) => Console = console;
        public ITestOutputHelper Console { get; set; }

        [Theory, MemberData(nameof(Routes))]
        public void CountTrees(int right, int down, int numberOfTrees)
        {
            var input = SampleInput.ToArray();

            int rowIndex = 0, charIndex = 0, treeCount = 0;
            while (rowIndex < input.Length)
            {
                var line = input[rowIndex];

                //Console.WriteLine($"({charIndex},{rowIndex}): {line}");
                if (line[charIndex] == '#')
                {
                    //Console.WriteLine("TREE!!!");
                    treeCount++;
                }

                charIndex += right;
                if (charIndex > line.Length - 1)
                {
                    charIndex = charIndex - line.Length;
                }

                rowIndex += down;
            }

            Assert.Equal(numberOfTrees, treeCount);
        }

        public static IEnumerable<object[]> Routes
        {
            get
            {
                yield return new object[]
                {
                    1, 1, 2
                };

                yield return new object[]
                {
                    3, 1, 7
                };

                yield return new object[]
                {
                    5, 1, 3
                };

                yield return new object[]
                {
                    7, 1, 4
                };

                yield return new object[]
                {
                    1, 2, 2
                };
            }
        }

        private IEnumerable<string> SampleInput => new []
        {
            "..##.......", //
            "#...#...#..", //
            ".#....#..#.", //
            "..#.#...#.#", // ..#.#...#.#
            ".#...##..#.", //
            "..#.##.....", //
            ".#.#.#....#", //
            ".#........#", //
            "#.##...#...", //
            "#...##....#", //
            ".#..#...#.#"  //
        };

        private IEnumerable<string> PuzzleInput => new[]
        {
            ".............#...#....#.....##.",
            ".#...##.........#.#.........#.#",
            ".....##......#.......#.........",
            ".......#...........#.#.........",
            "#...........#...#..#.#......#..",
            ".........##....#.#...#.........",
            ".....#.........#.#...........#.",
            "....#...............##....##...",
            "#.#.............#..#.......#.#.",
            "...#...........................",
                                            "......#..#....#.............#..",
                                            "........#......#.......#.......",
                                            "....#.....#..#.#...#.........#.",
                                            "..#.#.......#.##...#....#.....#",
                                            "...........#.........#..#......",
                                            "#...........#.#..#...#.#.#....#",
                                            "........#......................",
                                            "....#.#.....#....#.......#..#..",
                                            ".............................#.",
                                            "....##..........#.....##......#",
                                                                            "......#.....................#..",
                                                                            "..#.....##.......#.............",
                                                                            "....#.#..............#.#.......",
                                                                            "..#.#........#.....#..##.......",
                                                                            ".....#...##.........##....#.#..",
                                                                            ".#....#..#..#...........#......",
                                                                            ".............#.....##........#.",
                                                                            "..#....#............#.........#",
                                                                            "###..........#........#.......#",
                                                                            "#...#..#.#.#.........#..#......",
                                                                                                            "..#....#......#.............#..",
                                                                                                            "#...#........#..#...#.....#....",
                                                                                                            ".#..........#.#........#.......",
                                                                                                            "#.....#.........#..#......#....",
                                                                                                            "....#....##........#......#....",
                                                                                                            ".......#....#.....#..#..#.....#",
                                                                                                            ".........#...#.#...#.##........",
                                                                                                            ".##.##...........#..##..#......",
                                                                                                            ".#.##....#........#...#........",
                                                                                                            ".......##.........##.####.....#",
                                                                                                                                            "....#..##....#.................",
                                                                                                                                            ".#........#..........#.........",
                                                                                                                                            "##....##..........##........#..",
                                                                                                                                            "#......#...........#....#..#...",
                                                                                                                                            ".......#..#....##..##.....#....",
                                                                                                                                            ".........#.#.#...#.....#.......",
                                                                                                                                            "......#...#...#....#......#....",
                                                                                                                                            "##....#..........#....##....##.",
                                                                                                                                            "###.........#...#...#..........",
            "#.....##.#........#.......#....",
            "#...............#...##.#......#",
            "..#.....####.###......#......#.",
            "....#.......#..........#.......",
            "....##..............#.#.#......",
            ".......##..#.......#...........",
            "..#.......##....#.......###...#",
            "........#...#.......#.#...#....",
            ".........##....#..#....#.......",
            "............#.#.......#.#......",
            ".....#.....#...#....#.##.......",
            ".......#.........#.......#.....",
            ".#..#...#.....#............#.##",
            ".......#.#......##.............",
            "##.#......#.....#.#............",
            ".#....#.....#............#...#.",
            ".........#.......#.#...........",
            "#............#.##...#..#...#.#.",
            "......#....#.......#....#......",
            "..........#........#..#.#......",
            "#..##.......#.........#..#.....",
            ".........#.....##........#.#..#",
            "..#................#...........",
            "....#..#........##.........#..#",
            "###...#....##.#......##.......#",
            ".......#......##..#.......#....",
            ".......###...#...#..........##.",
            "................#.......#......",
            ".#......##.##........#.........",
            "....##.#.....##.......#........",
            "...........#...........#.....#.",
            "..#........#..#.#...#.#........",
            "#...............#...#.##.##.#.#",
            "................#.......#......",
            ".#..#......#........#.#........",
            "...##..#.......#.......#..#....",
            ".#.....#.#....##..#........#...",
            "........##......#..........#...",
            ".#.......#.......#...#..#......",
            ".#..##.....#....#............#.",
            "...#..........#....#........#..",
            "..#.#..#.......#.#.##..........",
            "#........###.....#.#.......#.##",
            ".....#....##.............#.#..#",
            "..##............#...##.........",
            "...#.........#...........#.....",
            "...#......#.#...#..###.........",
            ".............#...##............",
            ".....##..##.####.#..#......#.#.",
            ".#...#.....#.....#.#.....#.....",
            ".........#.......###.....#..##.",
            ".##.#..#..........#.##.#.#.....",
            ".#...#...#.#.##......#..#......",
            ".............#......#......#...",
            "#.....................#......#.",
            "...#.....#.....#....#........#.",
            "................##..#....#..#..",
            "#.###...#.....................#",
            "...#..#....#.......#.........#.",
            "...........#..#..#...........#.",
            ".......#..#......#....#.#......",
            "..........#......#..#....#.....",
            ".#.#.....#...#.#...#...#.#....#",
            ".....#.......#............#...#",
            "#.#....#......#......#........#",
            ".#.#..#.........##...#.........",
            "#..###..#......................",
            "..#.#..#.......................",
            ".##.....#...#......#..#........",
            "...#...........#...#.......##..",
            "..#...........#........#.......",
            "........#....#.....#.#.........",
            "..........#...........#.....#..",
            "......#...#...##.#.............",
            ".#...#...##....................",
            "............###.........#......",
            ".#.#...................#..#....",
            "....#.#...#.#........#.#.......",
            "....#...#...........#.......#.#",
            "...........#............#...##.",
            ".....####....#.#......#.#......",
            ".##.............#............#.",
            "......#.........#............##",
            "#.#....#...##....#.......#....#",
            ".....#.#....#..#..#...#..#.#..#",
            ".........................#.....",
            "......#.#....###.......#....#..",
            ".....................##.#...#.#",
            "..#.....#.#.#...#...#..........",
            "........#..##........#...#...#.",
            "..........#.#.##....#....##....",
            ".............#..#..............",
            "..#.##..#.......#...#..#..##..#",
            "..#..#....#.#..........#..#....",
            "..........#....#...#......#....",
            ".##...#.......................#",
            ".#.....#....#..........#.......",
            "...........#..#......##.....#..",
            "......###.#..##....#...#.##....",
            ".......#..#.#....#.............",
            "...#..#......##.........###.#..",
            "...........#............##...#.",
            "...#...#...........##.....#....",
            "..................#............",
            ".#.#.#...#..............#..##..",
            "#.#....#........#.........#.##.",
            "#.#.#.......#.....#..........#.",
            "...##.....##.#.....#...........",
            ".#....#..............##...##..#",
            "........##.....................",
            "#..#..#.....###.............#..",
            ".......#...........#...........",
            ".........#.....................",
            ".......#...#...#.....##........",
            "......#.........#........#.....",
            "...#....##..#.####.#.......#.#.",
            ".....#..#......#........#.##..#",
            ".##....#......##......#...###..",
            "..###.#........##.#...#.......#",
            "............#......##....#.#...",
            ".....#....##..##............##.",
            "......##....#.#...#....#.#..#.#",
            ".......#.........#.#.....#.#...",
            ".......#.#....#................",
            ".##...###..#.....#............#",
            "#.#......#.#..#..#.#...#..#..#.",
            "..#.#.#.....#............#...##",
            ".##....###.........#..#........",
            ".#..#.#..#.#....#.........##.#.",
            "....#..#...##.##........#......",
            "........#.#....##....#....#....",
            ".......#..#..#.#..............#",
            "#....#....#.....#....#.........",
            ".#.###...#....#.......#........",
            ".........#.#....##....#...#....",
            "....#.............#.....##.##..",
            ".....#.....#...##..#.#.##...##.",
            ".........#..#................##",
            "...##..##......#.....#........#",
            ".#....#.....#.#......#..###....",
            "#.....#..#.....................",
            "....#.#...#.#.................#",
            ".....##..................#.....",
            "#....##...#.##..###...#........",
            "##.#.........#.......#....#....",
            ".#.#.............##..#.##......",
            "...#.#..............#......#...",
            ".............#.........#.....#.",
            "#.......#........#......#.....#",
            ".....#..............#.##.#.....",
            "#......##...................#..",
            "##.#.....#..........#........#.",
            "#...........##...........#.....",
            ".#...#.....#..#..##....#.......",
            ".....#.........#....##.#.......",
            "#........#......#.............#",
            ".#..................####.#.....",
            "#...#......#....##...#.#..#..#.",
            "............#.#............#...",
            "............#........#.#..###..",
            ".#..#..#..#.#.#.....#.#........",
            "#.....#..#.#...#..#..#........#",
            "#................#....#..#.....",
            "....#..#..#.#......#.#..#.....#",
            ".#..#.......#...##.#.#.....#..#",
            "#.....................#.......#",
            ".............#.......#...#.....",
            "....#......#.........###.##....",
            "....#..#.......#.#........#....",
            "....#...#....#.#....#..........",
            "...#..#......#.............#...",
            ".......###.#.........#....#.#..",
            "..#.....##.....................",
            ".#.#...........#..##....#......",
            "..........##.#....#.#..........",
            "...........#.#..#.#..#.#.......",
            "..........#..#...#.....##......",
            ".....#.........#...#.#..#......",
            "#.#................#..........#",
            "...#.....##.#..#...#.##.......#",
            ".....##...........#............",
            ".....#...#...#...#.#.....#.....",
            "...........##..................",
            ".........#................#....",
            "......#.....#.#...#.......#....",
            "...#...#........#...#...#.#.#..",
            "...............##..#....##...#.",
            "...#.#...........##.......##..#",
            "...........#............#......",
            ".#....#.#.......##.#.#.#.......",
            ".....#.#..#.#.#................",
            ".#............#...#.#..........",
            ".....#.......#.#.......#.....#.",
            "#....#...........#...#....##...",
            "..#...#..##.....#....#..#......",
            "#.#.........#..#.#..#.#......#.",
            "................#......##......",
            "#........#..............#....#.",
            "........#..#.#........#..#..#..",
            "#..........#......#............",
            "..##.......#..#.......#....#...",
            ".#........#..#..#.#.......##...",
            "................#..............",
            "#.................#...........#",
            "##..#...................#....##",
            "#..#....#.....#.#..#.#.#......#",
            "#................#.#.#...#.....",
            ".............#..#...#..##...#.#",
            "#..................#...........",
            "..............#..#.....##.....#",
            "..#...............#.#..........",
            ".....#......#....#..#...#......",
            ".#......#...##.....###.....#...",
            "...##...##.##....#.#.#..#......",
            "....#.#.......#..##....#.##....",
            "...#.........#.#.....#...#...##",
            ".##.#.........##..#.##..#......",
            ".#...#......#......#.........#.",
            ".............#.................",
            "..........#..............#.....",
            "##...........#...#...###....#..",
            "....#...............#..........",
            ".......####.....#......#.......",
            "........#..........#..#........",
            "..#.......#..#.................",
            "......#.#..##...##....#........",
            ".##...#........#...#....#...#..",
            ".......................#.......",
            ".........##..#..#...#....##...#",
            "..#..#...#.....#.........#..#..",
            ".......#....#.........#...#..#.",
            ".............#.................",
            ".....##..#.....###....##.#.....",
            "....#.#..#..#.#.....##....#..#.",
            "......#..#..............#.##..#",
            "..#..#......#.#.........#..#...",
            "..........#.#..#....#.....#....",
            ".....................#.........",
            "...#.....#.......##..#.#.......",
            ".....#...#..........###....#.#.",
            "......#.....##............#...#",
            ".......#..........#.#..#...#..#",
            "#...#..#...........#..##..#....",
            ".#......#.......##.....#..#....",
            "...#..#....#.......##......#...",
            "........#.......##...#.......#.",
            ".....#........#................",
            "......#........#....#..........",
            "...#....#....###.........#.#...",
            "##..............#......#..#.#..",
            ".........##....#........#..#.#.",
            ".......#.##.#........#........#",
            ".....###..#..#...........#....#",
            ".......#....##.......#.#...#...",
            "#..............#.#....#..#...#.",
            "#..#....#..#.#............#..#.",
            ".#...##.#..................#...",
            "...#...............##.........#",
            "###..............#.#..#.#.#....",
            ".#......#.#.....##.......#.....",
            "...#.................#.#.......",
            ".#...#....#...#..#......#...#..",
            "...##....#........#.#.#..#.....",
            "..#.....#........#....#.#......",
            "...........#.#...#.............",
            "......#.....#.....#.........#..",
            ".#.##.###...#.##.......#.......",
            ".............#....#.......#....",
            "..............#...........#....",
            ".............#..#.#.....#....#.",
            ".......#........##...##..##....",
            "..##...#............#..#......#",
            ".............#...##.....#......",
            ".#...##..##.#.........#.##...#."
        };
    }
}
