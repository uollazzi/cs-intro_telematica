// if
int eta = 14;

if (eta > 18)
{
    Console.WriteLine($"Hai {eta} anni e quindi sei maggiorenne.");
}
else if (eta == 18)
{
    Console.WriteLine($"Hai {eta} anni e quindi sei appena maggiorenne.");
}
else
{
    Console.WriteLine($"Hai {eta} anni e quindi sei minorenne.");
}

// operatore ternario
string etichetta = "";

// alternativa operatore ternario
etichetta = eta >= 18 ? "maggiorenne" : "minorenne";

// alternativa if classico
if (eta >= 18)
{
    etichetta = "maggiorenne";
}
else
{
    etichetta = "minorenne";
}

// switch
Mese meseCorrente = Mese.Novembre;

switch (meseCorrente)
{
    case Mese.Gennaio:
    case Mese.Marzo:
        Console.WriteLine($"{meseCorrente} è il mese numero {(int)meseCorrente} dell'anno.");
        break;
    case Mese.Febbraio:
        Console.WriteLine($"{meseCorrente} è il mese numero {(int)meseCorrente} dell'anno, quello corto");
        break;
    default:
        Console.WriteLine("Altro mese dopo Febbraio");
        break;
}

// esercizio
Console.WriteLine("Inserire un mese (1-12)");
var m = Console.ReadLine();

// in base al mese inserito dire quanti giorni ha
Mese meseCorrente2 = Mese.Febbraio;
if (m != null)
{
    int meseNumero = Convert.ToInt32(m);
    Console.WriteLine(meseNumero);
    meseCorrente2 = (Mese)meseNumero;
    Console.WriteLine(meseCorrente2);
}

switch (meseCorrente2)
{
    case Mese.Novembre:
    case Mese.Aprile:
    case Mese.Giugno:
    case Mese.Settembre:
        Console.WriteLine($"{meseCorrente} ha 30 giorni.");
        break;
    case Mese.Febbraio:
        Console.WriteLine($"{meseCorrente} ha 28 giorni.");
        break;
    case Mese.Gennaio:
    case Mese.Marzo:
    case Mese.Maggio:
    case Mese.Luglio:
    case Mese.Agosto:
    case Mese.Ottobre:
        Console.WriteLine($"{meseCorrente} ha 31 giorni.");
        break;
    default:
        Console.WriteLine($"Sei ubriaco?");
        break;
}