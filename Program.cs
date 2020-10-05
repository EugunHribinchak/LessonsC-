using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabolatoryWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, m;
            int n1, m1;
            Console.Write("Введите количество строк");
            n = Console.ReadLine();
            n1 = Convert.ToInt32(n);
            Console.Write("Введите количество столбцов");
            m = Console.ReadLine();
            m1 = Convert.ToInt32(m);
            string[][] A = new string[n1][];//создание матрицы
            for (int i = 0; i < n1; i++)
            {
                A[i] = new string[m1];
            }
            string max = A[0][0];
            string min = A[0][0];
            for (int i = 0; i < n1; i++)//заполнение матрицы
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write("["+i+"]"+"["+j+"]");
                    A[i][j]=Console.ReadLine();
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n1; i++)//вывод матрицы
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write(A[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n1; i++)//поиск максимального значения во всей матрице
            {
                
                for (int j = 0; j < m1; j++)
                {
                    if (Convert.ToInt32(A[i][j]) > Convert.ToInt32(max))
                    {
                        max = A[i][j];
                    }
                }
            }
            for (int i = 0; i < n1; i++)//поиск минимального значения во всей матрице
            {
                for (int j = 0; j < m1; j++)
                {
                    if (Convert.ToInt32(A[i][j]) < Convert.ToInt32(min))
                    {
                        min = A[i][j];
                    }

                }
            }
            Console.WriteLine("Максимальное значени " + max + " Минимальное значение " + min);
            max = A[0][0];
            min = A[0][0];
            for (int i = 0; i < n1; i++)//поиск минимального значения по строкам матрицы
            {
                min = A[i][0];
                for (int j = 0; j < m1; j++)
                {
                    if (Convert.ToInt32(A[i][j])<Convert.ToInt32(min))
                    {
                        min = A[i][j];
                    }
                }
                Console.WriteLine("минимальное значение "+i+" строки "+min);
            }
            Console.WriteLine();
            for (int i = 0; i < n1; i++)//поиск максимального значения по строкам матрицы
            {
                max = A[i][0];
                for (int j = 0; j < m1; j++)
                {
                    if (Convert.ToInt32(A[i][j]) > Convert.ToInt32(max))
                    {
                        max = A[i][j];
                    }
                }
                Console.WriteLine("максимального значение " + i + " строки " + max);
            }
            Console.ReadKey();
        }  
        }
    }

