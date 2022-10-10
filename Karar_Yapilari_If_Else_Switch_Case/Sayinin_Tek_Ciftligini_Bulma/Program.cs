using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayinin_Tek_Ciftligini_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------");


            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi2 % 2 != 0)
            {
                {
                    Console.WriteLine("Girdiğiniz sayı tektir.");
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------");


            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi3 % 2 == -1)
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
            else if (sayi3 % 2 == 1)
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.Read();
        }
    }
}
