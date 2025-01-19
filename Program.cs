// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int fenerbahce = 8;
// int galatasaray = 7;
// int besiktas = 6;
// int trabzonspor = 5;


// if (fenerbahce > galatasaray)
// {
//     Console.WriteLine("Fenerbahçe lider");
// }
// else if (galatasaray > fenerbahce)
// {
//     Console.WriteLine("Galatasaray lider");
// }
// else
// {
//     Console.WriteLine("Berabere");
// }

// rastgele üretilen 20 sayıdan çift olanların toplamını bulan program
// Random rnd = new Random();
// int[] sayilar = new int[20];

// for (int i = 0; i < 20; i++)
// {
//     sayilar[i] = rnd.Next(1, 100);
// }

// Console.WriteLine("Üretilen 20 rastgele sayı:");
// int toplam = 0;
// foreach (int sayi in sayilar)
// {
//     Console.Write($"{sayi} \n");
//     // sadece çift olanları toplamak için
//     if (sayi % 2 == 0)
//     {
//         toplam += sayi;
//         Console.WriteLine($"Çift sayı: {sayi}");
//     }
// }
// Console.WriteLine($"Çift sayıların toplamı: {toplam}");
// Console.WriteLine();


Random rnd = new Random();
int toplam = 0;

for (int i = 0; i < 20; i++)
{
    int sayi = rnd.Next(1, 100);
    Console.WriteLine(sayi);
    if (sayi % 2 == 0)
    {
        toplam += sayi;
    }
}
Console.WriteLine($"Çift sayıların toplamı: {toplam}");
