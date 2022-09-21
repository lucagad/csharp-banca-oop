
public class Prestito
{
   
    public string ID { get; set; }
    public string Cliente { get; set; }
    public double TotaleCredito { get; set; }
    public double Rata { get; set; }
    public DateOnly DataInizio { get; set; }
    public DateOnly DataFine { get; set; }

    public Prestito(string iD, string cliente, double totaleCredito)
    {
        ID = iD;
        Cliente = cliente;
        TotaleCredito = totaleCredito;
    }

}