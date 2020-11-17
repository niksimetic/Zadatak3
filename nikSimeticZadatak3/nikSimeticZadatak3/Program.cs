using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] niz = new string[3];

            Console.WriteLine("Unesite prvi string");
             niz[0]= Console.ReadLine();

            Console.WriteLine("Unesite drugi string");
            niz[1]= Console.ReadLine();

            Console.WriteLine("Unesite treci string ");
            niz[2]= Console.ReadLine();

            Array.Sort(niz);
            Array.Reverse(niz);

            Console.WriteLine("Sortirani stringovi");
            for(int  i=0; i<2; i++)
            {
                Console.WriteLine(niz[i]);
            }
            Console.ReadKey();
        }
    }
}
