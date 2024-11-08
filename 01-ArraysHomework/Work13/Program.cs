namespace Work13;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 3, 5, 7, 8, 10 };
        int toplam = dizi.Where(x => x % 2 != 0).Sum();


        Console.WriteLine($"Toplam: {toplam}");

        Console.WriteLine(toplam % 2 == 0 ? "Toplam çift sayı" : "Toplam tek sayı");
    }
}
