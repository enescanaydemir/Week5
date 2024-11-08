namespace Week6;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];

        for (int i = 0; i < 100; i++) dizi[i] = new Random().Next(-100, 100);

        int enBuyuk = dizi.Max();
        int enKucuk = dizi.Min();


        Console.WriteLine($"En Büyük: {enBuyuk}, En Küçük: {enKucuk}");
    }
}
