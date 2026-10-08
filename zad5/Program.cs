Console.WriteLine("imię bohatera");
string imie = Console.ReadLine();
Console.WriteLine("maksymalne punkty życia");
int maxhp = int.Parse(Console.ReadLine());
Console.WriteLine("aktualne punkty życia przed walką");
int hp = int.Parse(Console.ReadLine());
Console.WriteLine("podstawowe obrażenia broni");
int podstawowe = int.Parse(Console.ReadLine());
Console.WriteLine("premię do siły");
int siła = int.Parse(Console.ReadLine());
Console.WriteLine("mnożnik ataku specjalnego");
double spec = double.Parse(Console.ReadLine());
Console.WriteLine("liczbę wykonanych zwykłych ataków");
int liczbaatak = int.Parse(Console.ReadLine());

int zwykły = podstawowe + siła;
int atakzwykly = zwykły * liczbaatak;
int atakspec = podstawowe * (int)spec;
int łącznie = atakzwykly + atakspec;
double procenthp = (double)hp / maxhp * 100;
bool żyje = hp > 0;
bool mamaxhp = hp == maxhp;

Console.WriteLine($"========== RAPORT Z WALKI ==========\nBohater: {imie}\nZdrowie: {hp}/{maxhp} ({procenthp:F2}%)\nZwykły atak: {zwykły}\nAtak specjalny: {atakspec}\nŁączne zadane obrażenia: {łącznie}\nŻyje: {żyje}\nPełne zdrowie: {mamaxhp}\n====================================\n");






