namespace Work7;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[50];
        int toplam = 0;




        foreach (var sayi in dizi)
        {
            if (sayi % 2 == 0) toplam += sayi;
        }

        Console.WriteLine($"Çift Sayıların Toplamı: {toplam}");
    }
}
