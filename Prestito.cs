
public class Prestito
{

    public int ID { get; private set; }
    public string Cliente { get; set; }
    public double TotaleCredito { get; set; }
    public double Rata { get; set; }
    public DateTime DataInizio { get; set; }
    public DateTime DataFine { get; set; }

    public Prestito(int iD, string cliente, double totaleCredito)
    {
        ID = iD ;
        Cliente = cliente;
        TotaleCredito = totaleCredito;
    }

}