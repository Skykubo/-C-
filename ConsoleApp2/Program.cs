﻿using System;
using System.Globalization;

namespace ConsoleApp2
{ 
    class Program
{ 

    static void Main(string[] args)
    {
            //                                      Begin5
            //Console.WriteLine("Введите длину ребра куба a: ");
            //    string tmp = Console.ReadLine();
            //    int a = Int32.Parse(tmp);
            //    int V = a * a * a;
            //    int S = 6 * (a * a);
            //    Console.WriteLine("Объем куба = " + V);
            //        Console.WriteLine ("Площадь поверхности куба = " + S);

            //                            Begin7

            //Console.WriteLine("Введите радиус окружности: ");
            //string tmp = Console.ReadLine();
            //int R = Int32.Parse(tmp);
            //int p = (int)3.14;
            //int L = 2 * p * R;
            //int S = p * (R * R);
            //Console.WriteLine("Длина окружности = " + L);
            //Console.WriteLine("Площадь круга = " + S);

            //                              Begin9
            //Console.WriteLine("Введите два числа: ");
            //string tmp=Console.ReadLine();
            //int a = Int32.Parse(tmp);
            //string tm = Console.ReadLine();
            //int b = Int32.Parse(tm);
            //double c = Math.Sqrt(a * b);
            //Console.WriteLine("Среднее геометрическое чисел = " + c);

            //                      Begin10
            //Console.WriteLine("Введите два числа: ");
            //string tmp=Console.ReadLine();
            //double a= Int32.Parse(tmp);
            //string tm=Console.ReadLine();
            //double b = Int32.Parse(tm);
            //double sum = (a*a)+(b*b);
            //double dif= (a*a)- (b*b);
            //double prod = (a*a)*(b*b);
            //double quo= (a*a)/(b*b);
            //Console.WriteLine("Сумма квадратов = " + sum);
            //Console.WriteLine("Разность квадратов = " + dif);
            //Console.WriteLine("Произведение квадратов = " + prod);
            //Console.WriteLine("Частное квадратов = " + quo);

            //                  IF2
            //Console.WriteLine("Введите число: ");
            //string tmp=Console.ReadLine();
            //int a=Int32.Parse(tmp);
            //if (a >= 0)
            //{
            //    int b = a + 1;
            //    Console.WriteLine(+b);
            //}
            //else
            //{
            //    int b = a - 2; 
            //    Console.WriteLine(+b);
            //}

            //                 IF4
            //Console.WriteLine("Введите три числа: ");
            //string t = Console.ReadLine();
            //int a=Int32.Parse(t);
            //string tt= Console.ReadLine();
            //int b=Int32.Parse(tt);
            //string ttt=Console.ReadLine();
            //int c=Int32.Parse(ttt);
            //int d = 0;

            //if (a >= 0)
            //{
            //    d = d + 1;
            //}
            //if (b >= 0)
            //{
            //    d = d + 1;
            //}
            //if (c >= 0) 
            //{
            //    d = d + 1;
            //}
            //Console.WriteLine("Положительных чисел: "+d);

            //              If7
            //Console.WriteLine("Введите два числа");
            //string t = Console.ReadLine();
            //int a=Int32.Parse(t);
            //string tt=Console.ReadLine();
            //int b=Int32.Parse(tt);
            //if (a<b)
            //{
            //    Console.WriteLine("Порядковый номер меньшего числа: 1");
            //}
            //else
            //{
            //    Console.WriteLine("Порядковый номер меньшего числа: 2");
            //}

            //                 IF9
            Console.WriteLine("Введите две переменные вещественного типа: ");
            string t=Console.ReadLine();    
            double A=Convert.ToDouble(t);
            string tt=Console.ReadLine(); 
            double B= Convert.ToDouble(tt);
            if (A>B)
            {
                (A, B) = (B, A);            
            }
          
            Console.WriteLine("Значение A: " + A);
            Console.WriteLine("Значение B: " + B);
        }
}
}
