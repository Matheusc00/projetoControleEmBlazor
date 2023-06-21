using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Manutinfo.Models;

public class Maquina : Patrimonio
{
    public Maquina()
    {
        Computador = "TI-HDO04";
        Configuracao = "I7-8700-16GB-SSD Win10";
        TeamViewer = 855876397;
        CPD = 1240;
    }
    public required string Computador { get; set; }
    public required string Configuracao { get; set; }
    public int TeamViewer { get; set; }
}

