﻿using System;
using System.Diagnostics;
using System.Linq;
using Permutate;

namespace PermutateConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var permutator = new PermutatorOriginal();
            var permutatorLinq = new Permutator();
            // var list = permutator.GetPermutations(permutator.Alphabet, 6);
            var list = permutatorLinq.GetPermutations(Permutator.Alphabet, 3);
            // foreach (var permutate in list)
            // {
            //     Console.WriteLine(permutate);
            // }

            stopWatch.Stop();
            Console.WriteLine(list.Count());
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}