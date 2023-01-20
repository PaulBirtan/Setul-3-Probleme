using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_Probleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Problema dorita: ");
            int prob = int.Parse(Console.ReadLine());
            while (prob != 0)
            {
                switch (prob)
                {
                    case 1:
                        Problema1();
                        break;
                    case 2:
                        Problema2();
                        break;
                    case 3:
                        Problema3();
                        break;
                    case 4:
                        Problema4();
                        break;
                    case 5:
                        Problema5();
                        break;
                    case 6:
                        Problema6();
                        break;
                    case 7:
                        Problema7();
                        break;
                    case 8:
                        Problema8();
                        break;
                    case 9:
                        Problema9();
                        break;
                    case 10:
                        Problema10();
                        break;
                    case 11:
                        Problema11();
                        break;
                    case 12:
                        Problema12();
                        break;
                    case 13:
                        Problema13();
                        break;
                    case 14:
                        Problema14();
                        break;
                    case 15:
                        Problema15();
                        break;
                    case 16:
                        Problema16();
                        break;
                    case 17:
                        Problema17();
                        break;
                    case 18:
                        Problema18();
                        break;
                    case 19:
                        Problema19();
                        break;
                    case 20:
                        Problema20();
                        break;
                    case 21:
                        Problema21();
                        break;
                    case 22:
                        Problema22();
                        break;
                    case 23:
                        Problema23();
                        break;
                    case 24:
                        Problema24();
                        break;
                    case 25:
                        Problema25();
                        break;
                    case 26:
                        Problema26();
                        break;
                    case 27:
                        Problema27();
                        break;
                    case 28:
                        Problema28();
                        break;
                    case 29:
                        Problema29();
                        break;
                    case 30:
                        Problema30();
                        break;
                    case 31:
                        Problema31();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                prob = int.Parse(Console.ReadLine());
            }
        }

        private static void Problema1()
        {
            int n, i, s = 0;
            n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            for (i = 0; i < n; i++)
                s = s + V[i];
            Console.WriteLine(s);
            Console.ReadKey();
        }

        private static void Problema2()
        {
            int n, k, poz = -1, i;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            for (i = 0; i < n; i++)
                if (k == V[i])
                    poz = i;
            Console.WriteLine(poz);
            Console.ReadKey();
        }

        private static void Problema3()
        {
            int n, maxim, minim, i, pozmax=0, pozmin=0;
            n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            maxim = V[0];
            minim = V[0];
            for (i = 0; i < n; i++)
            {
                if (maxim < V[i])
                {
                    maxim = V[i];
                    pozmax = i;
                }
                if (minim > V[i])
                {
                    minim = V[i];
                    pozmin = i;
                }
            }
            Console.WriteLine(pozmax);
            Console.WriteLine(pozmin);
            Console.ReadKey();
        }

        private static void Problema4()
        {
            int n, maxim, minim, i, nrmax = 0, nrmin = 0 ;
            n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            maxim = V[0];
            minim = V[0];
            for (i = 0; i < n; i++)
            {
                if (maxim < V[i])
                {
                    maxim = V[i];
                    nrmax = 1;
                }
                if (V[i] == maxim)
                    nrmax++;
                if (minim > V[i])
                {
                    minim = V[i];
                    nrmin = 1;
                }
                if (V[i] == minim)
                    nrmin++;
            }
            Console.WriteLine(nrmax);
            Console.WriteLine(nrmin);
            Console.ReadKey();
        }

        private static void Problema5()
        {
            int n, i, e, k;
            n = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] V = new int[n+1];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            for (i = n; i >= k; i--)
                V[i] = V[i - 1];
            V[k] = e;
            for (i = 0; i < n; i++)
                Console.Write(V[i] + " ");
            Console.ReadKey();
        }

        private static void Problema6()
        {
            int n, i, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            for (i = k; i < n; i++)
                V[i] = V[i + 1];
            Array.Resize(ref V, n-1);
            for (i = 0; i < V.Length; i++)
                Console.Write(V[i] + " ");
            Console.ReadKey();
        }

        private static void Problema7()
        {
            int n, i;
            n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            int[] A = new int[n];
            for (i = 0; i < n; i++)
                V[i]=int.Parse(t[i]);
            A = V;
            for (i = 0; i < n; i++)
                V[i] = A[n - 1 - i];
            for (i = 0; i < n; i++)
                Console.Write(V[i] + " ");
            Console.ReadKey();
        }

        private static void Problema8()
        {
            int n, i, aux;
            n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            aux = V[0];
            for (i = 0; i < n-1; i++)
                V[i] = V[i + 1];
            V[n-1]=aux;
            for (i = 0; i < n; i++)
                Console.Write(V[i] + " ");
            Console.ReadKey();
        }

        private static void Problema9()
        {
            int n, i, aux, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            while (k > 0)
            {
                aux = V[0];
                for (i = 0; i < n - 1; i++)
                    V[i] = V[i + 1];
                V[n - 1] = aux;
                k--;
            }
            for (i = 0; i < n; i++)
                Console.Write(V[i] + " ");
            Console.ReadKey();
        }

        private static void Problema10()
        {
            
        }

        private static void Problema11()
        {

        }

        private static void Problema12()
        {
            int n, k, i, j, aux;
            n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            for (i = 0; i < V.Length; i++)
            {
                k = i;
                for (j = i + 1; j < V.Length; j++)
                {
                    if (V[j] < V[k])
                        k = j;
                }
                aux = V[i]; 
                V[i] = V[k];
                V[k] = aux;
            }
            Console.ReadKey();
        }

        private static void Problema13()
        {
            int n, i, k, aux;
            n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
                V[i] = int.Parse(t[i]);
            for (i = 1; i < V.Length; i++)
            {
                for (k = i; k > 0 && V[k] < V[k - 1]; k--)
                {
                    aux = V[k]; 
                    V[k] = V[k - 1]; 
                    V[k - 1] = aux;
                }
            }
            Console.ReadKey();
        }

        private static void Problema14()
        {

        }

        private static void Problema15()
        {

        }

        private static void Problema16()
        {

        }

        private static void Problema17()
        {

        }

        private static void Problema18()
        {

        }

        private static void Problema19()
        {

        }

        private static void Problema20()
        {

        }

        private static void Problema21()
        {

        }

        private static void Problema22()
        {

        }

        private static void Problema23()
        {

        }

        private static void Problema24()
        {

        }

        private static void Problema25()
        {

        }

        private static void Problema26()
        {

        }

        private static void Problema27()
        {

        }

        private static void Problema28()
        {
            
        }

        private static void Problema29()
        {

        }

        private static void Problema30()
        {

        }

        private static void Problema31()
        {

        }
    }
}