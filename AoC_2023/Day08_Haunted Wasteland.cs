using System.Collections;

namespace AoC_2023;

public class Day08HauntedWasteland
{
    private string instructions;
    private char currentInstruction;
    private int instructionCounter;
    private string position = "AAA";
    private ArrayList position2 = new ArrayList();
    private int line;
    private ArrayList line2 = new ArrayList();
    private int stepCounter;
    private bool reachedEnd;
    
    public Day08HauntedWasteland(ArrayList input)
    {
        Task2(input);
    }
    
    private void IncreaseCounter()
    {
        if (instructionCounter < instructions.Length - 1)
        {
            instructionCounter++;
        }
        else instructionCounter = 0;
    }

    private void Task1(ArrayList input)
    {
        instructions = input[0].ToString();

        while (!reachedEnd)
        {
            // Go to position
            for (int i = 1; i < input.Count - 2; i++)
            {
                if (input[i + 2].ToString().Substring(0, 3) == position)
                {
                    line = i + 2;
                }
            }
            // Check next instruction, set currentInstruction and increase counter using IncreaseCounter()
            currentInstruction = instructions[instructionCounter];
            IncreaseCounter();
            // Change position to new position based on currentInstruction
            if (currentInstruction == 'L')
            {
                position = input[line].ToString().Substring(7, 3);
            }
            else if(currentInstruction == 'R')
            {
                position = input[line].ToString().Substring(12, 3);
            }
            // Increase stepCounter
            stepCounter++;
            // Check if position == "ZZZ"; if true print(stepCounter) and exit
            if (position == "ZZZ")
            {
                reachedEnd = true;
                Console.Write("I reached position \"ZZZ\" in ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(stepCounter);
                Console.ResetColor();
                Console.WriteLine(" steps");
            }
        }
    }

    private void Task2(ArrayList input)
    {
        instructions = input[0].ToString();
        
        // TODO - Set all starting positions (..A) in position2
        for (int i = 0; i < input.Count - 2; i++)
        {
            if (input[i + 2].ToString().Substring(2, 1) == "A")
            {
                line2.Add(i + 2);
                position2.Add(input[i + 2].ToString().Substring(0, 3));
            }
        }
        // TODO - Apply currentInstruction for all in position2 and overwrite position2 with new ArrayLists
        currentInstruction = instructions[instructionCounter];
        while (!reachedEnd)
        {
            ArrayList tempPosition = new ArrayList();
            ArrayList tempLine = new ArrayList();

            for (int i = 0; i < position2.Count; i++)
            {
                if (currentInstruction == 'L')
                {
                    tempPosition.Add(input[(int)line2[i]].ToString().Substring(7, 3));
                    for (int j = 0; j < input.Count - 2; j++)
                    {
                        if (input[j + 2].ToString().Substring(0, 3) == tempPosition[i].ToString())
                        {
                            tempLine.Add(j + 2);
                        }
                    }
                }
                else if (currentInstruction == 'R')
                {
                    tempPosition.Add(input[(int)line2[i]].ToString().Substring(12, 3));
                    for (int j = 0; j < input.Count - 2; j++)
                    {
                        if (input[j + 2].ToString().Substring(0, 3) == tempPosition[i].ToString())
                        {
                            tempLine.Add(j + 2);
                        }
                    }
                }
            }
            line2 = tempLine;
            position2 = tempPosition;
            // TODO - Increase current Instruction
            IncreaseCounter();
            currentInstruction = instructions[instructionCounter];
            // TODO - Check all position2 if finished (..Z)
            int counterZ = 0;
            for (int i = 0; i < position2.Count; i++)
            {
                if (position2[i].ToString().Substring(2, 1) == "Z")
                {
                    counterZ++;
                }
            }
            stepCounter++;
            if (counterZ == position2.Count)
            {
                reachedEnd = true;
                Console.Write("I reached positions with \"..Z\" in ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(stepCounter);
                Console.ResetColor();
                Console.WriteLine(" steps");
            }
            Console.WriteLine(stepCounter);
        }
    }
}