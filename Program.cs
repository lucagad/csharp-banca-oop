//Esercizio
//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

//La banca è caratterizzata da
// - un nome
// - un insieme di clienti (una lista)
// - un insieme di prestiti concessi ai clienti (una lista)

//I clienti sono caratterizzati da
// - nome,
// - cognome,
// - codice fiscale
// - stipendio

//I prestiti sono caratterizzati da
// - ID
// - intestatario del prestito (il cliente),
// - un ammontare,
// - una rata,
// - una data inizio,
// - una data fine.

//Per la banca deve essere possibile:
// - aggiungere, modificare e ricercare un cliente.
// - aggiungere un prestito.
// - effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
// - sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
// - sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.

//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.


int scelta = MenuIniziale();

switch (scelta)
{
    // Gestione Clienti
    case 1:
        int sceltaMenuCliente = MenuGestioneCliente();

        switch (sceltaMenuCliente)
        {
            // Aggiungere un Cliente
            case 1:

                break;

            // Modificare un Cliente
            case 2:
                break;

            // Cercare un Cliente
            case 3:
                break;

            default:
                Console.WriteLine("Scelta errata");
                break;
        }

        break;

    // Gestione Prestiti
    case 2:
        int sceltaMenuPrestito = MenuGestionePrestito();
        break;

    default:
        Console.WriteLine("Scelta errata");
        break;
}


// Menu inziale
int MenuIniziale()
{
    Console.WriteLine("Benvenuto!");
    Console.WriteLine(" ");
    Console.WriteLine("Cosa vuoi fare?");
    Console.WriteLine("1 - Gestione Clienti");
    Console.WriteLine("2 - Gestione Prestiti");
    Console.WriteLine(" ");

    int sceltaMenu = Convert.ToInt32(Console.ReadLine());

    return sceltaMenu;
}


// Menu Gestione Cliente
int MenuGestioneCliente()
{
    Console.WriteLine(" ");
    Console.WriteLine(" --- GESTIONE CLIENTI --- ");
    Console.WriteLine(" ");
    Console.WriteLine("Cosa vuoi fare?");
    Console.WriteLine("1 - Aggiungere un Cliente");
    Console.WriteLine("2 - Modificare un Cliente");
    Console.WriteLine("3 - Cercare un Cliente");
    Console.WriteLine(" ");

    int sceltaMenu = Convert.ToInt32(Console.ReadLine());

    return sceltaMenu;
}


// Menu Gestione Prestito
int MenuGestionePrestito()
{
    Console.WriteLine(" ");
    Console.WriteLine(" --- GESTIONE PRESTITI --- ");
    Console.WriteLine(" ");
    Console.WriteLine("Cosa vuoi fare?");
    Console.WriteLine("1 - Aggiungere un Prestito");
    Console.WriteLine("2 - Cercare un Prestito");
    Console.WriteLine(" ");

    int sceltaMenu = Convert.ToInt32(Console.ReadLine());

    return sceltaMenu;
}


