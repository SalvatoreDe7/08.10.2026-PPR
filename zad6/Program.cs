Console.WriteLine("Podaj nazwe bohatera: ");
string bohater = Console.ReadLine()!;
Console.WriteLine("Podaj Zdrowie bohatera(max100): ");
int zdrowie = int.Parse(Console.ReadLine()!);
const int maxhp = 100;
Console.WriteLine("Podaj Siłę bohatera: ");
int sila = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj Zręczność bohatera: ");
int zrecznosc = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj Obronę bohatera: ");
decimal obrona = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj ilość jedzenia: ");
int jedzenie = int.Parse(Console.ReadLine());
int miejsce = jedzenie * 2;
const
decimal skuteczneHP = zdrowie + (zdrowie * obrona / 10);
double skuteczneDPS = (double)sila + (sila * zrecznosc / 10);
double procenthp = (double)zdrowie / maxhp * 100;
bool gotowydowyprawy = (zdrowie > 0) && (jedzenie > 1);



Console.WriteLine("╔════════════════════════════════╗");
Console.WriteLine("║         Rougalik DDL           ║");
Console.WriteLine("╠════════════════════════════════╝");
Console.WriteLine($"║ Nazwa Bohatera: {bohater}      ");
Console.WriteLine($"║ Zdrowie: {zdrowie}/{maxhp} {procenthp:F2%}             ");
Console.WriteLine($"║ Siła: {sila}                    ");
Console.WriteLine($"║ Zręczność: {zrecznosc}          ");
Console.WriteLine($"║ Obrona: {obrona}                ");
Console.WriteLine($"║ Skuteczne HP: {skuteczneHP}          ");
Console.WriteLine($"║ Skuteczne DPS: {skuteczneDPS}          ");
Console.WriteLine($"║ Poziom Bohatera: {zdrowie + sila + zrecznosc + obrona}          ");
Console.WriteLine("╚════════════════════════════════╝");