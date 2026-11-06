using Ingatlanok;
List<Ingatlan> ingatlanok = new List<Ingatlan>();
if (File.Exists("ingatlanok.txt"))
{
    string[] sorok = File.ReadAllLines("ingatlanok.txt");
    foreach(string sor in sorok)
    {
        if (!string.IsNullOrWhiteSpace(sor))
        {
        string[] adatok = sor.Split(";");
        if (adatok.Length >= 4)
            {
                if (adatok.Length == 4)
                {
                    int.TryParse(adatok[3], out int alapteruletM2);
                    ingatlanok.Add(new Ingatlan(adatok[0], adatok[1], adatok[2], alapteruletM2));
                }
                else if (adatok.Length == 5)
                {
                    int.TryParse(adatok[3], out int alapteruletM2);
                    int.TryParse(adatok[4], out int arEzerFT);
                    ingatlanok.Add(new Ingatlan(adatok[0], adatok[1], adatok[2], alapteruletM2, arEzerFT));
                }
                else Console.WriteLine("[HIBA] Nem megfelelőek az adatok");
            }
        }
        else
        {
            Console.WriteLine("[HIBA] Nincs elég adat");
        }
    }
}
else
{
    Console.WriteLine("[HIBA] Fájl nem létezik");
}