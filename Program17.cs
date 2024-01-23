using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_Вариант_17
{
    internal class Program
    {
        static void Main (string[] args)
        {
            try
            {

                int count = 0, choice1, sum = 0;
                Random rnd = new Random();
                Console.Write("Введите количество строк в массиве: ");
                int M = int.Parse(Console.ReadLine());
                if (M > 1)
                {
                    Console.Write("Введите количество столбцов в массиве: ");
                    int N = int.Parse(Console.ReadLine());
                    if (N > 1)
                    {
                        int[,] array = new int[M, N];
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                array[i, j] = rnd.Next(-99, 100);
                                Console.Write($"{array[i, j],3} ");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Введите 1, если нужно искать в строке, введите 2, если нужно искать в стобце: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.Write($"Введите номер строки, в которой нужно искать от 0 до {M-1}: ");
                                choice1 = int.Parse(Console.ReadLine());
                                if (choice1 >= 0 && choice1 < M)
                                {
                                    int[] array1 = new int[array.GetLength(1)];
                                    Console.Write("Введите значение a: ");
                                    int a = int.Parse(Console.ReadLine());
                                    Console.Write("Введите значение b: ");
                                    int b = int.Parse(Console.ReadLine());
                                    for (int j = 0; j < array.GetLength(1); j++)
                                    {
                                        array1[j] = array[choice1, j];
                                    }
                                    int aposition = Array.IndexOf(array1, a);
                                    int bposition = Array.IndexOf(array1, b);
                                    if (bposition > aposition)
                                    {
                                        if (!(aposition == -1 || bposition == -1))
                                        {
                                            count = bposition - aposition - 1;
                                            Console.WriteLine($"Между элементами {a} и {b} находится {count} элемента(-ов).");
                                        }
                                        else
                                            Console.WriteLine("Какой-то из элементов строки не был найден в массиве.");
                                    }
                                    else
                                    {
                                        if (!(aposition == -1 || bposition == -1))
                                        {
                                            count = aposition - bposition - 1;
                                            Console.WriteLine($"Между элементами {a} и {b} находится {count} элемента(-ов).");
                                        }
                                        else
                                            Console.WriteLine("Какой-то из элементов строки не был найден в массиве.");
                                    }
                                    for (int i = 0; i < array1.Length; i++)
                                    {
                                        if (array1[i] % 2 != 0 && array1[i] > 0)
                                            sum += array1[i];
                                    }
                                    Console.WriteLine($"Сумма положительных нечетных элементов в данной строке = {sum}");
                                }
                                else
                                    Console.WriteLine("Неверный номер строки.");
                                break;
                            case 2:
                                int[] array2 = new int[array.GetLength(0)];
                                Console.Write($"Введите номер столбца, в котором нужно искать от 0 до {N-1}: ");
                                choice1 = int.Parse(Console.ReadLine());
                                if (choice1 >= 0 && choice1 < N)
                                {
                                    Console.Write("Введите значение a: ");
                                    int a = int.Parse(Console.ReadLine());
                                    Console.Write("Введите значение b: ");
                                    int b = int.Parse(Console.ReadLine());
                                    for (int j = 0; j < array.GetLength(0); j++)
                                    {
                                        array2[j] = array[j, choice1];
                                    }
                                    int aposition = Array.IndexOf(array2, a);
                                    int bposition = Array.IndexOf(array2, b);
                                    if (bposition > aposition)
                                    {
                                        if (!(aposition == -1 || bposition == -1))
                                        {
                                            count = bposition - aposition - 1;
                                            Console.WriteLine($"Между элементами {a} и {b} находится {count} элемента(-ов).");
                                        }
                                        else
                                            Console.WriteLine("Какой-то из элементов столбца не был найден в массиве.");
                                    }
                                    else
                                    {
                                        if (!(aposition == -1 || bposition == -1))
                                        {
                                            count = aposition - bposition - 1;
                                            Console.WriteLine($"Между элементами {a} и {b} находится {count} элемента(-ов).");
                                        }
                                        else
                                            Console.WriteLine("Какой-то из элементов столбца не был найден в массиве.");
                                    }
                                    for (int i = 0; i < array2.Length; i++)
                                    {
                                        if (array2[i] % 2 != 0 && array2[i] > 0)
                                            sum += array2[i];
                                    }
                                    Console.WriteLine($"Сумма положительных нечетных элементов в данном столбце = {sum}");
                                }
                                else
                                    Console.WriteLine("Неверный номер столбца.");
                                break;
                            default:
                                Console.WriteLine("Вы ввели неверное значение, перезапустите программу.");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Количество столбцов не может быть меньше двух.");
                }
                else
                    Console.WriteLine("Количество строк не может быть меньше двух.");
            } catch
            {
                Console.WriteLine("Неверный формат данных.");
            }
            Console.ReadKey();
        }
    }
}
