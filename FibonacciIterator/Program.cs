using System;
using System.Collections.Generic;

namespace FibonacciIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int fib in Fibs(40))
                Console.WriteLine(fib + " ");
        }

        static IEnumerable<int> Fibs(int fibCount)
        {
            for(int i=0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }
    }

    
}
