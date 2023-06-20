namespace Controle.Manutinfo.Models;

public class Controle
{
    public int Id { get; set; }
    public required string Setor { get; set; }
    public required string Maquina { get; set; }
    public required string Configuracao { get; set; }
    public int TeamViewer { get; set; }
    public required string Monitor { get; set; }
    public required string Nobreak { get; set; }
    public required string Impressora { get; set; }
    public required string Estabilizador { get; set; }
    public int CPD { get; set; }
    public DateTime DataUltimaManu { get; set; }
    public DateTime DataProxManu { get; set; }
}