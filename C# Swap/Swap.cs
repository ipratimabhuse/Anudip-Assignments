using System;
class Swap
{
    static void Main(string[] args)
    {
        int x, y, temp;
        Console.Write("\nInput the First Number : ");
        x = int.Parse(Console.ReadLine());
        Console.Write("\nInput the Second Number : ");
        y = int.Parse(Console.ReadLine());
        temp = x;
        x = y;
        y = temp;
        Console.Write("After Swap :");
        Console.Write("\nInput the First Number :" +x);
        Console.Write("\nInput the Second Number :" +y);
        Console.Read();
    }
}

