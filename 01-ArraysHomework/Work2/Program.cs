namespace Work2;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[10];
        int[] ciftSayilar = new int[10];
        int ciftSayi = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("10 tane sayi giriniz: ");
            sayilar[i] = int.Parse(Console.ReadLine());

            if (sayilar[i] % 2 == 0)
            {
                ciftSayilar[ciftSayi] = sayilar[i];
                ciftSayi++;
            }
        }

        Array.Resize(ref ciftSayilar, ciftSayi); //Resize => diziyi yeniden sıralar, "ciftSayilar dizisini ciftSayi ya göre yeniden sırala"

        Array.Sort(ciftSayilar);//küçükten büyüğe sıralama

        foreach (int cift in ciftSayilar)
        {
            Console.WriteLine(cift);
        }

        /*
                for (int i = 0; i < ciftSayilar.Length; i++)
                {
                    Console.Write($"Çift Sayılar dizisi küçükten büyüğe sıralanmış çift sayılar: {ciftSayilar}");
                }
                */
    }
}

/*

Klavyeden girilen 10 sayıyı bir diziye atayın. Bu sayılardan çift olanları for döngüsü kullanarak ayrı bir diziye aktarın. Ardından bu çift sayı dizisini küçükten büyüğe sıralayın.


Cikti: 

2
4
6
8

*/