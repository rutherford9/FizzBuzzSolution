using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolution
{
    class Fizzbuzzlogic
    {
        public void DoesFizzBuzz()
        {

            //fizzbuzz is a popular question based off of a childrens game to be asked to potential programming
            //hires, usually to display a basic grasp of programming. The idea is that anyone who has been programming a while
            //can solve it within a few a minutes. 
            //the requirements are to print all numbers from 1 - 100, but numbers divisible by 3 are replaced with fizz,
            //numbers divisible by 5 are replaced with buzz, and numbers divisible by both are replaced with fizzbuzz,
            //hence the name of the game. 

            //use an array
            int[] myArray = new int[101];

            //for loop with if else statement, a switch case can be used interchangeably
            //modulus is used for the division aspect
            for (int i = 1; i < myArray.Length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
