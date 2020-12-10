using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        //1. Из пяти целых положительных введенных чисел найти два наименьших.
        {
            int f = 0;
            int min = 0;
            int min2 = 0;
            int A1 = 0;
            int A2 = 0;
            int A3 = 0;
            int A4 = 0;
            int A5 = 0;
        m01:
            try
            {
                Console.WriteLine("Введите первое число: ");
                A1 = Convert.ToInt32(Console.ReadLine());
                if (A1 < 0)
                {
                    Console.WriteLine("\nНеверный ввод!\n");
                    goto m01;
                }
                f++;
            }
            catch
            {
                Console.WriteLine("\nError occured! ");
                goto m01;
            }
            if (A1 < 0)
            {
                f = 0;
            }

            try
            {
                Console.WriteLine("Введите второе число: ");
                A2 = Convert.ToInt32(Console.ReadLine());
                if (A2 < 0)
                {
                    Console.WriteLine("\nНеверный ввод!\n");
                    goto m01;
                }
                f++;
            }
            catch
            {
                Console.WriteLine("\nError occured! ");
                goto m01;
            }
            if (A2 < 0)
            {
                f = 0;

            }
            try
            {
                Console.WriteLine("Введите третье число: ");
                A3 = Convert.ToInt32(Console.ReadLine());
                if (A3 < 0)
                {
                    Console.WriteLine("\nНеверный ввод!\n");
                    goto m01;
                }
                f++;
            }
            catch
            {
                Console.WriteLine("\nError occured! ");
                goto m01;
            }
            if (A3 < 0)
            {
                f = 0;

            }
            try
            {
                Console.WriteLine("Введите четвертое число: ");
                A4 = Convert.ToInt32(Console.ReadLine());
                if (A4 < 0)
                {
                    Console.WriteLine("\nНеверный ввод!\n");
                    goto m01;
                }
                f++;
            }
            catch
            {
                Console.WriteLine("\nError occured! ");
                goto m01;
            }
            if (A4 < 0)
            {
                f = 0;

            }
            try
            {
                Console.WriteLine("Введите пятое число: ");
                A5 = Convert.ToInt32(Console.ReadLine());
                if (A5 < 0)
                {
                    Console.WriteLine("\nНеверный ввод!\n");
                    goto m01;
                }
                f++;
            }
            catch
            {
                Console.WriteLine("\nError occured! ");
                goto m01;
            }
            if (A5 < 0)
            {
                f = 0;
            }

            if (A2 < A1)
            {
                min = A2;
            }
            if (A2 >= A1)
            {
                min = A1;
            }
            if (A3 < min)
            {
                min = A3;
            }
            if (A4 < min)
            {
                min = A4;
            }
            if (A5 < min)
            {
                min = A5;
            }

            if (min != A2 && min2 < A1)
            {
                min2 = A1;
            }
            if (min != A2 && min2 >= A1)
            {
                min2 = A2;
            }
            if (min != A3 && min2 < min)
            {
                min2 = A3;
            }
            if (min != A4 && min2 < min)
            {
                min2 = A4;
            }
            if (min != A5 && min2 < min)
            {
                min2 = A5;
            }
            Console.WriteLine("Первое минимально число: {0} \nВторое минимальное число: {1} ", min, min2);
            Console.ReadKey();
        }
    }
}
