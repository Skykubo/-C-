using System;

namespace ConsoleApp2
{ 
    class Program
{ 

    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину ребра куба a: ");
            string tmp = Console.ReadLine();
            int a = Int32.Parse(tmp);
            int V = a * a * a;
            int S = 6 * (a * a);
            Console.WriteLine("Объем куба = " + V);
                Console.WriteLine ("Площадь поверхности куба = " + S);

    }
}
}
