using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Manutinfo.Models
{
    public class Nobreak : Patrimonio
    {
        public Nobreak()
        {
            Marca = "APC";
        }

        public string Marca { get; set; }
    }
}