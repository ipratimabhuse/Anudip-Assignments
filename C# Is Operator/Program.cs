using System;

class One { }
class Two { }

public class Demo
{
    public static void Test(object obj)
    {
        One P;
        Two Q;

        if (obj is One)
        {
            Console.WriteLine("Class One");

            P = (One)obj;
        }

        else if (obj is Two)
        {
            Console.WriteLine("Class Two");

            Q = (Two)obj;
        }

        else
        {
            Console.WriteLine("None of the classes!");
        }

    }

    public static void Main()
    {
        One o1 = new One();
        Two t1 = new Two();
        Test(o1);
        Test(t1);
        Test("str");
        Console.ReadKey();
    }
}
