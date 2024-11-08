namespace Work4;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];

        for (int i = 0; i < 100; i++) dizi[i] = new Random().Next(0, 50);

        for (int i = 0; i < dizi.Length; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++)
            {
                if (dizi[i] == dizi[j])
                {
                    Console.WriteLine($"Dizi[{i}] ve Dizi[{j}] tekrarlayan değer: {dizi[i]}");
                }
            }
        }
    }
}
