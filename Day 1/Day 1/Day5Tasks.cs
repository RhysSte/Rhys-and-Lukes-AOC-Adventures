using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day5Tasks
    {
        public static void SupplyStacks()
        {
            // File Loader
            List<string> inputDay5Task1 = FileInput.FileInputer("SupplyStacks.txt");

            // Removal of the first 11 lines which include the current state of lines
            inputDay5Task1.RemoveRange(0, 10);

            // Creating lists to act as the lines
            List<char> line1 = new List<char>();
            List<char> line2 = new List<char>();
            List<char> line3 = new List<char>();
            List<char> line4 = new List<char>();
            List<char> line5 = new List<char>();
            List<char> line6 = new List<char>();
            List<char> line7 = new List<char>();
            List<char> line8 = new List<char>();
            List<char> line9 = new List<char>();

            // Loading the data into the lines (HardCoded but idc)
            line1.Add('W');
            line1.Add('B');
            line1.Add('D');
            line1.Add('N');
            line1.Add('C');
            line1.Add('F');
            line1.Add('J');

            line2.Add('P');
            line2.Add('Z');
            line2.Add('V');
            line2.Add('Q');
            line2.Add('L');
            line2.Add('S');
            line2.Add('T');

            line3.Add('P');
            line3.Add('Z');
            line3.Add('B');
            line3.Add('G');
            line3.Add('J');
            line3.Add('T');

            line4.Add('D');
            line4.Add('T');
            line4.Add('L');
            line4.Add('J');
            line4.Add('Z');
            line4.Add('B');
            line4.Add('H');
            line4.Add('C');

            line5.Add('G');
            line5.Add('V');
            line5.Add('B');
            line5.Add('J');
            line5.Add('S');

            line6.Add('P');
            line6.Add('S');
            line6.Add('Q');

            line7.Add('B');
            line7.Add('V');
            line7.Add('D');
            line7.Add('F');
            line7.Add('L');
            line7.Add('M');
            line7.Add('P');
            line7.Add('N');

            line8.Add('P');
            line8.Add('S');
            line8.Add('M');
            line8.Add('F');
            line8.Add('B');
            line8.Add('D');
            line8.Add('L');
            line8.Add('R');

            line9.Add('V');
            line9.Add('D');
            line9.Add('T');
            line9.Add('R');

            // Lists that will hold the instructions 
            List<int> stacksToMove = new List<int>();
            List<int> lineMovingFrom = new List<int>();
            List<int> lineMovingTo = new List<int>();

            // Foreach loop that will go through the instruction lines and sort them into their retrospective list
            foreach(var line in inputDay5Task1)
            {
                List<string> instructionSplit = new List<string>(line.Split(' '));

                var stacks = instructionSplit[1];
                var oldList = instructionSplit[3];
                var newList = instructionSplit[5];

                stacksToMove.Add(int.Parse(stacks));
                lineMovingFrom.Add(int.Parse(oldList));
                lineMovingTo.Add(int.Parse(newList));
            }

            // Counter representing my amount of brain cells
            int counter = 0;

            // Digusting foreach loop which acts like the doonkey worker for this entire program
            // Firstly it checks to see what line is being moved from and copys that list into a temp list 
            // Then it removes the stacks/crates from the line list 
            // Then removes the irrelevant stacks/crates from the stacksInMotion list 
            // Then it adds the contents from the stacksInMotion into the 'moving to' line
            // Then it increases the counter by one because I said so
            foreach(int stackCount in stacksToMove)
            {
                // Temporary list to hold what stacks have been moved
                List<char> stacksInMotion = new List<char>();

                // Temporary string to figure out what lines are being used
                var lineMovingToString = $"line{lineMovingTo[counter]}";
                var lineMovingFromString = $"line{lineMovingFrom[counter]}";
                
                // The first of many if statemenets 
                if(lineMovingFromString == "line1")
                {
                    // You already know what this does, dont ask me again
                    stacksInMotion.AddRange(line1);
                    // Line count gets the count of lines in the line count line
                    var lineCount = line1.Count();
                    // Remove the range before it infects the locals
                    line1.RemoveRange(lineCount - stackCount, stackCount);
                    // Hips in motion never lie
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);  
                };
                if (lineMovingFromString == "line2")
                {
                    stacksInMotion.AddRange(line2);
                    var lineCount = line2.Count();
                    line2.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };
                if (lineMovingFromString == "line3")
                {
                    stacksInMotion.AddRange(line3);
                    var lineCount = line3.Count();
                    line3.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };
                if (lineMovingFromString == "line4")
                {
                    stacksInMotion.AddRange(line4);
                    var lineCount = line4.Count();
                    line4.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };
                if (lineMovingFromString == "line5")
                {
                    stacksInMotion.AddRange(line5);
                    var lineCount = line5.Count();
                    line5.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };
                if (lineMovingFromString == "line6")
                {
                    stacksInMotion.AddRange(line6);
                    var lineCount = line6.Count();
                    line6.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };
                if (lineMovingFromString == "line7")
                {
                    stacksInMotion.AddRange(line7);
                    var lineCount = line7.Count();
                    line7.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };
                if (lineMovingFromString == "line8")
                {
                    stacksInMotion.AddRange(line8);
                    var lineCount = line8.Count();
                    line8.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };
                if (lineMovingFromString == "line9")
                {
                    stacksInMotion.AddRange(line9);
                    var lineCount = line9.Count();
                    line9.RemoveRange(lineCount - stackCount, stackCount);
                    stacksInMotion.RemoveRange(0, lineCount - stackCount);
                };

                // The most exciting bit that you're ever going to see
                if (lineMovingToString == "line1")
                {
                    // Add the range before the locals get sick
                    line1.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line2")
                {
                    line2.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line3")
                {
                    line3.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line4")
                {
                    line4.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line5")
                {
                    line5.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line6")
                {
                    line6.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line7")
                {
                    line7.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line8")
                {
                    line8.AddRange(stacksInMotion);
                }
                if (lineMovingToString == "line9")
                {
                    line9.AddRange(stacksInMotion);
                }

                // Counter increases because it wants to. Don't like it? Tough shit.
                counter++;
            }

            // This becomes important later
            int line1length = line1.Count();
            int line2length = line2.Count();
            int line3length = line3.Count();
            int line4length = line4.Count();
            int line5length = line5.Count();
            int line6length = line6.Count();
            int line7length = line7.Count();
            int line8length = line8.Count();
            int line9length = line9.Count();

            // It is imporantant here. I remove one from each int because I want to
            Console.WriteLine(line1[line1length - 1]);
            Console.WriteLine(line2[line2length - 1]);
            Console.WriteLine(line3[line3length - 1]);
            Console.WriteLine(line4[line4length - 1]);
            Console.WriteLine(line5[line5length - 1]);
            Console.WriteLine(line6[line6length - 1]);
            Console.WriteLine(line7[line7length - 1]);
            Console.WriteLine(line8[line8length - 1]);
            Console.WriteLine(line9[line9length - 1]);
        }
    }
}
