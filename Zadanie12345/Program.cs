using System;

namespace MathOperations
{

    public delegate int MathOperation(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("Dodawanie: " + PerformOperation(a, b, Add));
            Console.WriteLine("Odejmowanie: " + PerformOperation(a, b, Subtract));
            Console.WriteLine("Mnożenie: " + PerformOperation(a, b, Multiply));
            Console.WriteLine("Dzielenie: " + PerformOperation(a, b, Divide));
        }


        public static int PerformOperation(int a, int b, MathOperation operation)
        {
            return operation(a, b);
        }


        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => b != 0 ? a / b : 0;
    }
}

//zadanie2

  
    public delegate bool FilterCondition(int number);

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 12, -4, 15, 20, 0, -8, 10 };

        var evenNumbers = FilterNumbers(numbers, IsEven);
        Console.WriteLine("Liczby parzyste: " + string.Join(", ", evenNumbers));

        var greaterThanTen = FilterNumbers(numbers, IsGreaterThanTen);
        Console.WriteLine("Liczby większe od 10: " + string.Join(", ", greaterThanTen));

        var lessThanZero = FilterNumbers(numbers, IsLessThanZero);
        Console.WriteLine("Liczby mniejsze niż 0: " + string.Join(", ", lessThanZero));
    }

   
    public static List<int> FilterNumbers(List<int> numbers, FilterCondition condition)
    {
        return numbers.Where(n => condition(n)).ToList();
    }

 
    public static bool IsEven(int number) => number % 2 == 0;
    public static bool IsGreaterThanTen(int number) => number > 10;
    public static bool IsLessThanZero(int number) => number < 0;
}

//zadanie 3 jest w innej klasie!!