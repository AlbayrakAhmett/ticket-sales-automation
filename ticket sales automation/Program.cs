using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_sales_automation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double bilet_satış_fiyatı = 0, indirim_tutarı, odenecek_tutar;
            char secim1, secim2;
            Console.Write("Bilet Saatış Fiyatı:");
            bilet_satış_fiyatı = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1:Normal Fiyat 2:İndirimli Fiyat");
            Console.Write("Seçiminizi Giriniz(1,2):");
            secim1 = Convert.ToChar(Console.ReadLine());

            if (secim1 == '1')
            {
                indirim_tutarı = 0;
                odenecek_tutar = bilet_satış_fiyatı;
                Console.Write("Bilet Fiyatı:{0}TL İndirim Oranı:0 İndirim Tutarı:0TL Bilet Türü:Normal Ödenecek Tutar:{1}TL", bilet_satış_fiyatı, odenecek_tutar);
            }
            else if (secim1 == '2')
            {
                Console.WriteLine("1:Öğrenci 2:Gazi 3:Öğretmen 4:Polis");
                Console.Write("Seçiminiz(1,2,3,4):");
                secim2 = Convert.ToChar(Console.ReadLine());

                switch (secim2)
                {
                    case '1':
                        indirim_tutarı = bilet_satış_fiyatı * 0.5;
                        odenecek_tutar = bilet_satış_fiyatı - indirim_tutarı;
                        Console.Write("Bilet Fiyatı:{0}TL İndirim Oranı:%50  Ödecencek Tutar:{1}TL Bilet Türü:Öğrenci İndirim Tutarı:{2}TL", bilet_satış_fiyatı, odenecek_tutar, indirim_tutarı);
                        break;

                    case '2':
                        indirim_tutarı = bilet_satış_fiyatı * 0.4;
                        odenecek_tutar = bilet_satış_fiyatı - indirim_tutarı;
                        Console.Write("Bilet Fiyatı:{0}TL İndirim Oranı:%40  Ödecencek Tutar:{1}TL Bilet Türü:Gazi İndirim Tutarı:{2}TL", bilet_satış_fiyatı, odenecek_tutar, indirim_tutarı);
                        break;

                    case '3':
                        indirim_tutarı = bilet_satış_fiyatı * 0.3;
                        odenecek_tutar = bilet_satış_fiyatı - indirim_tutarı;
                        Console.Write("Bilet Fiyatı:{0}TL İndirim Oranı:%30  Ödecencek Tutar:{1}TL Bilet Türü:Öğretmen İndirim Tutarı:{2}TL", bilet_satış_fiyatı, odenecek_tutar, indirim_tutarı);
                        break;

                    case '4':
                        indirim_tutarı = bilet_satış_fiyatı * 0.2;
                        odenecek_tutar = bilet_satış_fiyatı - indirim_tutarı;
                        Console.Write("Bilet Fiyatı:{0}TL İndirim Oranı:%20  Ödecencek Tutar:{1}TL Bilet Türü:Polis İndirim Tutarı:{2}TL", bilet_satış_fiyatı, odenecek_tutar, indirim_tutarı);
                        break;

                    default:
                        Console.Write("Hatalı Menü Seçimi!");
                        break;
                }

            }
            else
                Console.Write("Hatalı Menü Seçimi");
            Console.ReadKey();

        }
    }
}
