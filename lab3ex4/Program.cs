using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 4
 Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
 • Cel mai mare numar din vector
 • Cel mai mic numar din vector
 • Numerele divizibile cu 3 */

            Console.WriteLine("Introduceti n = ");
            int lungimeSir = int.Parse(Console.ReadLine());

            int[] array = new int[lungimeSir];

            for (int i = 0; i < lungimeSir; i++)
            {
                Console.WriteLine("Introduceti numarul de pe pozitia " + i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numarul maxim din sir este " + NumarMaxim(array, lungimeSir));
            Console.WriteLine("Numarul minim din sir este " + NumarMinim(array, lungimeSir));
            Console.WriteLine();
            NumereleDivizibileCu3(array, lungimeSir);
            Console.WriteLine();
            VerificaToateNumerelePrime(array, lungimeSir);
        }

        public static int NumarMaxim(int[] sir, int lungimeSir) 
        {
            //initializam potentialul rezultat cu primul numar din sir
            int max = sir[0];

            //incepem de la 1 pentru ca nu are rost sa verificam variabila max cu el insusi, acesta fiind pe pozitia 0
            for (int i = 1; i < lungimeSir; i++)
            {
                if (sir[i] > max)
                    max = sir[i]; //am gasit o valoarea maxima noua
            }

            return max;

        }

        public static int NumarMinim(int[] sir, int lungimeSir)
        {
            //initializam potentialul rezultat cu primul numar din sir
            int min = sir[0];

            //incepem de la 1 pentru ca nu are rost sa verificam variabila min cu el insusi, acesta fiind pe pozitia 0
            for (int i = 1; i < lungimeSir; i++)
            {
                if (sir[i] < min)
                    min = sir[i]; //am gasit o valoarea maxima noua
            }

            return min;

        }

        public static void NumereleDivizibileCu3(int[] sir, int lungimeSir)
        {
            //incepem de la 1 pentru ca nu are rost sa verificam variabila min cu el insusi, acesta fiind pe pozitia 0
            for (int i = 0; i < lungimeSir; i++)
            {
                if (sir[i] % 3 == 0) Console.WriteLine("Numarul " + sir[i] + " este divizibil cu 3");
            }

        }

        public static void VerificaToateNumerelePrime(int[] sir, int lungimeSir)
        {
            for (int i = 0; i < lungimeSir; i++)
            {
                if (VerificaNumarPrim(sir[i]) == true) Console.WriteLine("Numarul " + sir[i] + " este prim");
                else Console.WriteLine("Numarul " + sir[i] + " nu este prim");
            }
        }

        public static bool VerificaNumarPrim(int x)
        {
            int numarDivizori = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    numarDivizori = numarDivizori + 1;
                }
            }
            if (numarDivizori == 2) return true;
            else return false;
        }
    }
}
