public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }

    public Program()
    {
        string path = "C:\\Users\\Lukas\\RiderProjects\\AdventOfCode\\AoC_2023\\Input\\2023_01_1.txt";
        AoCFile.AoCFile aocFile = new AoCFile.AoCFile(path);
    }
}