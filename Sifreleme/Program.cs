using System;
using System.Collections.Generic;
using System.Text;

namespace Sifreleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şifrelenecek metni giriniz");
            string metin = Console.ReadLine();
            Console.ReadLine();
            List<char> harf = new List<char>();
            List<char> binaryHarfler = new List<char>();
            List<int> asciiKarsilik = new List<int>();
            List<int> asciiKarsilikk = new List<int>();
            byte[] ascii = Encoding.ASCII.GetBytes(metin);
            foreach (var item in ascii)
            {
                asciiKarsilik.Add(item);
            }
            Console.WriteLine("Harflerin ascii karşılığı");
            for (int i = 0; i < metin.Length; i++)
            {
                Console.WriteLine(asciiKarsilik[i]);
            }
            List<string> binaryKarsilik = new List<string>();                  
                for (int i = 0; i < metin.Length; i++)
                {
                    int sayi = asciiKarsilik[i];
                int kalan;
                string yazikalan = "";
                    int a = 0;
                    while(sayi!= 0)
                    {
                        kalan = sayi % 2;
                        sayi = sayi / 2;
                        yazikalan = kalan.ToString() + yazikalan;
                    }
                    binaryKarsilik.Add(yazikalan);
                Console.WriteLine("Ascii nin binary karşılığı");
                    Console.WriteLine(yazikalan);
            }
            string tümleyenMetin = "";
            foreach (var item in binaryKarsilik)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == '1')
                    {
                        binaryHarfler.Add('0');
                    }
                    else if (item[i] == '0')
                    {
                        binaryHarfler.Add('1');
                    }
                }
                binaryHarfler.Add('-');
            }
            foreach (var item in metin)
            {
                for (int i = 0; i < binaryHarfler.Count; i++)
                {
                    if (item=='-')
                    {
                        break;
                    }
                    else
                    {
                        tümleyenMetin += binaryHarfler[i];
                    }
                }
            }
            Console.WriteLine("Binary nin tümleyen karşılığı");
                  Console.WriteLine(tümleyenMetin);
            int dec = 0;
            for (int i = 0; i < tümleyenMetin.Length; i++)
            {
                if (tümleyenMetin[tümleyenMetin.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
            }
            Console.WriteLine("Tümleyenin decimal karşılığı ");
            Console.WriteLine(dec);
            string decc = dec.ToString();
            byte[] asciii = Encoding.ASCII.GetBytes(decc);
            foreach (var item in asciii)
            {
                asciiKarsilikk.Add(item);
            }
            Console.WriteLine("Şifrenin ascii karşılığı");
            for (int i = 0; i < decc.Length; i++)
            {
                Console.Write(asciiKarsilikk[i]);
            }
        }
    }
}
