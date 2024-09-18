 string[] sehirler = {"Afyon","İstanbul","Kocaeli","Ankara","Çanakkale","Bursa","Ankara" };

// yukarıdaki cıktıda kaç adet ankara var 
/*
int ankaraVarmı = 0;
string arananSehir = "Ankara";
foreach(var i in sehirler)
{
    if(i == arananSehir)
    {
        ankaraVarmı++;
    }
}
Console.WriteLine(ankaraVarmı);
*/


//int[] sayılarım = { -6,0,56,9000};

// bu dizide ki en küçük ve en büyük sayıları bulunuz
/*
Array.Sort(sayılarım);
Console.WriteLine($"En Küçük sayı {sayılarım[0]}\n En Büyük Sayı {sayılarım[sayılarım.Length -1]}");*/
/*
int max = sayılarım[sayılarım.Length -1];
int min = sayılarım[0];

foreach(var i in sayılarım)
{
    if (i == min)
    {
        Console.WriteLine("En Küçük Değer"+ min);
    }
    if(i == max)
    {
        Console.WriteLine("En Büyük Değer"+ max);
    }
}*/


// yukarıdaki dizinin ortalamasını bulunuz
/*
int toplam = 0;
foreach (var item in sayılarım)
{
    toplam += item;
}
double ortalama = toplam / sayılarım.Length;
Console.WriteLine(ortalama);*/


// yukaridaki diziyi kullanarak asağıda kı formatta cıktıyı oluşturun
// -6 
// güncel toplam -6
// 0 
// güncel toplam
/*
int güncelToplam = 0;
foreach (var item in sayılarım)
{
    güncelToplam += item;
    Console.WriteLine($"Güncel Toplam {güncelToplam}");

}
*/

int[] sayılar = {5,2,3,1,4,16 };
// Consolun her satırına dizide ki değer kadar yıldız yazınız

/*
for (int i = 0; i < sayılar.Length; i++)
{
    for (int j = 0; j < sayılar[i]; j++)
    {
        Console.WriteLine(" x ");
    }
    Console.WriteLine("\n");
}*/

// yukarıda ki dizi elemanları kullanarak yeni bir dizi olusturunuz
// fakat yukarıda her bir değerin kares yeni dizi

int[] yenidizi;

yenidizi = sayılar;

foreach (var item in yenidizi)
{
    Console.WriteLine(item*2);
}

Array.Copy(sayılar,yenidizi,6);

foreach (var item in yenidizi)
{
    Console.WriteLine(item*2);
}


