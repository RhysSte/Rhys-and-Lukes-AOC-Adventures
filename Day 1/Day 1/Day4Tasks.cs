using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    internal class Day4Tasks
    {
        public static void CampCleanupTask1()
        {
            List<string> inputDay4Task1 = FileInput.FileInputer("CampCleanup.txt");

            int FH_FirstNumber;
            int FH_SecondNumber;

            int SH_FirstNumber;
            int SH_SecondNumber;

            int counter = 0;

            foreach(var line in inputDay4Task1)
            {
                List<string> splitTextComma = new List<string>(line.Split(','));
                List<string> firstHalf = new List<string>(splitTextComma[0].Split('-'));
                List<string> secondHalf = new List<string>(splitTextComma[1].Split('-'));

                FH_FirstNumber = int.Parse(firstHalf[0]);
                FH_SecondNumber = int.Parse(firstHalf[1]);

                SH_FirstNumber = int.Parse(secondHalf[0]);
                SH_SecondNumber = int.Parse(secondHalf[1]);

           
                if (FH_FirstNumber <= SH_FirstNumber && FH_SecondNumber >= SH_SecondNumber || SH_FirstNumber <= FH_FirstNumber && SH_SecondNumber >= FH_SecondNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        public static void CampCleanupTask2()
        {
            List<string> inputDay4Task2 = FileInput.FileInputer("CampCleanup.txt");

            int FH_FirstNumber;
            int FH_SecondNumber;

            int SH_FirstNumber;
            int SH_SecondNumber;

            int counter = 0;

            foreach (var line in inputDay4Task2)
            {
                List<string> splitTextComma = new List<string>(line.Split(','));
                List<string> firstHalf = new List<string>(splitTextComma[0].Split('-'));
                List<string> secondHalf = new List<string>(splitTextComma[1].Split('-'));

                FH_FirstNumber = int.Parse(firstHalf[0]);
                FH_SecondNumber = int.Parse(firstHalf[1]);

                SH_FirstNumber = int.Parse(secondHalf[0]);
                SH_SecondNumber = int.Parse(secondHalf[1]);

                if(FH_FirstNumber <= SH_FirstNumber && FH_SecondNumber >= SH_FirstNumber || SH_FirstNumber <= FH_FirstNumber && SH_SecondNumber >= FH_FirstNumber)
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
