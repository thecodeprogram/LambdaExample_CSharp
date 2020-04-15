using System;
using System.Collections.Generic;

namespace Lambda_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNumbers = new List<int>() { 1, 2, 7, 11, 24, 77, 33, 93 };
            OddEven_Numbers _oddEvenNumbers = new OddEven_Numbers(lstNumbers);

            Console.WriteLine("------------------------------------------");

            UserDefined userDefined = new UserDefined();

            Console.ReadLine();
        }
    }
}
