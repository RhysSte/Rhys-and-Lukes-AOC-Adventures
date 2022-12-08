using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day3Tasks
    {
        public static void Rucksack()
        {
            List<string> inputDay3 = FileInput.FileInputer("Rucksack.txt");
            var counter = 0;
            

            foreach (string line in inputDay3)
            {
                List<char> items = new List<char>();
                string firstHalf = line.Substring(0, line.Length / 2);
                string secondHalf = line.Substring(line.Length / 2);
                
                foreach (var chars in firstHalf)
                {
                    foreach (var chars2 in secondHalf)
                    {
                        if (chars == chars2)
                        {
                            items.Add(chars);
                        }
                    }
                }
                var itemList = items.Distinct().ToList();
                foreach(var item in itemList)
                {
                   
                    var value = NumFromLetter.NumFromLetters(item);
                    counter = counter + value;
                }
            }
            Console.WriteLine(counter);
        }
       
        public static void RucksackTask2()
        {
            List<string> inputDay3Task2 = FileInput.FileInputer("Rucksack.txt");
            var counter = 0;
            var groupTotal = inputDay3Task2.Count() / 3;
            
            var line1Index = 0;
            var line2Index = 1;
            var line3Index = 2;

            List<char> items = new List<char>();
            while (groupTotal > 0)
            {
                var badge = new List<char>();
                var line1 = inputDay3Task2[line1Index];
                var line2 = inputDay3Task2[line2Index];
                var line3 = inputDay3Task2[line3Index];
                foreach (char charL in line1)
                {
                    foreach (char char2L in line2)
                    {
                        foreach (char char3L in line3)
                        {
                            if (charL == char2L && charL == char3L && char3L == char2L)
                            {
                                badge.Add(charL);
                            }
                        }
                    }
                }

                var badgeList = badge.Distinct().ToList();

                items.Add(badgeList[0]);

                line1Index = line1Index + 3;
                line2Index = line2Index + 3;
                line3Index = line3Index + 3;
                groupTotal = groupTotal - 1;
            }
            foreach (var item in items)
            {
                var value = NumFromLetter.NumFromLetters(item);
                counter = counter + value;
            }
            Console.WriteLine(counter);
        }
    }
}
