namespace Controle.Manutinfo.Models;

public class Controle : Patrimonio
{
    public Controle()
    {
        Setor = "T.I";
        DataUltimaManu = new DateTime(2023, 06, 20);
        DataProxManu = new DateTime(2023, 09, 20);

    }
    public required string Setor { get; set; }
    public DateTime DataUltimaManu { get; set; }
    public DateTime DataProxManu { get; set; }
}