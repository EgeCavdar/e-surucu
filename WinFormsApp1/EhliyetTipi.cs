using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1
{
    // EhliyetTipi sınıfı (Abstract Class)
    public abstract class EhliyetTipi : IEhliyetTipi
    {
        public string Tip { get; set; }
        public abstract bool UygunMu(EhliyetAdayi aday);
    }
}
