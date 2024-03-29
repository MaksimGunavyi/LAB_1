﻿using System;

namespace LAB_1
{
    public delegate int MyDelegat(int a, int b);

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите действие--> +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("Первое число -->");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число -->");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+":
                    MyDelegat myDelegat = (c, b) => { return c + b; };
                    int del = myDelegat(x, y);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "-":
                    MyDelegat myDelegat1 = (c, b) => { return c - b; };
                    int del1 = myDelegat1(x, y);
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "*":
                    MyDelegat myDelegat2 = (c, b) => { return c * b; };
                    int del2 = myDelegat2(x, y);
                    Console.WriteLine("Ответ:{0}", del2);
                    break;
                case "/":
                    MyDelegat myDelegat3 = (c, b) => { return c / b; };
                    int del3 = myDelegat3(x, y);
                    Console.WriteLine("Ответ:{0}", del3);
                    break;
                default:
                    Console.WriteLine("Выберите из предложанного");
                    break;
            }

            Console.ReadKey();

        }
    }
}