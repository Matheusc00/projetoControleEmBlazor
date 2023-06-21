using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Manutinfo.Models;

public class Impressora : Patrimonio
{
    public Impressora()
    {
        Marca = "HP";
        CPD = 12312;
    }

    public string Marca { get; set; }
}