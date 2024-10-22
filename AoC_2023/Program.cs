using AoC_2023;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }

    public Program()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Starting the AdventOfCode program ...");
        Console.ResetColor();
        
        string path = "C:\\Users\\Lukas\\RiderProjects\\AdventOfCode\\AoC_2023\\Input\\2023_09.txt";
        AoCFile.AoCFile aocFile = new AoCFile.AoCFile(path);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Loading input ...");
        Console.WriteLine("    {0}", path);
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Starting todays program ...");
        Console.ResetColor();
        
        //TODO - Change every day
        Day09MirageMaintance d = new Day09MirageMaintance(aocFile.getAoCFile());
    }
}