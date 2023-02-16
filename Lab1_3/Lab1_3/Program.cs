using System;

namespace LAB1_3

{
    public delegate int Number();
    public delegate int MediumCalc(Number[] arrayX);
    class Program
    {
        static void Calculate(int a, int b, int c, out double aa, out double bb, out double cc)
        {
            aa = a / 5;
            bb = b / 5;
            cc = c / 5;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            double aa, bb, cc;
            Console.WriteLine("Введите 1 значение");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 значение");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 значение");
            c = Convert.ToInt32(Console.ReadLine());

            Calculate(a, b, c, out aa, out bb, out cc);



        }
    }
}