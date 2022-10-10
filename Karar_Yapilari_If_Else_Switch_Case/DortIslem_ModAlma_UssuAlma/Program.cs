using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem_ModAlma_UssuAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan öğrenilen 2 sayıya göre(float) ve işlem tipine(char) göre sonucu ekrana yazdıran program. Toplamaya göre T,çıkarmaya göre Ç, Çarpma için X, Bölme için B, mod işlemi için M, üst alma işlemi için U)

            islem:
            Console.WriteLine(Environment.NewLine + "Lütfen yapılacak işlemi giriniz: ");
            Console.WriteLine(Environment.NewLine + "Toplama için: 'T' yada 't'");
            Console.WriteLine(Environment.NewLine + "Çıkarma için: 'C' yada 'c'");
            Console.WriteLine(Environment.NewLine + "Bölme için: 'B' yada 'b'");
            Console.WriteLine(Environment.NewLine + "Mod almak için: 'M' yada 'm'");
            Console.WriteLine(Environment.NewLine + "Üs olarak almak için: 'U' yada 'u' olarak giriniz.");
            char islem = Convert.ToChar(Console.ReadLine());

            Console.Write(Environment.NewLine + "Lütfen birinci sayıyı giriniz: ");
            float sayi1 = Convert.ToSingle(Console.ReadLine());

            iki:
            Console.Write(Environment.NewLine + "Lütfen ikinci sayıyı giriniz: ");
            float sayi2 = Convert.ToSingle(Console.ReadLine());

            if (islem == 'T' || islem == 't')
            {
                Console.WriteLine("Toplam: " + (sayi1 + sayi2));
            }
            else if (islem == 'C' || islem == 'c')
            {
                Console.WriteLine("Fark: " + (sayi1 - sayi2));
            }
            else if (islem == 'X' || islem == 'x')
            {
                Console.WriteLine("Çarpım: " + (sayi1 * sayi2));
            }
            else if (islem == 'B' || islem == 'b')
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine(Environment.NewLine + "Lütfen 2. sayıyı yeniden giriniz. Payda 0 olamaz!");
                    goto iki;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Bölüm: " + (sayi1 / sayi2));
                }
            }
            else if (islem == 'M' || islem == 'm')
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine(Environment.NewLine + "Lütfen 2. sayıyı yeniden giriniz. Payda 0 olamaz!");
                    goto iki;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Mod: " + (sayi1 % sayi2));
                }
            }
            else if (islem == 'U' || islem == 'u')
            {
                Console.WriteLine(Environment.NewLine + "Kuvveti: " + Math.Pow(Convert.ToDouble(sayi1), Convert.ToDouble(sayi2)));
                //Math.Pow sayıları sadece double istediğinden çevirme yaptık.
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Yanlış bir seçim yaptınız. Lütfen yeni bir işlem seçiniz.");
                goto islem;
            }

            Console.WriteLine(Environment.NewLine + "Başka bir işlem yapmak ister misiniz? (E/H)");
            string cevap = Console.ReadLine();

            if (cevap == "E" || cevap == "e")
            {
                Console.Clear();
                goto islem;
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "İsteğiniz üzerine işlemi sonlandırıyorum...");
            }
            Console.Read();
        }
    }
}
