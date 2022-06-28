using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim2
{
    public class Ogrenci : Insan
    {

        private string birimAdi;
        public string BirimAdi
        {
            get { return birimAdi; }
            set { birimAdi = value; }
        }

        private string bolum;
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }

        private int ogrNo;
        public int OgrenciNumarasi
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }

        private string sinifi;
        public string Sinif
        {
            get { return sinifi; }
            set { sinifi = value; }
        }


        public void OgrenciBilgileriniIste()
        {
            Console.WriteLine("Ogrenci adini giriniz.");
            Adi = Console.ReadLine();

            Console.WriteLine("Ogrenci soyadini giriniz.");
            Soyadi = Console.ReadLine();

            Console.WriteLine("Ogrenci Dogum tarihini giriniz.(YYYY,AA,GG)");
            DogumTarihi =DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ogrenci Tc sini giriniz.");
            TcNo = Console.ReadLine();

        }

        public void OgrenciBilgileriniYaz()
        {
            Console.WriteLine($"Ogrencinin adi: {Adi}" +
                $"\nOgrencinin Soyadi: {Soyadi}" +
                $"\nOgrencinin Dogum Tarihi: {DogumTarihi}" +
                $"\nOgrencinin Tc nosu: {TcNo}");
        }



    }
}
