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

string vare = "Varen koster " + beløb;
Console.WriteLine(vare);

Console.WriteLine($"varen koster {beløb} kroner");
