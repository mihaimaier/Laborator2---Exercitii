using System;

namespace Laborator2___Exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 2 - Exercitii

            //Exercitiu1();
            //Exercitiu2();
            //Exercitiu3();

            // Sa nu uitati sa salvati in mod frecvent (Ctrl+S) pentru a nu pierde munca
            Console.ReadLine();
        }
        static void Exercitiu1()
        {
            // Exercitiu 1 - Scrieti un program care va afisa factorialul unui numar n, n fiind citite de la tastatura.

            int i, fact = 1, numar;
            Console.WriteLine("Introduceti Numarul");
            numar = int.Parse(Console.ReadLine());

            if (numar < 0)
            {
                Console.WriteLine("Numarul introdus este invalid");
                return;
            }

            for (i = 1; i <= numar; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Numarul Factorial alui " + numar + " este: " + fact);
        }

        static void Exercitiu2()
        {
            // Exercitiu 2 - Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatura.

            Console.WriteLine("Cate numere doriti sa introduceti?");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Atentie!! Ati introdus un numar invalid");
                return;
            }
            long suma = 0;
            int numerePare = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Introduceti Numarul");
                int numar = int.Parse(Console.ReadLine());
                if (numar % 2 == 0)
                {
                    suma += numar;
                    numerePare++;
                }
            }
            double mediaAritmetica = 0;
            if (numerePare != 0)
            {
                mediaAritmetica = (double)suma / numerePare;
            }
            Console.WriteLine("Media Aritmetica Este: " + mediaAritmetica);
        }

        static void Exercitiu3()
        {
            //Exercitiu 3 - Scrieti un program care va determina daca un numar este sau nu palindrom.

            int numar, rest, suma = 0, temporar;
            Console.WriteLine("\n Introduceti Numarul");
            numar = int.Parse(Console.ReadLine());

            temporar = numar;
            while (numar > 0)
            {
                rest = numar % 10; // Pentru a obține restul prin împărțirea cu 10
                numar = numar / 10; // Pentru obținerea coeficientului prin împărțirea cu 10
                suma = suma * 10 + rest; // înmulțind suma cu 10 și adunând restul
            }
            Console.WriteLine("\n Numarul inversat este: {0} \n", suma);
            if (temporar == suma) // Verificarea dacă numărul inversat este egal cu numărul introdus
            {
                Console.WriteLine("\n Numarul este Palindrom \n\n");
            }
            else
            {
                Console.WriteLine("\n Numarul nu este Palindrom \n\n");
            }
        }
    }
}