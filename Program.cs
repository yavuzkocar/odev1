using System;
using System.Globalization;
using System.Text;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru 1
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            //cevap 1

            // Console.WriteLine("lütfen pozitif bir sayı giriniz.");
            // int n = Convert.ToInt32(Console.ReadLine());
            // int[] dizi = new int[n];
            // Console.WriteLine("lütfen {0} adet pozitif  sayı giriniz.",n);
            // for (int i = 0; i < n; i++)
            // {
            //    dizi[i]=Convert.ToInt32(Console.ReadLine());
            // }
            // foreach (var item in dizi)
            // {
            //     if (item%2==0)
            //     {
            //         Console.WriteLine(item);
            //     }
            // }

            //soru 2
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            //cevap 2
            
            // Console.WriteLine("lütfen iki pozitif sayı giriniz.");
            // int n = Convert.ToInt32(Console.ReadLine());
            // int m = Convert.ToInt32(Console.ReadLine());
            // int[] dizi = new int[n];
            // Console.WriteLine("lütfen {0} adet pozitif  sayı giriniz.",n);
            // for (int i = 0; i < n; i++)
            // {
            //    dizi[i]=Convert.ToInt32(Console.ReadLine());
            // }
            // foreach (var item in dizi)
            // {
            //     if (item%m==0)
            //     {
            //         Console.WriteLine(item);
            //     }
            // }

            //soru 3
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            //cevap 3

            // Console.WriteLine("lütfen pozitif bir sayı giriniz.");
            // int n = Convert.ToInt32(Console.ReadLine());
            // string[] dizi = new string[n];
            // Console.WriteLine("lütfen {0} adet kelime giriniz.",n);
            // for (int i = 0; i < n; i++)
            // {
            //    dizi[i]=Console.ReadLine();
            // }
            // Array.Reverse(dizi);
            // foreach (var item in dizi)
            // {
            //     Console.WriteLine(item);
            // }

            //soru 4
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("lütfen bir cümle yazınız");
            string cumle= Console.ReadLine();
            int sayacharf=0;
            for (int i = 0; i < cumle.Length ; i++)
            {byte[] a =Encoding.ASCII.GetBytes(cumle[i].ToString());
            string b="";
            foreach (var item in a)
            b+=item;
            int c = int.Parse(b);
            
                if ((64<c && 90>=c) || (96<c && 122>=c) )
                {
                    sayacharf++;
                }
            }
             
            string[] dizi= cumle.Split(" ");
            Console.Write("girdiğiniz kelime sayısı: ");
            Console.WriteLine(dizi.Length);
            Console.Write("girdiğiniz harf sayısı: ");
            Console.WriteLine(sayacharf);
           
        }
    }
}
