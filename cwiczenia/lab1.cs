

﻿using System;
using System.ComponentModel.DataAnnotations;


    public class cwiczenia1
    {
        static double obwod(double r)
        {
            return 2 * Math.PI * r;
        }
        static double pobranie()
        {
            Console.Write("Podaj promien okregu: ");
            double r = Double.Parse(Console.ReadLine());
            return r;
        }
       public static void zad1()
        {
            double r = pobranie();
            while (r < 0)
            {
                Console.WriteLine("Niepoprawne dane!");
                r = pobranie();
            }
            double obwodzik = obwod(r);
            Console.WriteLine("Obwód wynosi: {0}", obwodzik);
        }
        static double pole(double a, double b)
        {
            return a * b;
        }
        public static void zad2()
        {
            Console.WriteLine("Podaj dwie liczby, bedace bokami czworokąta, oddzielone przecinkiem");
            string input = Console.ReadLine();
            string[] boki = input.Split(',');
            if (double.TryParse(boki[0], out double a) && double.TryParse(boki[1], out double b))
            {
                if (a == b)
                {
                    double wynik = pole(a, b);
                    Console.WriteLine("Pole kwadratu wynosi {0}", wynik);
                }

                if (a != b)
                {
                    double wynik = pole(a, b);
                    Console.WriteLine("Pole prostokąta wynosi {0}", wynik);
                }
            }
            else
            {
                Console.WriteLine("Niepoprawne dane. Podaj dwie liczby jako długości boków.");
            }
        }
        static int parz(int a)
        {
            if (a % 2 == 0) { return 1; }
            else return 0;
        }
       public static void zad3()
        {

            Console.Write("Podaj liczbe naturalna: ");

            if (int.TryParse(Console.ReadLine(), out int a))
            {
                if (parz(a) == 1) { Console.WriteLine("Jest to liczba parzysta"); }
                if (parz(a) == 0) { Console.WriteLine("Jest to liczba nieparzysta"); }
            }
            else
            {
                Console.WriteLine("Niepoprawne dane. Podaj liczbe naturalna");
            }
        }
        static double maxim(double a, double b, double c)
        {
            double max = a;
            if (b > a) { max = b; }
            if (c > b) { max = c; }
            if (c < a) { max = a; }
            return max;
        }
        public static void zad4()
        {
            Console.Write("Podaj 3 liczby calkowite, oddzielone przecinkiem: ");
            string input = Console.ReadLine();
            string[] liczby = input.Split(',');
            if (double.TryParse(liczby[0], out double a) && double.TryParse(liczby[1], out double b) && double.TryParse(liczby[2], out double c))
            {
                double max1 = maxim(a, b, c);
                Console.WriteLine("Najwieksza z tych liczb jest {0}", max1);
            }
            else
            {
                Console.WriteLine("Niepoprawne dane. Podaj trzy liczby calkowite");
            }
        }
        static void kwadrat(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                double imagin = Math.Pow(-delta, 0.5) / 2 * a;
                double real = -b / 2 * a;
                Console.WriteLine("Miejsca zerowe to x1 = {0} + {1}i oraz x2 = {1} - {1}i", real, imagin);
            }
            if (delta == 0)
            {
                double wynik = -b / 2 * a;
                Console.WriteLine("Miejsce zerowe to x1 = {0}", wynik);
            }
            if (delta > 0)
            {
                double x1 = ((-b + Math.Pow(delta, 0.5)) / 2 * a);
                double x2 = ((-b - Math.Pow(delta, 0.5)) / 2 * a);
                Console.WriteLine("Miejsca zerowe to x1 = {0} oraz x2 = {1}", x1, x2);
            }
        }
        public static void zad5()
        {
            Console.Write("Podaj trzy liczby calkowite, oddzielone przecinkiem, bedace parametrami funkcji kwadratowej: ");
            string input = Console.ReadLine();
            string[] parametry = input.Split(',');
            if (double.TryParse(parametry[0], out double a) && double.TryParse(parametry[1], out double b) && double.TryParse(parametry[2], out double c))
            {
                kwadrat(a, b, c);
            }
            else
            {
                Console.WriteLine("Niepoprawne dane. Podaj trzy liczby calkowite");
            }
        }
    }



