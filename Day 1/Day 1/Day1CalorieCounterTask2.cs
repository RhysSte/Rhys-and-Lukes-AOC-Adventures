using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day1CalorieCounterTask2
    {
        public static void ElfCaloriesTop3()
        {
            int number = 0;
            List<int> calorieStorage = new List<int>();
            List<string> inputDay1 = FileInput.FileInputer("ElfCalorieCounter.txt");

            foreach (string line in inputDay1)
            {
                if (line == string.Empty)
                {
                    calorieStorage.Add(number);
                    number = 0;
                }
                else
                {
                    number = number + int.Parse(line);
                }
            }

            //Console.WriteLine("Max Number is = " + calorieStorage.Max());

            calorieStorage.Sort();

            int totalTop3 = calorieStorage.OrderByDescending(x => x).Take(3).Sum();

            foreach (int i in calorieStorage)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Total for top 3 " + totalTop3);
        }
    }
}
