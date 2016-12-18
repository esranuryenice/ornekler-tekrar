using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinci_ornek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Sayıyı Girin :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sayac = 1;
            int fakto = 1;
            while (sayac<=sayi)
            {
                fakto = fakto * sayac;
                sayac++;
            }
            Console.WriteLine("Sonuc="+fakto);
            Console.ReadKey();
        }
    }
}
