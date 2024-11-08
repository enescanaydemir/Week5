namespace Work10;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        int[] tersDizi = new int[10];

        for (int i = 0; i < 10; i++) tersDizi[i] = dizi[9 - i];

        Console.WriteLine("Ters Dizi: " + string.Join(", ", tersDizi));
    }
}
