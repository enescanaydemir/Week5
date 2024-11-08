namespace Work15;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 3, 8, 1, 4, 7, 10 };
        int[] tekSirali = dizi.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();
        int j = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                dizi[i] = tekSirali[j++];
            }
        }

        Console.WriteLine("Sıralanmış Dizi: " + string.Join(", ", dizi));
    }
}
