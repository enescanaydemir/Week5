namespace Work1;

class Program
{
    static void Main(string[] args)
    {

        int[] sayilar = [15, 21, 36, 42, 54, 66, 55, 81, 10, 19];

        for (int i = 1; i < sayilar.Length - 1; i++) //1 den başlattık ve length-1 yaptık çünkü baştaki ve sondakini almıcaz.
        {
            if (sayilar[i] > sayilar[i - 1] && sayilar[i] > sayilar[i + 1]) //sayilar dizisinin i elemanı yani o an işlenen eleman > sayilar[o an işlenen elemanın bir önceki elemani o da - 1]
            {
                Console.WriteLine($"Kendisinden önceki ve sonraki elemanlardan büyük olan elemanlar: {sayilar[i]}");

            }
        }
    }
}

/*

10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın. Bu algoritma, yalnızca kendinden önceki sayı ve kendinden sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır.


Cikti: 
Kendisinden önceki ve sonraki elemanlardan büyük olan elemanlar: 66
Kendisinden önceki ve sonraki elemanlardan büyük olan elemanlar: 81

*/
