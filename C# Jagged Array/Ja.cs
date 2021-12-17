using System;
namespace Jagged
{
    class Ja
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 2, 3 },
                new int[] { 4, 5, 6, 7 }
            };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.WriteLine(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
