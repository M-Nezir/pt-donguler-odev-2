using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_döngüler_ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("bu programda girdiğiniz sayı ile 1 arasındali tek veya çift sayıları toplayabilirsiniz (başlamak için enter)");
            
            for (; ; )
            {               

                Console.Write("Lütfen bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("girdiğiniz sayı ile 1 arasındaki tek sayılar mı toplansın? çift sayılar mı?: ");
                string tekçift = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" ");

                int toplam = 0, b = 0;

                if (tekçift.ToLower() == "tek")
                {
                    for (int i = sayi; i >= 1; i -= 2)
                    {

                        if (i % 2 == 0)
                        {
                            i--;
                        }

                        b = toplam + i;
                        toplam = b;

                        if (i == 1)
                        {
                            Console.WriteLine(sayi + " ile 1 arasındaki tek sayıların toplamı: " + toplam);
                            break;
                        }
                    }

                }

                else if (tekçift.ToLower() == "çift")
                {

                    for (int j = sayi; j >= 0; j -= 2)
                    {
                        if (j % 2 == 1)
                        {
                            j--;
                        }

                        b = toplam + j;
                        toplam = b;

                        if (j == 0)
                        {
                            Console.WriteLine(sayi + " ile 1 arasındaki çift sayıların toplamı: " + toplam);
                            break;
                        }

                    }
                }

                Console.WriteLine(" ");
                Console.WriteLine("başka işlem yapmak istiyorsanız e harfini tuşlayınız (çıkmak için enter)");
                string tekrar = Convert.ToString(Console.ReadLine());

                if (tekrar.ToLower() != "e") 
                {
                    break;
                }

            }

        }

    }
}
