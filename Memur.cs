using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim2
{
    public class Memur : Insan
    {
        private string birimAd;
        public string BirimAdi
        {
            get { return birimAd; }
            set { birimAd = value; }
        }

        private int sicilNo;
        public int SicilNumarasi
        {
            get { return sicilNo; }
            set { sicilNo = value; }
        }

        public void MemurBilgileriniIste()
        {
            Console.WriteLine("Memur adini giriniz.");
            Adi = Console.ReadLine();

            Console.WriteLine("Memur soyadini giriniz.");
            Soyadi = Console.ReadLine();

            Console.WriteLine("Memur Dogum tarihini giriniz.(YYYY,AA,GG)");
            DogumTarihi = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Memur Tc sini giriniz.");
            TcNo = Console.ReadLine();

            Console.WriteLine("Memur birim adini giriniz.");
            BirimAdi = Console.ReadLine();

            Console.WriteLine("Memur Sicil nosunu giriniz.");
            SicilNumarasi = int.Parse(Console.ReadLine());
        }

        public void MemurBilgileriniYaz()
        {
            Console.WriteLine($"Memur adi: {Adi}" +
                $"\nMemur Soyadi: {Soyadi}" +
                $"\nMemur Dogum Tarihi: {DogumTarihi}" +
                $"\nMemur Tc nosu: {TcNo}"+
                $"\nMemur birim adi: {BirimAdi}" +
                $"\nMmur Sicil no: {SicilNumarasi}");
        }

    }
}
