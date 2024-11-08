namespace Work11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle girin: ");
        string[] kelimeler = Console.ReadLine().Split();

        int index = kelimeler.Length - 1;

        while (index >= 0)
        {
            Console.WriteLine(kelimeler[index]);
            index--;
        }
    }
}
