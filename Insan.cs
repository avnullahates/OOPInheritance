using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim2
{
   public class Insan
    {

        private string ad;
        public string Adi
        {
            get { return ad; }
            set { ad = value; }
        }

        private string soyad;
        public string Soyadi
        {
            get { return soyad; }
            set { soyad = value; }
        }


        private DateTime DateTime;
        public DateTime DogumTarihi
        {
            get { return DateTime; }
            set { DateTime = value; }
        }

        private string tcNumarasi;
        public string TcNo
        {
            get { return tcNumarasi; }
            set { tcNumarasi = value; }
        }
    }


}
