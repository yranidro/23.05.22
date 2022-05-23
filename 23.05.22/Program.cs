using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задания 1 или 2...");
            int ex = int.Parse(Console.ReadLine());
            switch (ex)
            {
                case 1:
                    Console.WriteLine("Введите количество символов...");
                    int count = int.Parse(Console.ReadLine());
                    char[] array = new char[count];

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"Введите {++i}-й элемент..."); i--;
                        array[i] = char.Parse(Console.ReadLine());
                    }
                    PrintString(array, count);
                    break;

                case 2:
                    int[] arr = new int[5];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"Введите {++i}-й элемент..."); i--;
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Введите число, которое хотите найти...");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Подошел элемент под номером: " + Search(arr, x));
                    break;
            }
        }

        static void PrintString(char []array, int count)
        {
            for (int i = 0; i < count; i++)
                Console.Write(array[i] + " ");
        }

        static int Search(int []arr, int x)
        {
            int result = 0;
            for(int i = 0; i < arr.Length && result == 0; i++)
            {
                if (arr[i] == x)
                    result = i;
            }
            return ++result;
        }
    }
}