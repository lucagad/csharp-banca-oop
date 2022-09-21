
public class Cliente
{
    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    public string CodFiscale { get; set; } 
    public double? Stipendio { get; set; }

    public Cliente (string codFiscale)
    {
        CodFiscale = codFiscale;
    }

}
