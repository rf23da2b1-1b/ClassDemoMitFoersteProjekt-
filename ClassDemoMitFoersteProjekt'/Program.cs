// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// erklæringer
int alder;
double beløb;
string navn;
bool solskin;


// tildele værdier
alder = 65;
beløb = 112.50;
navn = "Peter";
solskin = false;



// udskriver
Console.WriteLine(alder);
Console.WriteLine(beløb);
Console.WriteLine(navn);
Console.WriteLine(solskin);


// tekst operationer
navn = navn + " Levinsky";
Console.WriteLine(navn);

navn = navn + " Roskilde" + " Danmark";
Console.WriteLine(navn);

string vare = "Varen koster " + "Beløb: " + beløb;
Console.WriteLine(vare);

Console.WriteLine($"varen koster {beløb + 5} kroner");




/*
 * Metoder - (fremgangsmåder)
 * 
 * Alle metoder skal have et navn
 * Alle metoder har en retur værdi -- dog nogen returnerer ingenting
 * Alle metoder har en parameter liste -- dog kan være tom
 * 
 */

int l = 9;
int b = 7;

//int areal = l * b;

VisLængdeBredde(l, b);
int areal2 = Areal(l, b);

//Console.WriteLine(areal);

Console.WriteLine(areal2);

BareVisPeter();

// metode til at udregne areal - normalt er metoder public
int Areal(int længde, int bredde)
{
    
    return længde * bredde;
}

void VisLængdeBredde(int længde, int bredde)
{
    Console.WriteLine("længden er: "+ længde);
    Console.WriteLine("bredden er: " + bredde);
}

void BareVisPeter()
{
    Console.WriteLine("peter");
}