using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Manutinfo.Models;

public class Monitor : Patrimonio
{
    public Monitor()
    {
        Modelo = "LG";
        CPD = 5655;
    }


    public required string Modelo { get; set; }
}
