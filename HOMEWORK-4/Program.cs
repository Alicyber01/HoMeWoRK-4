using System;

namespace Tumakov_Laboratory5;

class Program
{
    static void Main()
    {
        EXERCISE1();
        EXERCISE2();
        EXERCISE3();
        EXERCISE4();
        EXERCISE5();
    }
    // Упражнение 5.1. Написать метод, возвращающий наибольшее из двух чисел. Входные
    //параметры метода – два целых числа.Протестировать метод.
    static void EXERCISE1()
    {
        Console.WriteLine("Введите первое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"Наибольшее число: {a}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число: {b}");
        }
        Console.WriteLine();
    }

    // Упражнение 5.2. Написать метод, который меняет местами значения двух передаваемых
    //параметров.Параметры передавать по ссылке.Протестировать метод.
    static void EXERCISE2()
    {
        Console.WriteLine("Введите первое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"До обмена: a = {a}, b = {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"После обмена: a = {a}, b = {b}");
        Console.WriteLine();
    }

    // Упражнение 5.3. Написать метод вычисления факториала числа, результат вычислений
    // передавать в выходном параметре.Если метод отработал успешно, то вернуть значение true;
    //если в процессе вычисления возникло переполнение, то вернуть значение false. Для
    //отслеживания переполнения значения использовать блок checked.
    static void EXERCISE3()
    {
        Console.WriteLine("Введите число для вычисления факториала:");
        int number = int.Parse(Console.ReadLine());

        long result = 1;

        if (number < 0)
        {
            Console.WriteLine("Ошибка: факториал отрицательного числа не существует.");
            return;
        }

        try
        {
            checked
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                Console.WriteLine($"Факториал числа {number} равен {result}");
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: переполнение при вычислении факториала.");
        }
        Console.WriteLine();
    }

    // Упражнение 5.4. Написать рекурсивный метод вычисления факториала числа.
    static long RecFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * RecFactorial(n - 1);
        }
    }

    // Упражнение 5.5.Написать метод, который вычисляет НОД двух натуральных чисел
    //(алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех
    //натуральных чисел.
    //НОД для двух чисел
    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int NOD(int a, int b, int c)
    {
        int result = NOD(a, b);
        return NOD(result, c);
    }
    static void EXERCISE4()
    {
        Console.WriteLine("Введите два или три числа для вычисления НОД:");
        Console.WriteLine("Введите первое число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число (если нужно, или нажмите Enter):");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine($"НОД для чисел {num1} и {num2} равен {NOD(num1, num2)}");
        }
        else
        {
            int num3 = int.Parse(input);
            Console.WriteLine($"НОД для чисел {num1}, {num2} и {num3} равен {NOD(num1, num2, num3)}");
        }
        Console.WriteLine();
    }

    // 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа
    //ряда Фибоначчи.Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
    //13... Для таких чисел верно соотношение Fk = Fk - 1 + Fk - 2.
    static void EXERCISE5()
    {
        Console.WriteLine("Введите номер числа Фибоначчи:");
        int n = int.Parse(Console.ReadLine());
        int result = Fibonacci(n);
        Console.WriteLine($"Число Фибоначчи с номером {n} равно {result}");
        Console.WriteLine();
    }

    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }



}