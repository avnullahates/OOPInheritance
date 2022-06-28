using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim2
{
    public class Akademisyen : Memur
    {
        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string program;

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public void AkademisyenBilgileriniIste()
        {

            Console.WriteLine("Akademisyen adini giriniz.");
            Adi = Console.ReadLine();

            Console.WriteLine("Akademisyen soyadini giriniz.");
            Soyadi = Console.ReadLine();

            Console.WriteLine("Akademisyen Dogum tarihini giriniz.(YYYY,AA,GG)");
            DogumTarihi = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Akademisyen Tc sini giriniz.");
            TcNo = Console.ReadLine();

            Console.WriteLine("Akademisyen birim adini giriniz.");
            BirimAdi = Console.ReadLine();

            Console.WriteLine("Akademisyen Sicil nosunu giriniz.");
            SicilNumarasi =int.Parse(Console.ReadLine());

            Console.WriteLine("Akademisyen mailini giriniz.");
            Mail = Console.ReadLine();

            Console.WriteLine("Akademisyen programini giriniz.");
            Program = Console.ReadLine();
        }

        public void AkademisyenBilgileriniYaz()
        {
            Console.WriteLine($"Akademisyen adi: {Adi}" +
                $"\nAkademisyen Soyadi: {Soyadi}" +
                $"\nAkademisyen Dogum Tarihi: {DogumTarihi}" +
                $"\nAkademisyen Tc nosu: {TcNo}" +
                $"\nAkademisyen birim adi: {BirimAdi}" +
                $"\nAkademisyen Sicil no: {SicilNumarasi}" +
                $"\nAkademisyen mail: {Mail}" +
                $"\nAkademisyen programi: {Program}");
        }
    }

}
