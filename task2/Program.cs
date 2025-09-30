using System;
using System.Numerics;

namespace Task2
{
    public class Program
    {
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }
            return numbers;
        }

        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)

            { sum += number; }
            return sum;

        }
        public static double GetAverage(int[] numbers)
        {
            int avarage = GetSum(numbers)/numbers.Length;
            return avarage;
        }

        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int number in numbers)
            {
                if(number < min) min = number;
            }
            return min;
        }

        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max) max = number;
            }
            return max;
        }

        static void Main()
        {
            int[] array = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Масив: " + string.Join(", ", array));
            Console.WriteLine("Сума: " + GetSum(array));
            Console.WriteLine("Середнє: " + GetAverage(array));
            Console.WriteLine("Мінімум: " + GetMin(array));
            Console.WriteLine("Максимум: " + GetMax(array));
        }

    }
}
