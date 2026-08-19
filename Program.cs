using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzień_4_lekcja_11_praca_domowa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę sprawdzimy czy jest ona przysta czy nieparzysta ");
            while (true)
            {
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Nieprawidłowa liczba. Spróbuj ponownie.");


                }



                if (number % 2 == 0)

                    Console.WriteLine("Podana liczba jest liczbą parzystą.");

                else

                    Console.WriteLine("Podana liczba jest liczbą nieparzystą.");



                Console.WriteLine("Czy chcesz sprawdzić kolejną liczbę? (t/n)");
                string response = Console.ReadLine();
                if (response.ToLower() != "t")
                {
                    break;
                    Console.ReadKey();
                }


            }
              

                
        }
    }
}

