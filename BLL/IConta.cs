using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IConta
    {
        string Nome { get; set; }
        decimal Saldo { get; set; }

    }
}
