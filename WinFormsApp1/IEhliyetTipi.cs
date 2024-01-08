using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1
{
    // IEhliyetTipi interface'i
    public interface IEhliyetTipi
    {
        string Tip { get; set; }
        bool UygunMu(EhliyetAdayi aday);
    }
}
