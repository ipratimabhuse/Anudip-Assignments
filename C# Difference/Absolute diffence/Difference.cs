using System;
namespace Difference
{
    class Difference
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(53));
            Console.WriteLine(test(30));
            Console.WriteLine(test(51));
            Console.ReadLine();
        }
        static int test(int n)
        {
            const int x = 51;
            if (n > x)
            {
                return (n - x) * 3;
            }
            return (x - n);
        }
            
    }
}
