using System;

namespace OOPKalitim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.OgrenciBilgileriniIste();

            Console.WriteLine();

            Memur memur = new Memur();
            memur.MemurBilgileriniIste();

            Console.WriteLine();

            Akademisyen akademisyen = new Akademisyen();
            akademisyen.AkademisyenBilgileriniIste();

            Console.WriteLine();

            ogr.OgrenciBilgileriniYaz();
            Console.WriteLine(new string('-',50));

            memur.MemurBilgileriniYaz();
            Console.WriteLine(new string('-', 50));

            akademisyen.AkademisyenBilgileriniYaz();
            Console.WriteLine(new string('-', 50));



            Console.ReadLine();
        }
    }



}
