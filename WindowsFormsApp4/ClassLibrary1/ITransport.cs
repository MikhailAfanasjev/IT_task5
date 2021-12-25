using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface ITransport
    {
        int HP { get; set; }
        double TransportTax();
        double GetWatts();
    }
}
