namespace Work12;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];
        for (int i = 0; i < 100; i++) dizi[i] = new Random().Next(0, 50);

        IGrouping<int, int> gruplar = dizi.GroupBy(x => x).OrderByDescending(x => x.Count()).First();


        Console.WriteLine($"En sık tekrar eden eleman: {gruplar.Key}, Tekrar sayısı: {gruplar.Count()}");
    }
}


//tekrar bakılacak. notlardan tekrar
