Console.WriteLine("liczba racji żywnościowych:");
int racje = int.Parse(Console.ReadLine());
Console.WriteLine("Liczba członków:");
int ludzie = int.Parse(Console.ReadLine());
Console.WriteLine("Liczba dni wyprawy:");
int dni  = int.Parse(Console.ReadLine());

int pełneracje = racje/ludzie;
int pozostanie = racje%ludzie;
double racjedziennie = (double)racje / dni;
double racjisrednio = racjedziennie/ludzie;

Console.WriteLine($"każdy otrzyma {pełneracje}\nPozostanie {pozostanie}\nDziennie na drużyne {racjedziennie}\nŚrednio na osobe {racjisrednio}");



