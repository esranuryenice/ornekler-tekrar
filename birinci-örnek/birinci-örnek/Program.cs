using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birinci_örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool devam = true ;
            
            while (devam)
            {
                Console.Write("Birinci Sayi :");
                Double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci Sayi : ");
                Double s2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İşlem:");
                char secim = Convert.ToChar(Console.ReadLine());
                double sonuc = 0;
                switch (secim)
                {
                    case '+':
                        sonuc = s1 + s2;
                        break;
                    case '-':
                        sonuc = s1 - s2;
                        break;
                    case '*':
                        sonuc = s1 * s2;
                        break;
                    case '/':
                        sonuc = s1 / s2;
                        break;

                    default:
                        Console.WriteLine("Böyle Bir İşlem Yok !!!"); 
                        break;
                }
                Console.WriteLine("Sonuç : "+sonuc);
                Console.WriteLine("Devam Edelim Mi ?(evet-hayır)");
                string cevap = Console.ReadLine();
                if (cevap=="evet")
                {
                    devam = true;
                }
                else
                {
                    Console.WriteLine("Görüşmek Üzere!!..");
                    devam = false;
                }

            }













            //bool devam = true;
            //while (devam)
            //{
            //    Console.Write("Birinci Sayı : ");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İkinci Sayı : ");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İşlem Seç : ");
            //    char islem = Convert.ToChar(Console.ReadLine());

            //    double sonuc = 0;
            //    switch (islem)
            //    {
            //        case '+':
            //            sonuc = sayi1 + sayi2;
            //            break;
            //        case '-':
            //            sonuc = sayi1 - sayi2;
            //            break;
            //        case '*':
            //            sonuc = sayi1 * sayi2;
            //            break;
            //        case '/':
            //            sonuc = sayi1 / sayi2;
            //            break;
            //        default:
            //            Console.WriteLine("Böyle Bir işlem tipi yok");
            //            break;
            //    }
            //    Console.WriteLine("Sonuc = " + sonuc);
            //    Console.WriteLine("Devam Edelim Mi?(Evet) ");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "evet")
            //    {

            //        devam = true;

            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}
            //Console.WriteLine("Görüşmek Üzere");
            //Console.ReadKey();
        }
    }
}
