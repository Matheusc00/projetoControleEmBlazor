using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Manutinfo.Models;

public class Estabilizador : Patrimonio
{
    public Estabilizador()
    {
        Marca = "SMS";
    }

    public string Marca { get; set; }
}