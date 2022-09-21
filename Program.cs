//Esercizio
//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

//OK
//La banca è caratterizzata da
// - un nome
// - un insieme di clienti (una lista)
// - un insieme di prestiti concessi ai clienti (una lista)

//OK
//I clienti sono caratterizzati da
// - nome,
// - cognome,
// - codice fiscale
// - stipendio

//OK
//I prestiti sono caratterizzati da
// - ID
// - intestatario del prestito (il cliente),
// - un ammontare,
// - una rata,
// - una data inizio,
// - una data fine.

//Per la banca deve essere possibile:
// - aggiungere, modificare e ricercare un cliente. (OK)
// - aggiungere un prestito. (OK)
// - effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale (OK)
// - sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi. (OK)
// - sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.(OK)

//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.

//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

Banca bancaTest = new Banca("Banca TEST");

bancaTest.AggiungiCliente("GDDL", "Luca", "Gad", 1500);
bancaTest.AggiungiCliente("GDDS", "Simone", "Gad", 1000);
bancaTest.AggiungiCliente("GDDF", "Francesco", "Gad", 800);


var date1 = new DateTime(2022, 1, 1, 7, 0, 0);

//Console.WriteLine("Difference in days: " + (date2.Month - date1.Month));

bancaTest.AggiungiPrestito(1, "GDDL", 200, 12, date1);
bancaTest.AggiungiPrestito(2, "GDDL", 300, 18, date1);

bancaTest.AggiungiPrestito(3, "GDDS", 300, 16, date1);
bancaTest.AggiungiPrestito(4, "GDDS", 3000, 36, date1);

Console.WriteLine("Benvenuto!");
Console.WriteLine(" ");
avvioProgramma();


void avvioProgramma()
{
    int scelta = MenuIniziale();

    switch (scelta)
    {
        // Gestione Clienti
        case 1:
            #region
            int sceltaMenuCliente = MenuGestioneCliente();

            switch (sceltaMenuCliente)
            {
                // Aggiungere un Cliente
                case 1:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine(" --- INSERIMENTO CLIENTE --- ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Codice Fiscale");
                    Console.WriteLine(" ");

                    string codFiscaleNuovoCliente = Console.ReadLine();

                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Nome");
                    Console.WriteLine(" ");
                    string nomeNuovoCliente = Console.ReadLine();

                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Cognome");
                    Console.WriteLine(" ");
                    string cognomeNuovoCliente = Console.ReadLine();

                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci lo stipendio");
                    Console.WriteLine(" ");
                    double stipendioNuovoCliente = Convert.ToDouble(Console.ReadLine());

                    bancaTest.AggiungiCliente(codFiscaleNuovoCliente, nomeNuovoCliente, cognomeNuovoCliente, stipendioNuovoCliente);

                    Console.WriteLine("Cliente Inserito");

                    break;
                    #endregion

                // Modificare un Cliente
                case 2:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine(" --- MODIFICA STIPENDIO CLIENTE --- ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Codice Fiscale");
                    Console.WriteLine(" ");

                    string codFiscaleModifica = Console.ReadLine();

                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il nuovo stipendio");
                    Console.WriteLine(" ");

                    double stipendioModifica = Convert.ToDouble(Console.ReadLine());


                    bancaTest.ModificaCliente(codFiscaleModifica, stipendioModifica);


                    avvioProgramma();
                    break;
                    #endregion

                // Cercare un Cliente
                case 3:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine(" --- RICERCA CLIENTE --- ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Codice Fiscale");
                    Console.WriteLine(" ");

                    string codFiscaleRicerca = Console.ReadLine();
                    Console.WriteLine(" ");

                    bancaTest.CercaCliente(codFiscaleRicerca);

                    avvioProgramma();
                    break;
                    #endregion

                default:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine("Scelta errata");
                    Console.WriteLine("Verrai riportato al menù principale.");
                    Console.WriteLine(" ");
                    avvioProgramma();
                    break;
                    #endregion
            }

            break;
            #endregion

        // Gestione Prestiti
        case 2:
            #region
            int sceltaMenuPrestito = MenuGestionePrestito();

            switch (sceltaMenuPrestito)
            {
                // Aggiungere un Prestito
                case 1:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine(" --- INSERIMENTO PRESTITO --- ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Codice Fiscale del cliente");
                    Console.WriteLine(" ");

                    string codFiscalePrestito = Console.ReadLine();

                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Totale del prestito");
                    Console.WriteLine(" ");
                    double totalePrestito = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Numero di Rate");
                    Console.WriteLine(" ");
                    int ratePrestito = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci la Data d'Inizio (MM/DD/YYYY)");
                    Console.WriteLine(" ");
                    DateTime dataInizio = DateTime.Parse(Console.ReadLine());

                    int countPrestiti = bancaTest.prestitiConcessi.Count() + 1;
                    bancaTest.AggiungiPrestito(countPrestiti, codFiscalePrestito, totalePrestito, ratePrestito, dataInizio);

                    Console.WriteLine(" ");
                    Console.WriteLine("Prestito Inserito");
                    Console.WriteLine(" ");
                    avvioProgramma();
                    break;
                #endregion


                // Cercare un Prestito
                case 2:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine(" --- PRESTITI CONCESSI AL CLIENTE --- ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Codice Fiscale");
                    Console.WriteLine(" ");

                    string codFiscaleRicerca = Console.ReadLine();
                    Console.WriteLine(" ");

                    bancaTest.StampaPrestitiConcessi(codFiscaleRicerca);
                    Console.WriteLine("--- FINE RICERCA ---");
                    Console.WriteLine(" ");
                    avvioProgramma();
                    break;
                #endregion

                // Ammontare del credito dato ad un cliente un Prestito
                case 3:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine(" --- TOTALE PRESTITI CONCESSI --- ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci il Codice Fiscale:");
                    Console.WriteLine(" ");

                    string codFiscaleTotalePrestito = Console.ReadLine();
                    Console.WriteLine(" ");

                    double totaleConcesso = bancaTest.TotalePrestiti(codFiscaleTotalePrestito);

                    if (totaleConcesso >0)
                    {
                        Console.WriteLine("TOTALE CREDITO CONCESSO: " + totaleConcesso + " €");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                       Console.WriteLine("-- NON SONO PRESENTI PRESTITI ASSOCIATI AL CODICE FISCALE INSERITO --");
                    }

                    avvioProgramma();
                    break;
                #endregion


                default:
                    #region
                    Console.WriteLine(" ");
                    Console.WriteLine("Scelta errata");
                    Console.WriteLine("Verrai riportato al menù principale.");
                    Console.WriteLine(" ");
                    avvioProgramma();
                    break;
                    #endregion
            }

            break;
            #endregion

        default:
            #region
            Console.WriteLine(" ");
            Console.WriteLine("Scelta errata");
            Console.WriteLine("Verrai riportato al menù principale.");
            Console.WriteLine(" ");
            avvioProgramma();
            break;
            #endregion
    }


}



// Menu inziale
int MenuIniziale()
{
    Console.WriteLine(" ");
    Console.WriteLine("-- MENU INIZIALE -- ");
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
    Console.WriteLine("2 - Modificare Stipendio di un Cliente");
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
    Console.WriteLine("3 - Calcolo del totale dei prestiti concessi ad un cliente");
    Console.WriteLine(" ");

    int sceltaMenu = Convert.ToInt32(Console.ReadLine());

    return sceltaMenu;
}

