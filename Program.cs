// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// dichiarazione
int numero;
numero = 5;

// dichiarazione e assegnazione con type inference
var s = "ciao";

int n = 9;

int n1, n2, n3;

string pippo = "pippo";

bool sposato = false;

// tipi numeri decimali
double virgola = 7.9;
decimal d = 7.9M;
float f = 76.8F;

// data e ora
DateTime data;

// casting
int five = 5;

var fiveDouble = (double)five;

// casting implicito (no perdita di dati)
double fiveDouble2 = five;
long fiveLong = five;

// casting esplicito
double dblFour = 4.7;
int intFour = (int)dblFour;

int fourInt = Convert.ToInt32(dblFour);

// parsing
string strTwo = "due";
int twoInteger = int.Parse(strTwo);

DateTime oggi = DateTime.Parse("05/11/2025");

// operatore is
var mioValore = 6.5M;

bool isDecimal = mioValore is decimal;

// operatore as
string testString = "Test";
object objString = (object)testString;

var test2 = objString as string;

// tipi nullable
bool? maggiorenne = null;
maggiorenne = true;

int? b = 10;

// operatore ??
int f2 = b ?? -1;