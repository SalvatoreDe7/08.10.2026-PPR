Console.WriteLine("Punkty zdrowia(max 100):");
int hp = int.Parse(Console.ReadLine());
Console.WriteLine("Liczba mikstur:");
int mikstury = int.Parse(Console.ReadLine());
Console.WriteLine("Czy ma klucz(true albo false):");
bool klucz = bool.Parse(Console.ReadLine());
Console.WriteLine("Czy ma mape(true albo false):");
bool mapa = bool.Parse(Console.ReadLine());

bool żyje = hp > 0;
bool maxhp = hp == 100;
bool wymagaleczenia = !maxhp;
bool eq = mikstury > 0;
bool kluczlubmapa =  mapa || klucz;
bool gotowy = żyje && kluczlubmapa && eq;

Console.WriteLine($"Żyje: {żyje}\nMa pełne zdrowie: {maxhp}\nWymaga leczenia: {wymagaleczenia}\nMa zaopatrzenie: {eq}\nMa klucz lub mapę: {kluczlubmapa}\nGotowy do wyprawy: {gotowy}\n");
