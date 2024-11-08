namespace Work14;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[20];
        for (int i = 0; i < 20; i++) dizi[i] = new Random().Next(1, 100);

        int toplam = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 3 == 0) toplam += dizi[i];
            if ((i + 1) % 5 == 0) Console.WriteLine();
        }



        Console.WriteLine("3'e bölünebilenlerin toplamı: " + toplam);
    }
}
