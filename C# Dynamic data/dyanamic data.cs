using System;

    class Demo
    {
        dynamic Data = 12;
        public int Method(int P, int Q)
        {
            return (P + Q) * Data;
        }
    }
    class dyanamic
    {
        static void Main(string[] args)
        {
            Demo Obj = new Demo();
            dynamic value1 = 10;
            dynamic value2 = 11;
            dynamic Str = "Your Result Is: ";
            Console.WriteLine(Str + Obj.Method(value1, value2));
            Console.ReadLine();
        }
    }
