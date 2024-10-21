using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberMapping
{
    // Definicja delegata
    public delegate int Transform(int number);

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squared = Map(numbers, Square);
            Console.WriteLine("Kwadraty: " + string.Join(", ", squared));

            var doubled = Map(numbers, Double);
            Console.WriteLine("Podwojone: " + string.Join(", ", doubled));

            var decremented = Map(numbers, Decrement);
            Console.WriteLine("Odejmowanie 1: " + string.Join(", ", decremented));
        }

        // Funkcja mapująca
        public static List<int> Map(List<int> numbers, Transform transform)
        {
            return numbers.Select(n => transform(n)).ToList();
        }

        // Transformacje
        public static int Square(int number) => number * number;
        public static int Double(int number) => number * 2;
        public static int Decrement(int number) => number - 1;
    }
}
