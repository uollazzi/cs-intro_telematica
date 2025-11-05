// normalmente in C# array e liste contengono un elenco di dati dello stesso tipo
// array

// dichiarazione specificando dimensione
using System.Runtime.InteropServices;

int[] arr1 = new int[5]; // crea un array di dimensione 5


// dichiarazione specificando gli elementi
int[] arr2 = new int[] { 1, 5, 6, 9 };
int[] arr3 = [2, 5, 7];

Stagione nascita = Stagione.Inverno;
Console.WriteLine((int)Stagione.Estate);

Mese[] mesiCaldi = [Mese.Giugno, Mese.Luglio, Mese.Agosto];

Console.WriteLine(mesiCaldi[0]);

// generics
// introduce il concetto di tipo come parametro
List<int> listaInteri = [4, 7, 9];
List<int> listaInteri2 = new List<int>() { 4, 7, 9 };

var secondoNumero = listaInteri[1];

listaInteri.Add(11);
int i = listaInteri.IndexOf(7); // dimmi a che posizione (indice) si trova il valore 7
Console.WriteLine(i);

i = listaInteri.IndexOf(999);
Console.WriteLine(i);

Console.WriteLine(listaInteri.Contains(999));

listaInteri.Remove(9);
Console.WriteLine(string.Join(",", listaInteri));

listaInteri.Sort();
Console.WriteLine(string.Join(",", listaInteri));

listaInteri.Reverse();
Console.WriteLine(string.Join(",", listaInteri));

listaInteri.Clear();
Console.WriteLine(string.Join(",", listaInteri));