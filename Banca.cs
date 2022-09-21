
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
    public void ModificaCliente()
    {

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
                Console.WriteLine("STIPENDIO: " + cliente.Stipendio);
                Console.WriteLine("------------");

                risultato = true;
            }

        }

        if (risultato == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("La Ricerca non ha prodotto un risultato");
        }

    }

}