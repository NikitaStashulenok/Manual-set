using System;

namespace My_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var set1 = new SuperSet<int>(new int[] { 1, 2, 3, 4, 5 });
            var set2 = new SuperSet<int>(new int[] { 4, 5, 6, 7, 8 });
            var set3 = new SuperSet<int>(new int[] { 2, 3, 4 });

            Console.Write("Union: ");
            foreach(var item in set1.Union(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Intersection: ");
            foreach (var item in set1.Intersection(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Difference A \\ B: ");
            foreach (var item in set1.Difference(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Difference B \\ A: ");
            foreach (var item in set2.Difference(set1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("A Subset C: ");
            Console.WriteLine(set1.Subset(set3));
            Console.WriteLine();

            Console.Write("C Subset A: ");
            Console.WriteLine(set3.Subset(set1));
            Console.WriteLine();

            Console.Write("C Subset B: ");
            Console.WriteLine(set3.Subset(set2));
            Console.WriteLine();

            Console.Write("Symetric Difference: ");
            foreach (var item in set1.SymetricDifference(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
