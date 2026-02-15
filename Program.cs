// See https://aka.ms/new-console-template for more information
using CSPS.Problems;

public class Program
{
    public static void Main(string[] args)
    {
        How_Many_Numbers_Are_Smaller_Than_the_Current_Number problem = new();
        Console.WriteLine(problem.Result);
    }
}
