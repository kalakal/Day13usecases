
using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_MaximumOfThree
{
    public class MaximumNumber
    {
        public static int MaximumIntNum(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)

            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }


        public static Double MaximumIntNum(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)

            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }

        public static string MaximumIntNum(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)

            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }

    }
}



//Program.cs

namespace UC1_MaximumOfThree
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Find Max number");
            int output = MaximumNumber.MaximumIntNum(52, 15, 50);
            Console.WriteLine(output);
            double output1 = MaximumNumber.MaximumIntNum(47.5, 45.2, 12.5);
            Console.WriteLine(output1);
            string output2 = MaximumNumber.MaximumIntNum("abc", "def", "uvw");
            Console.WriteLine(output2);

        }
    }
}


