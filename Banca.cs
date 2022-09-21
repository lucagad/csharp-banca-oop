
public class Banca
{
    public string Nome { get; set; }

    public List<Cliente> clienti = new List<Cliente>();
    public List<Prestito> prestitiConcessi = new List<Prestito>();


    public Banca(string nome)
    {
        Nome = nome;
    }

    // Funzione per Aggiungere un nuovo Cliente
    public void AggiungiCliente( string codFisc, string nome, string cognome, double stipendio)
    {
        Cliente nuovoCliente = new Cliente(codFisc);

        nuovoCliente.Nome = nome;
        nuovoCliente.Cognome = cognome;
        nuovoCliente.Stipendio = stipendio;

        clienti.Add(nuovoCliente);
    }

    // Funzione per Modificare un Cliente
    public void ModificaCliente(string codFisc,double nuovoStipendio)
    {
        Console.WriteLine(" ");
        Console.WriteLine("--- RISULTATO RICERCA ---");
        bool risultato = false;


        foreach (var cliente in clienti)
        {
            if (cliente.CodFiscale == codFisc)
            {

                Console.WriteLine(" ");
                Console.WriteLine("------------");
                Console.WriteLine("COD.FISCALE: " + cliente.CodFiscale);
                Console.WriteLine("PRECEDENTE STIPENDIO: " + cliente.Stipendio + " €");
                Console.WriteLine("------------");
                cliente.Stipendio = nuovoStipendio;

                Console.WriteLine("");
                Console.WriteLine("--- NUOVI DATI ---");
                Console.WriteLine("COD.FISCALE: " + cliente.CodFiscale);
                Console.WriteLine("NUOVO STIPENDIO: " + cliente.Stipendio + " €");
                Console.WriteLine(" ");

                risultato = true;
                break;
            }

        }

        if (risultato == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("La Ricerca non ha prodotto un risultato");
        }
    }

    // Funzione per Cercare un Cliente
    public void CercaCliente(string codFisc)
    {
        Console.WriteLine(" ");
        Console.WriteLine("--- RISULTATO RICERCA ---");
        bool risultato = false;


        foreach (var cliente in clienti)
        {
            if (cliente.CodFiscale == codFisc)
            {

                Console.WriteLine(" ");
                Console.WriteLine("------------");
                Console.WriteLine("NOME: " + cliente.Nome);
                Console.WriteLine("COGNOME: " + cliente.Cognome);
                Console.WriteLine("COD.FISCALE: " + cliente.CodFiscale);
                Console.WriteLine("STIPENDIO: " + cliente.Stipendio + " €");
                Console.WriteLine("------------");

                risultato = true;
                break;
            }

        }

        if (risultato == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("La Ricerca non ha prodotto un risultato");
        }

    }

    // Funzione per Aggiungere un nuovo Prestito
    public void AggiungiPrestito(int countPrestiti, string codFisc, double totaleCredito, int rate, DateTime dataInizio, DateTime dataFine)
    {
        Prestito nuovoPrestito = new Prestito(countPrestiti, codFisc, totaleCredito);
        nuovoPrestito.Rata = rate;
        nuovoPrestito.DataInizio = dataInizio;
        nuovoPrestito.DataFine = dataFine;

        prestitiConcessi.Add(nuovoPrestito);
    }

    // Funzione per restituire il totale dei prestiti concessi ad un cliente
    public double TotalePrestiti(string codFisc)
    {
        double totaleConcesso = 0;

        foreach (var prestito in prestitiConcessi)
        {
            if (prestito.Cliente == codFisc)
            {
                totaleConcesso += prestito.TotaleCredito;
            }

        }

        return totaleConcesso;

    }


    // Stampa tutti i prestiti di un cliente
    public void StampaPrestitiConcessi( string codFiscale)
    {
        Console.WriteLine("------------");
        Console.WriteLine("--- LISTA DEI PRESTITI CONCESSI ---");
        bool prestitoPresente = false;

        foreach (var prestito in prestitiConcessi)
        {
            if (prestito.Cliente == codFiscale)
            {
                Console.WriteLine(" ");
                Console.WriteLine("------------");
                Console.WriteLine("ID: " + prestito.ID);
                Console.WriteLine("COD.FISCALE: " + prestito.Cliente);
                Console.WriteLine("TOTALE CREDITO: " + prestito.TotaleCredito);
                Console.WriteLine("NUMERO RATE: " + prestito.Rata);
                Console.WriteLine("DATA INIZIO: " + prestito.DataInizio);
                Console.WriteLine("DATA FINE: " + prestito.DataFine);
                Console.WriteLine("------------");
                prestitoPresente = true;
            }
        }

        if(prestitoPresente == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("--- NON SONO PRESENTI PRESTITI ASSOCIATI AL CODICE FISCALE INSERITO ---");
        }

        Console.WriteLine(" ");
        
    }
}