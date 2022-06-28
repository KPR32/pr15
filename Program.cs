using System;
using System.Numerics;

namespace пр15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Операции с комплексными числами -");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("0. Выход");
            ComplexNum cn = new ComplexNum();

            int ans = int.Parse(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    Console.WriteLine("Введите первое число: ");
                    Console.Write("Действительная часть числа = ");
                    string r = Console.ReadLine();
                    double real = 0;
                    double imag = 0;
                    if (double.TryParse(r, out real))
                    {
                        Console.Write("Мнимая часть числа = ");
                        string i = Console.ReadLine();
                        if (double.TryParse(i, out imag))
                        {
                            Complex firstNum = new Complex(real, imag);
                            Console.WriteLine("Введите второе число: ");
                            Console.Write("Действительная часть числа = ");
                            string r1 = Console.ReadLine();
                            double real1 = 0;
                            double imag1 = 0;
                            if (double.TryParse(r1, out real1))
                            {
                                Console.Write("Мнимая часть числа = ");
                                string i1 = Console.ReadLine();
                                if (double.TryParse(i1, out imag1))
                                {
                                    Complex secondNum = new Complex(real1, imag1);
                                    Console.WriteLine(cn.Plus(firstNum, secondNum));
                                }
                                else
                                    Console.WriteLine("Неверное значение");
                            }
                            else
                                Console.WriteLine("Неверное значение");
                        }
                        else
                            Console.WriteLine("Неверное значение");
                    }
                    else
                        Console.WriteLine("Неверное значение");
                    break;
                case 2:
                    Console.WriteLine("Введите первое число: ");
                    Console.Write("Действительная часть числа = ");
                    string rS = Console.ReadLine();
                    double realS = 0;
                    double imagS = 0;
                    if (double.TryParse(rS, out realS))
                    {
                        Console.Write("Мнимая часть числа = ");
                        string i = Console.ReadLine();
                        if (double.TryParse(i, out imagS))
                        {
                            Complex firstNum = new Complex(realS, imagS);
                            Console.WriteLine("Введите второе число: ");
                            Console.Write("Действительная часть числа = ");
                            string r1S = Console.ReadLine();
                            double real1S = 0;
                            double imag1S = 0;
                            if (double.TryParse(r1S, out real1S))
                            {
                                Console.Write("Мнимая часть числа = ");
                                string i1 = Console.ReadLine();
                                if (double.TryParse(i1, out imag1S))
                                {
                                    Complex secondNum = new Complex(real1S, imag1S);
                                    Console.WriteLine(cn.Minus(firstNum, secondNum));
                                }
                                else
                                    Console.WriteLine("Неверное значение");
                            }
                            else
                                Console.WriteLine("Неверное значение");
                        }
                        else
                            Console.WriteLine("Неверное значение");
                    }
                    else
                        Console.WriteLine("Неверное значение");
                    break;
                case 3:
                    Console.WriteLine("Введите первое число: ");
                    Console.Write("Действительная часть числа = ");
                    string rM = Console.ReadLine();
                    double realM = 0;
                    double imagM = 0;
                    if (double.TryParse(rM, out realM))
                    {
                        Console.Write("Мнимая часть числа = ");
                        string i = Console.ReadLine();
                        if (double.TryParse(i, out imagM))
                        {
                            Complex firstNum = new Complex(realM, imagM);
                            Console.WriteLine("Введите второе число: ");
                            Console.Write("Действительная часть числа = ");
                            string r1M = Console.ReadLine();
                            double real1M = 0;
                            double imag1M = 0;
                            if (double.TryParse(r1M, out real1M))
                            {
                                Console.Write("Мнимая часть числа = ");
                                string i1 = Console.ReadLine();
                                if (double.TryParse(i1, out imag1M))
                                {
                                    Complex secondNum = new Complex(real1M, imag1M);
                                    Console.WriteLine(cn.Ymnozh(firstNum, secondNum));
                                }
                                else
                                    Console.WriteLine("Неверное значение");
                            }
                            else
                                Console.WriteLine("Неверное значение");
                        }
                        else
                            Console.WriteLine("Неверное значение");
                    }
                    else
                        Console.WriteLine("Неверное значение");

                    break;
                case 0:
                    return;

            }
        }
    }
}      
