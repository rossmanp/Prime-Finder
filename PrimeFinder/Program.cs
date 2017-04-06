using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pete Rossman
//April 6, 2017
namespace PrimeFinder
{
    //This program asks the user which prime number he or she wants to find,
    //and then outputs it.
    class Program
    {
        static void Main(string[] args)
        {
            int prime = tryInt();
            int primeCounter = 0;
            int lastPrime = 2;

            //This loop adds 1 to the primeCounter every time isPrime(i) is true,
            //or in other words, a number is proven to be prime. The loop runs until
            //the primeCounter equals the user inputted value.

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

        //isPrime runs through every possible factor of a number. If none divide evenly into
        //the passed value, true is passed, in turn increasing the prime counter.
        //If at any time a number divides evenly into the passed value, false is returned.

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

        //tryInt confirms the user entered a valid input.

        public static int tryInt()
        {
            bool runLoop = true;
            int myInt = 0;
            while (runLoop)
            {
                runLoop = false;
                Console.WriteLine("Which prime number are you looking for?");
                try
                {
                    myInt = int.Parse(Console.ReadLine());
                    if (myInt < 2)
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
