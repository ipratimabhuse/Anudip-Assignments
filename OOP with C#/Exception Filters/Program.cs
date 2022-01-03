﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to divide 100:");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch(DivideByZeroException)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch(InvalidOperationException)
            {
                Console.Write("Invalid operation. Please tyr again.");
            }
            catch(FormatException)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch(Exception)
            {
                Console.Write("Error occurred! Please try again.");
            }
        }
    }
}
