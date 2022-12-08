namespace AdventOfCode2022
{
    public class FileInput
    {
        private const string path = "C:/advent of code 2022/Day 1/Day 1/";
        public static List<string> FileInputer(string fileName)
        {
            var listOfStrings = new List<string>();

            listOfStrings.AddRange(File.ReadLines(path + fileName));

            return listOfStrings;
        }
    }
}