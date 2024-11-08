namespace Work9;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];

        for (int i = 0; i < dizi.Length; i++) dizi[i] = new Random().Next(-10, 10);


        int[] pozitifler = dizi.Where(x => x > 0).Reverse().ToArray();
        int j = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > 0) dizi[i] = pozitifler[j++];
        }

        Console.WriteLine("Dizi: " + string.Join(", ", dizi));
    }
}
