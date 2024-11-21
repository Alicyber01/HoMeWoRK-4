using System;

namespace homework_4;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];
        Random rand = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 31);
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Введите индекс первого числа (от 0 до 19):");
        int firstIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите индекс второго числа (от 0 до 19):");
        int secondIndex = int.Parse(Console.ReadLine());

        if (firstIndex >= 0 && firstIndex < numbers.Length && secondIndex >= 0 && secondIndex < numbers.Length)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;

            Console.WriteLine("\nМассив после обмена:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: индексы выходят за пределы массива.");
        }
    }
}
