using System;

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
            Console.WriteLine("Введите два числа: ");
            string tmp=Console.ReadLine();
            double a= Int32.Parse(tmp);
            string tm=Console.ReadLine();
            double b = Int32.Parse(tm);
            double sum = (a*a)+(b*b);
            double dif= (a*a)- (b*b);
            double prod = (a*a)*(b*b);
            double quo= (a*a)/(b*b);
            Console.WriteLine("Сумма квадратов = " + sum);
            Console.WriteLine("Разность квадратов = " + dif);
            Console.WriteLine("Произведение квадратов = " + prod);
            Console.WriteLine("Частное квадратов = " + quo);


        }
}
}
