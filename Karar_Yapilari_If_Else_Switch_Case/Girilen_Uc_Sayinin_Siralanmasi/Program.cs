using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Uc_Sayinin_Siralanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3;

            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            int enBüyük = sayi1;

            if (sayi2 > enBüyük)
            {
                enBüyük = sayi2;
            }
            if (sayi3 > enBüyük)
            {
                enBüyük = sayi3;
            }

            Console.WriteLine("Girdiğiniz sayıların en büyüğü: " + enBüyük);

            Console.Read();
        }
    }
}
