namespace Work5;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];
        for (int i = 0; i < 100; i++) dizi[i] = new Random().Next(1, 101);

        Console.Write("Kontrol edilecek sayı: ");
        int sayi = int.Parse(Console.ReadLine());
        int tekrarSayisi = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] == sayi)
            {
                Console.WriteLine($"Sayı: {sayi}, Dizi[{i}] pozisyonunda bulundu.");
                tekrarSayisi++;
            }
        }

        Console.WriteLine(tekrarSayisi > 0 ? $"Sayı {tekrarSayisi} kez bulundu." : "Sayı bulunamadı.");
    }
}
