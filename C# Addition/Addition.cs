using System;
class Addition
{
    static void Main(string[] args)
    {
        int x, y;
        Console.Write("\nInput the First Number : ");
        x = int.Parse(Console.ReadLine());
        Console.Write("\nInput the Second Number : ");
        y = int.Parse(Console.ReadLine());
        int result = x + y;
        Console.Write(result);
        Console.Read();

    }
   
}
