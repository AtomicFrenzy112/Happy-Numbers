using System;
using System.Collections.Generic;
using System.Linq;

namespace Happy_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A happy number is defined by the following process:
            Starting with any positive integer, replace the number
            by the sum of the squares of its digits, and repeat the
            process until the number equals 1 (where it will stay), 
            or it loops endlessly in a cycle which does not include 1. 
            Those numbers for which this process ends in 1 are happy
            numbers, while those that do not end in 1 are unhappy
            numbers. 

            Find the first eight happy numbers.*/
            
            int counter = 0;
            int attempts = 50;
            int sum = 0;

           
            
            
            string output = "";
            for(int i = 1; counter <= 8; i++)
            {
                sum = i;

                int squareSum = sum;
                for (int s = 0; s < attempts ; s++)
                {


                    int[] digits = sum.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();

                    squareSum = 0;
                    for (int k = 0; k<= digits.Length; k++)
                    {
                        squareSum = squareSum + (digits[k] * digits[k]);
                        

                    }
                    

                    sum = squareSum;
                    if(sum == 1)
                    {
                        Console.WriteLine(i);
                        s = attempts;
                    }

                }

                
            }
            Console.WriteLine(output);
        }
    }
}
