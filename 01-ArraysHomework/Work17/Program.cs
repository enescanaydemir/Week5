namespace Work17;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 45, 22, 75, 30, 75, 16, 34, 89, 56, 89 };
        int enBuyuk = int.MinValue;
        int ikinciEnBuyuk = int.MinValue;

        foreach (int sayi in dizi)
        {
            if (sayi > enBuyuk)
            {
                ikinciEnBuyuk = enBuyuk;
                enBuyuk = sayi;
            }
            else if (sayi > ikinciEnBuyuk && sayi < enBuyuk)
            {
                ikinciEnBuyuk = sayi;
            }
        }

        Console.WriteLine($"En Büyük Sayı: {enBuyuk}");
        Console.WriteLine($"İkinci En Büyük Sayı: {ikinciEnBuyuk}");
    }
}
