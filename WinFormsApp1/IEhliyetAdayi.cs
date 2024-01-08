using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1
{
    // IEhliyetAdayi interface'i
    public interface IEhliyetAdayi
    {
        string TCKN { get; set; }
        string DogumTarihi { get; set; }
        string EhliyetTipi { get; set; }
        string Ikametgah { get; set; }
        bool EhliyetAlabilirMi();
    }
}
