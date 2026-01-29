using System;
using System.Linq;

public class SimpleArraySum
{
    public static void Run()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(arr.Sum());
    }
}