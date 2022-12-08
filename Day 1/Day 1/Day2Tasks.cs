using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day2Tasks
    {
        public static void RockPaperScissorsPt1()
        {
            var score = 0;
            var result = 0;

            List<string> inputDay2 = FileInput.FileInputer("RockPaperScissors.txt");

            foreach (string round in inputDay2)
            {
                switch (round)
                {
                    case "A X":
                        score = 1 + 3; break;
                    case "A Y":
                        score = 6 + 2; break;
                    case "A Z":
                        score = 0 + 3; break;
                    case "B X":
                        score = 0 + 1; break;
                    case "B Y":
                        score = 3 + 2; break;
                    case "B Z":
                        score = 6 + 3; break;
                    case "C X":
                        score = 6 + 1; break;
                    case "C Y":
                        score = 0 + 2; break;
                    case "C Z":
                        score = 3 + 3; break;
                }
                result = result + score;
            }
            Console.WriteLine(result);
        }

        public static void RockPaperScissorsPt2()
        {
            var score = 0;
            var result = 0;

            List<string> inputDay2 = FileInput.FileInputer("RockPaperScissors.txt");

            foreach (string round in inputDay2)
            {
                switch (round)
                {
                    case "A X":
                        score = 3 + 0; break;
                    case "A Y":
                        score = 1 + 3; break;
                    case "A Z":
                        score = 2 + 6; break;
                    case "B X":
                        score = 1 + 0; break;
                    case "B Y":
                        score = 2 + 3; break;
                    case "B Z":
                        score = 3 + 6; break;
                    case "C X":
                        score = 2 + 0; break;
                    case "C Y":
                        score = 3 + 3; break;
                    case "C Z":
                        score = 1 + 6; break;
                }
                result = result + score;
            }
            Console.WriteLine(result);
        }
    }
}
