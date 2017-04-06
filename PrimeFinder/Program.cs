using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which prime number are you looking for?");
            int prime = tryInt(Console.ReadLine());
            int primeCounter = 0;
            int lastPrime = 2;
            for (int i = 2; primeCounter < prime; i++)
            {
                if (isPrime(i))
                {
                    primeCounter++;
                }
                lastPrime = i;
            }
            Console.WriteLine("The number " + prime + " prime is: " + lastPrime);
            Console.ReadLine();
        }

        public static bool isPrime(int i)
        {
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int tryInt(string number)
        {
            bool runLoop = true;
            int myInt = 0;
            while (runLoop)
            {
                runLoop = false;
                try
                {
                    myInt = int.Parse(number);
                    if (myInt < 1)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number!");
                    runLoop = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter a number greater than 1!");
                    runLoop = true;
                }
            }
            return myInt;
        }
    }
}
