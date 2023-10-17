
﻿using System;
using System.Reflection.Metadata.Ecma335;


    public class cwiczenia2
    {
        public static void zad1()
        {
            int suma = 0, licznik = 0;
            int ocena;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                if (ocena > 1)
                {
                    suma += ocena;
                    licznik++;
                }
            }
            double srednia = suma / licznik;
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
        }
        public static double zad2(double x, double y)
        {
            return y * Math.Pow(1.06, y);
        }
        static double max(double[] liczby)
        {
            int n = liczby.Length;
            double maxi = liczby[0];
            for (int i = 0; i < n; i++)
            {
                if (liczby[i] > maxi)
                {
                    maxi = liczby[i];
                }
            }
            return maxi;

        }
        static void liczby(double[] liczby)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Podaj {i + 1} liczbe: ");
                if (double.TryParse(Console.ReadLine(), out liczby[i]) == false)
                {
                    Console.WriteLine("Niepoprawne dane. Podaj liczbe naturalna");
                    i--;
                }

            }
        }
        static double min(double[] liczby)
        {
            int n = liczby.Length;
            double mini = liczby[0];
            for (int i = 0; i < n; i++)
            {
                if (liczby[i] < mini)
                {
                    mini = liczby[i];
                }
            }
            return mini;

        }
        public static void zad3()
        {
            double[] wyniki = new double[5];
            liczby(wyniki);
            double maks = max(wyniki);
            Console.WriteLine("Najwieksza z liczb jest {0}", maks);
        }
        static double punkty(double dlugosc, double[] oceny)
        {
            const double K = 120;
            const double S = 1.8;
            double ocena = 0;
            for (int i = 0; i < 5; i++)
            {
                ocena += oceny[i];
            }
            ocena = ocena - max(oceny) - min(oceny);
            return 60 + (dlugosc - K) * S + ocena;
        }

        public static void zad4()
        {
            Console.Write("Podaj odlegosc uzyskana przez skoczka w cm: ");
            if (double.TryParse(Console.ReadLine(), out double metry) == false)
            {
                Console.WriteLine("Niepoprawne dane. Podaj dlugosc w centymetrach");
            }
            Console.Write("Podaj oceny sędziów (oddzielone kropka, a przecinek to ewentualny separator dziesietny): ");
            string strings = Console.ReadLine();
            string[] wpisane = strings.Split('.');
            double[] oceny = new double[5];
            for (int i = 0; i < 5; i++)
            {
                if (double.TryParse(wpisane[i], out double score))
                {
                    oceny[i] = score;
                }
                else
                {
                    Console.WriteLine($"Nieprawidłowa ocena: {wpisane[i]}. Wprowadź oceny jako liczby z częścią dziesiętną.");
                    return;
                }
            }
            Console.Write($"Za ten skok skoczek otrzymal {punkty(metry, oceny)} punktow");

        }
        static int silnia(int n)
        {
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            return wynik;
        }
        public static void zad5()
        {
            Console.Write("Podaj liczbe naturalna, ktorej silnie chcesz poznac: ");
            if (int.TryParse(Console.ReadLine(), out int n) == false)
            {
                Console.WriteLine("Podaj wlasciwe dane. Silnie mozna liczyc jedynie z liczby naturalnej");
                return;
            }
            Console.WriteLine("Silnia z liczby {0} wynosi {1}", n, silnia(n));
        }
        static bool pierwsza(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) { return false; }
            }
            return true;
        }
        public static void zad6()
        {
            Console.Write("Podaj liczbe: ");
            if (int.TryParse(Console.ReadLine(), out int n) == false)
            {
                Console.WriteLine("Niepoprawne dane! Podaj liczbe naturalna");
                return;
            }
            if (pierwsza(n) == false)
            {
                Console.WriteLine("Liczba {0} nie jest liczba pierwsza", n);
            }
            if (pierwsza(n) == true)
            {
                Console.WriteLine("Liczba {0} jest liczba pierwsza", n);
            }
        }
        static double newton(int n, int k)
        {
            return (silnia(n) / (silnia(k) * silnia(n - k)));
        }
        public static void zad7()
        {
            Console.Write("Podaj pierwsza liczbe naturalna");
            if (int.TryParse(Console.ReadLine(), out int a) == false)
            {
                Console.WriteLine("Niepoprawne dane!");
                return;
            }
            Console.Write("Podaj druga liczbe naturalna, wieksza od pierwszej");
            if (int.TryParse(Console.ReadLine(), out int b) == false || b<a)
            {
                Console.WriteLine("Niepoprawne dane!");
                return;
            }
            Console.WriteLine($"Liczby pierwsze w przedziale [{a}, {b}]:");

            for (int i = a; i <= b; i++)
            {
                if (pierwsza(i))
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
