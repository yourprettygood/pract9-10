using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract9_10
{
    internal class Program
    {
        static void Pract9()
        {
            Console.Write("Введите номер задачи: ");
            short numb = short.Parse(Console.ReadLine());
            switch (numb)
            {


                //Задание №2.Программирование алгоритмов итерационной циклической структуры

                case 2: // Заданная точность
                    double epsilon = 1e-3;

                    // Переменные для расчёта
                    double sum = 0.0; // Сумма ряда
                    double term = 1.0; // Первый член ряда
                    int n = 1; // Номер текущего члена ряда
                    int k = 0; // Количество итераций

                    double numerator = 1.0; // Числитель для факториала n!
                    double denominator = 1.0; // Знаменатель для факториала (2n)!

                    // Вычисление суммы ряда
                    do
                    {
                        k++;

                        // Обновляем числитель и знаменатель для текущего члена ряда
                        numerator *= n;
                        denominator *= 2 * n - 1;
                        denominator *= 2 * n;

                        // Вычисление текущего члена ряда
                        term = numerator / denominator;

                        // Добавляем текущий член к сумме
                        sum += term;

                        // Переход к следующему члену ряда
                        n++;
                    } while (Math.Abs(term) > epsilon);

                    // Вывод результата
                    Console.WriteLine($"Количество итераций: {k}\t Сумма ряда: {sum:f6}");
                    break;


                //Задание №1. Табулирование функций
                case 1: // Заданные параметры
                    double a = 0; // параметр a
                    double b = Math.PI / 2;
                    int M = 20; // количество точек
                    double H = (b - a) / M;
                    // Вывод заголовка таблицы
                    Console.WriteLine("  x         F(x) = sin(x) - cos(x)");
                    for (int i = 0; i <= M; i++)
                    {
                        double x = a + i * H; double F_x = Math.Sin(x) - Math.Cos(x); Console.WriteLine($"{x:F1}  {F_x:F5}");
                    }
                    break;
            }


        }
        static void Pract10()
        {
            Console.Write("Введите номер задачи: ");
            short numb = short.Parse(Console.ReadLine());
            switch (numb)
            {
                case 1:
                    //Задание №1. Работа с одномерными массивами
                    //Найти сумму чисел кратных трем в массиве целых чисел.
                    
                    int[] numbers = { 12, 5, 9, 18, 7, 3, 8, 21, 10 };
                    // Переменная для хранения суммы чисел, кратных 3
                    int sum = 0; int count = 0;  // Для подсчета количества чисел, кратных 3
                    string divisibleByThreeNumbers = ""; // Для хранения чисел, кратных 3
                                                         // Проходим по всем элементам массива
                    foreach (int num in numbers)
                    {                // Если число кратно 3, добавляем его к сумме
                        if (num % 3 == 0)
                        {
                            sum += num; count++;  // Увеличиваем счетчик
                            divisibleByThreeNumbers += num + " ";  // Добавляем число в строку                }
                        }
                    }
                    Console.WriteLine("Количество чисел, кратных 3: " + count);
                    Console.WriteLine("Числа, кратные 3: " + divisibleByThreeNumbers);
                    break;



                    case 2:

                    Console.Write("Введите количество элементов в массиве: ");
                    int n = int.Parse(Console.ReadLine());
                    double[] array = new double[n];

                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = double.Parse(Console.ReadLine());
                    }

                    int firstZeroIndex = -1;
                    int lastZeroIndex = -1;
                    double sumer = 0;

                    // Поиск индексов первого и последнего нулевых элементов
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == 0)
                        {
                            if (firstZeroIndex == -1)
                            {
                                firstZeroIndex = i;
                            }
                            lastZeroIndex = i;
                        }
                    }

                    // Проверка, найдены ли нулевые элементы
                    if (firstZeroIndex != -1 && lastZeroIndex != -1 && firstZeroIndex != lastZeroIndex)
                    {
                        // Вычисление суммы элементов между первым и последним нулевыми элементами
                        for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
                        {
                            sumer += array[i];
                        }
                    }

                    Console.WriteLine("Сумма элементов между первым и последним нулевыми элементами: " + sumer);



                    break;
            }
        }



                    
            
        


        static void Main(string[] args)
        {
            Console.Write("Введите номер практической работы(9,10):");
            short numb = short.Parse(Console.ReadLine());
            switch (numb)
            {
                case 9: Pract9(); break;

                case 10:Pract10();
                    break;
            }
        }
    }
}
 
