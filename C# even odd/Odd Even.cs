using System;
    class Even_Odd
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("\nEnter the number : ");
        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("It is even number");
        }
        else
        {
            Console.WriteLine("It is odd number");
        }
    }

}
