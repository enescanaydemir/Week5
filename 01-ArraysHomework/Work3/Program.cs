namespace Work3;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        List<int> pozitifler = new List<int>();
        List<int> negatifler = new List<int>();
        int index = 0;

        while (index < dizi.Length)
        {
            dizi[index] = new Random().Next(-10, 10);
            if (dizi[index] >= 0)
            {
                pozitifler.Add(dizi[index]);
            }
            else
            {
                negatifler.Add(dizi[index]);
            }
            index++;
        }
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", pozitifler));
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negatifler));
    }
}


/*

10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve her iki diziyi de ekrana yazdıran bir program yazın. İşlemi gerçekleştirmek için while döngüsü kullanın.

*/