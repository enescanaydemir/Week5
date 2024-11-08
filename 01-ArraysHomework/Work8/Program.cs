namespace Work8;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        for (int i = 0; i < dizi.Length; i++) dizi[i] = new Random().Next(1, 100);

        Array.Sort(dizi);
        Console.Write("Sayı girin: ");

        int girilenSayi = int.Parse(Console.ReadLine());

        if (Array.IndexOf(dizi, girilenSayi) == -1)
        {
            dizi = dizi.Append(girilenSayi).ToArray();
            Array.Sort(dizi);
        }


        Console.WriteLine("Dizi: " + string.Join(", ", dizi));
    }
}
