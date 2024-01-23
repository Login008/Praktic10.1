using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_вариант_7
{
    internal class Program
    {
        static void Main (string[] args)
        {
            try
            {
                Console.Write("Введите количество строк (не менее 5): ");
                int m = int.Parse(Console.ReadLine());
                if (m >= 5)
                {
                    Console.Write("Введите количество столбцов (не менее 4): ");
                    int n = int.Parse(Console.ReadLine());
                    if (n >= 4)
                    {
                        int[,] array2x = new int[m, n];
                        for (int i = 0; i < array2x.GetLength(0); i++)
                        {
                            for (int j = 0; j < array2x.GetLength(1); j++)
                            {
                                Console.Write($"Введите число в {j + 1} столбец {i + 1} строку: ");
                                array2x[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        for (int i = 0; i < array2x.GetLength(0); i++)
                        {
                            for (int j = 0; j < array2x.GetLength(1); j++)
                            {
                                Console.Write($"{array2x[i, j],3}");
                            }
                            Console.WriteLine();
                        }
                        int stolb2 = 0;
                        for (int i = 0; i < array2x.GetLength(0); i++)
                        {
                            if (array2x[i, 1] > 15)
                                stolb2++;
                        }
                        Console.WriteLine($"Количество ненулевых чисел больше 15 во втором столбце: {stolb2}");
                        int sum5 = 0, kolvo5 = 0;
                        double mid5 = 0;
                        for (int j = 0; j < array2x.GetLength(1); j++)
                        {
                            if (array2x[4, j] % 2 != 0)
                            {
                                sum5 += array2x[4, j];
                                kolvo5++;
                            }
                        }
                        double str5 = sum5 / kolvo5;
                        mid5 = Math.Round(str5, 2);
                        Console.WriteLine($"Среднее арифметическое нечётных чисел 5 строки : {mid5}");
                        int sum4 = 0, kolvo4 = 0;
                        double sred4 = 0;
                        for (int i = 0; i < array2x.GetLength(0); i++)
                        {
                            if (array2x[i, 3] % 4 == 0)
                            {
                                sum4 += array2x[i, 3];
                                kolvo4++;
                                Console.Write($"{array2x[i, 3],3}");
                            }
                        }
                        double stolb4 = sum4 / kolvo4;
                        sred4 = Math.Round(stolb4, 2);
                        Console.WriteLine($"Среднее арифметическое чисел 4 столбца кратных четырём: {sred4}");
                    }
                    else
                        Console.WriteLine("Вы произвели неправильный ввод");
                }
                else
                    Console.WriteLine("Вы произвели неправильный ввод");
            }
            catch
            {
                Console.WriteLine("Неверный формат данных.");
            }
            Console.ReadKey();
        }
    }
}
