using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1
{
    // EhliyetMerkezi sınıfı (Class2)
    public class EhliyetMerkezi
    {
        private List<IEhliyetAdayi> _adaylar;
        public EhliyetMerkezi()
        {
            _adaylar = new List<IEhliyetAdayi>();
        }
        public void AdayEkle(IEhliyetAdayi aday)
        {
            _adaylar.Add(aday);
        }
        public string AdaylariGetir()
        {
            string adaylar = "";
            foreach (var aday in _adaylar)
            {
                adaylar += "TCKN: " + aday.TCKN + ", Doğum Tarihi: " + aday.DogumTarihi + ", Ehliyet Tipi: " + aday.EhliyetTipi + ", İkametgah: " + aday.Ikametgah + "\n";
            }
            return adaylar;
        }
    }
}
