using System.Collections;
using System.Globalization;


//dizilerOrnegi();

//foreachOrnegi();

//foreachDiziOrnegi();

//matrisOrnegi();

//arrayListOrnegi();

//listOrnegi();


Console.ReadKey();

void matrisOrnegi()
{
    double[,] matris = new double[,]
    {
            {1,2,3,4 },
            {2,3,4 ,5},
            {3,4,5 ,6},
            {4,5 ,6,7}
    };
    double toplam = 0;
    for (int i = 0; i < matris.GetLength(0); i++)
    {

        for (int j = 0; j < matris.GetLength(1); j++)
        {
            if (i == j)
            {
                matris[i, j] = -1;
            }
            if (matris[i, j] % 2 == 0)
            {
                matris[i, j] = 0;
            }
            toplam += matris[i, j];
            Console.Write($"{matris[i, j],5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Toplam: {toplam}");
}

void foreachDiziOrnegi()
{
    Console.WriteLine("Lutfen bir sayi girin");
    int boyut = Convert.ToInt32(Console.ReadLine());
    int[] numaralar = new int[boyut];

    var r = new Random();
    for (int i = 0; i < numaralar.Length; i++)
    {
        numaralar[i] = r.Next(1, 10);
    }
    Console.WriteLine("Sayılar  Karesi");
    foreach (var item in numaralar)
    {
        Console.WriteLine($"{item,3}{item * item,9}");
    }
}

void foreachOrnegi()
{
    Console.WriteLine("Lutfen bir sayi girin");
    int boyut = Convert.ToInt32(Console.ReadLine());
    int[] numaralar = new int[boyut];

    var r = new Random();
    for (int i = 0; i < numaralar.Length; i++)
    {
        numaralar[i] = r.Next(1, 80);
    }

    foreach (var item in numaralar)
    {
        Console.Write(item + "  ");
    }
}

void dizilerOrnegi()
{
    //dizi tanımlama
    int[] numaralar;

    //diziyi başlatma
    numaralar = new int[3];

    //diziye değer atama
    numaralar[0] = 3;
    numaralar[1] = 4;
    numaralar[2] = 5;

    //dizi elemanlarına ulaşma ve yazdırma
    for (int i = 0; i < numaralar.Length; i++)
    {
        Console.WriteLine($"Numaralar[{i}] -> " + $"{numaralar[i]}");
    }

    //tanımlama ve başlatma aynı yerde de olabilir
    //int numaralar = new int[3];

    //tanımlama, başlatma ve değer atama aynı satırd da yapılabilir
    //int[] numaralar=new int[3] {3,4,5};

    //dizinin eleman sayısı dinamik hale getirilebilir.
    //bunun için köşeli parantez içindeki değer silinir.
    //int[] numaralar=new int[] {3,4,5,6,7,8,}; istenilen kadar değer eklenebilir

    //aşağıdaki gibi kısa eşkilde de dizi tanımlama ve değer ataması yapılabilir
    //int[] numaralar = { 3, 4, 5, 6, 7, 8, };  en kısa aliyle dizi tanımlama ve atama şeklidir.
}

static void arrayListOrnegi()
{
    //ArrayList Tanımlama
    ArrayList liste = new ArrayList();

    //ArrayList'e veri ekleme. Çeşitli tiplerde veri tutabilir
    liste.Add(10);  //int ifade
    liste.Add("Btk akademi"); //string ifade 
    liste.Add(true); liste.Add(false); //bool türünde
    liste.Add('e');  //char tipinde veri
                     // liste içinde dolaşma
    foreach (var e in liste)
    {
        Console.Write($"{e},  ");
    }
    Console.WriteLine();
    //ArrayList liste = new ArrayList() { 10, "Btk akademi", true, false, 'e' }; şeklinde de tanımlama yapılabilirdi7


    int[] sayilar = new int[] { 23, 44, 55 };
    liste.AddRange(sayilar);   //ArrayList'e bir diziyi komple aktarabiliriz

    foreach (var e in liste)
    {
        Console.Write($"{e},  ");
    }
    Console.WriteLine();
    Console.WriteLine(liste[5]); // listenin tek elemanına ulaşmak için kullanırız
                                 // elemana erişme ve atama
    var x = (int)liste[0];   //ArrayListte veriler kutulama yoluyla tutulur ve Object tipindedir. Burada kutudan çıkarma yapıldı
    Console.WriteLine(x + 10);

    //Listeden  eleman sime
    liste.Remove(10); //listedeki değere göre silme yaapar
    liste.RemoveAt(1);// listedeki index değerine göre silme yapar
    liste.RemoveRange(3, 3); //ilk değer index no, ikinci değer silinecek eleman sayısı
    foreach (var e in liste)
    {
        Console.Write($"{e},  ");
    }
}

static void listOrnegi()
{
    //List tanımlama
    int x = 40;
    var liste = new List<int>();  //tip güvenliği vardır. hangi tiple tanımlandıysa aynı tiple kullanılabilir.
                                  //ekleme yapmak
    liste.Add(10);
    liste.Add(20);
    liste.Add(30);
    liste.Add(x);// int tanımlı değişken doğrudan eklenebilir
    int[] Seri = new int[] { 50, 60, 70 };
    liste.AddRange(Seri);  //listeye başkabir diziyi eklemek mümkün7
    liste.AddRange(new int[] { 80, 90, 100 }); // bu şekilde de kullanımı var
    liste.Insert(10, 110); //10. index e 110 ekle
    liste.InsertRange(11, new int[] { 120, 130, 140 }); //11. indexten itibaren dizideki elemanları listeye ekle
    liste.RemoveAt(10); //10. indexteki elemanı sil
    liste.RemoveAt(liste.IndexOf(50)); // listeden 50 değerinin indeksini bul ve sil
    liste.Remove(60); // listeden 60 değerini bul ve sil


    //dolaşma
    foreach (var s in liste)
    {
        Console.Write($"{s,-5}");
    }
}