using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * başla.
             * kullanıcıdan bir pozitif tam sayı alınır.
             * kullanıcıdan alınan sayı 2'den başlayarak kullancının girdiği sayıya bölünür ve kalanı bulunur.
             * eğer bölmeden kalan 0 ise asal sayı değil.
             * eğer bölmeden kalan 0 değil ise asıl sayıdır.
             * kullanıcıya asal sayı durumu gösterilir.
             * bitti.
             */
            Console.Write("Pozitif tam sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool asalMi = true;
            if (sayi == 1)
                asalMi = false;
            for (int i = 2; i < sayi && asalMi; i++)
            {
                if(sayi % i == 0)
                {                    
                    asalMi = false;
                    //break;
                }                
            }
            if (asalMi)
                Console.WriteLine("Asal.");
            else
                Console.WriteLine("Asal değil.");

            Console.ReadLine();
        }
    }
}
