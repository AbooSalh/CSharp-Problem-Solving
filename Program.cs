// See https://aka.ms/new-console-template for more information
using CSPS.Problems;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal problem = new();
        Console.WriteLine(problem.Result);

    }
}
