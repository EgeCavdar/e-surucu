using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1
{
    // EhliyetAdayi sınıfı (Class1)
    public class EhliyetAdayi : IEhliyetAdayi
    {
        public string TCKN { get; set; }
        public string DogumTarihi { get; set; }
        public string EhliyetTipi { get; set; }
        public string Ikametgah { get; set; }
     
        public bool EhliyetAlabilirMi()
        {
            return true;
        }
    }
}
