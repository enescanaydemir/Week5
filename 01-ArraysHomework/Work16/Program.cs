namespace Work16;

class Program
{
    static void Main(string[] args)
    {
        List<int> sayilar = new List<int>();
        int sayi;
        do
        {
            Console.Write("Bir sayı girin (0 girilirse durur): ");
            sayi = int.Parse(Console.ReadLine());
            if (sayi != 0) sayilar.Add(sayi);
        } while (sayi != 0);

        double ortalama = sayilar.Average();



        Console.WriteLine("Girilen Sayılar: " + string.Join(", ", sayilar));
        Console.WriteLine("Ortalama: " + ortalama);
    }
}
