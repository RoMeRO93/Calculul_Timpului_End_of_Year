internal class Program
{
    private static void Main(string[] args)
    {
        int SecundePeZi = 60 * 60 * 24;
        long SecundePeSaptamana = SecundePeZi * 7;
        Console.WriteLine(SecundePeSaptamana);

        // Convertim secundele în minute, ore și zile
        long totalSecunde = SecundePeSaptamana;
        long minute = totalSecunde / 60;
        long ore = minute / 60;
        long zile = ore / 24;

        Console.WriteLine($"Secunde pe săptămână: {SecundePeSaptamana}");
        Console.WriteLine($"Minute pe săptămână: {minute}");
        Console.WriteLine($"Ore pe săptămână: {ore}");
        Console.WriteLine($"Zile pe săptămână: {zile}");

        // Convertim secundele în săptămâni, luni și ani
        long totalSecunde2 = SecundePeSaptamana;
        long saptamani = totalSecunde2 / SecundePeSaptamana;
        long luni = saptamani / 4; // Presupunând 4 săptămâni într-o lună
        long ani = luni / 12;

        Console.WriteLine($"Săptămâni: {saptamani}");
        Console.WriteLine($"Luni: {luni}");
        Console.WriteLine($"Ani: {ani}");

        // Calculăm zilele, orele, minutele și secundele rămase
        long secundeRamanatoare = totalSecunde2 % SecundePeSaptamana;
        long minuteRamanatoare = secundeRamanatoare / 60;
        long oreRamanatoare = minuteRamanatoare / 60;
        long zileRamanatoare = oreRamanatoare / 24;

        Console.WriteLine($"Zile rămase: {zileRamanatoare}");
        Console.WriteLine($"Ore rămase: {oreRamanatoare % 24}");
        Console.WriteLine($"Minute rămase: {minuteRamanatoare % 60}");
        Console.WriteLine($"Secunde rămase: {secundeRamanatoare % 60}");

        // Calculăm timpul rămas până la sfârșitul anului
        DateTime acum = DateTime.Now;
        DateTime sfarsitAn = new DateTime(acum.Year, 12, 31, 23, 59, 59);
        TimeSpan timpRamas = sfarsitAn - acum;

        Console.WriteLine($"Timpul rămas până la sfârsitul anului: {timpRamas.Days} zile, {timpRamas.Hours} ore, {timpRamas.Minutes} minute, {timpRamas.Seconds} secunde");
    }
}
