namespace AdventOfCode2022
{
    public class Day1CalorieCounterTask1
    {
        public static void ElfCaloriesMaxNumber()
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

            Console.WriteLine("Max Number is = " + calorieStorage.Max());
        }
    }
}
