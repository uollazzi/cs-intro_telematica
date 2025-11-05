// concatenazione
string amico = "Gigi";
string saluto = "Ciao " + amico + "!";

Console.WriteLine(saluto);

// interpolazione
Console.WriteLine($"Ciao {amico}!");

var altroAmico = "Mario";
Console.WriteLine($"I miei amici sono {amico} e {altroAmico}.");

// proprietà delle stringhe
Console.WriteLine($"Il nome {amico} ha {amico.Length} lettere.");

// conversione
char a = 'a';
int eta = 31;
double altezza = 1.56;

Console.WriteLine($"La mia amica {amico}{a} ha {eta} anni ed è alta {altezza} metri.");

// operazioni sulle stringhe
string saluti = "       Ciao Mondo!       ";
Console.WriteLine($"[{saluti}]");

Console.WriteLine(saluti.Trim());

// replace
string ciao = "Ciao Mondo!";
Console.WriteLine(ciao);

string ciao2 = ciao.Replace("Ciao", "Buongiorno");
Console.WriteLine(ciao2);

ciao2 = ciao.Replace("ciao", "Buongiorno", true, null);
Console.WriteLine(ciao2.ToUpper());

// ricercare
string songLyrics = "Tu dici addio, io dico arrivederci";
Console.WriteLine(songLyrics.Contains("addio"));
Console.WriteLine(songLyrics.StartsWith("tu", true, null));

string albero = "albERo";
Console.WriteLine(albero[2]);

Console.WriteLine(albero.Substring(2, 2));

// range operator
Console.WriteLine(albero[2..5]);
Console.WriteLine(albero[2..]);
Console.WriteLine(albero[..3]);
Console.WriteLine(albero[..]);

// trasformare "albERo" in "Albero" usando interpolazione di stringhe e range operator
// scrivere a console
Console.WriteLine($"{albero[..1].ToUpper()}{albero[1..].ToLower()}");