Console.WriteLine("Podaj Imię bohatera:");
string Imię = Console.ReadLine()!;
Console.WriteLine("Podaj Symbol:");
char symbol = char.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj poziom:");
int poziom = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj Złoto:");
int złoto = int.Parse(Console.ReadLine());
Console.WriteLine("podaj wage:");
double wage = double.Parse(Console.ReadLine());
bool mapa = true;

Console.WriteLine("==EKWIPUNEK==");
Console.WriteLine($"Imię (string): {Imię}");
Console.WriteLine($"Symbol (char): {symbol}");
Console.WriteLine($"Poziom (int): {poziom}");
Console.WriteLine($"Złoto (int): {złoto}");
Console.WriteLine($"Wage (double): {wage}");
Console.WriteLine($"Ma mapę (bool): {mapa}");
