// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Sayısal Tipler 
//tam sayi tipleri

int sayi1; // declaration: 32bits  
sayi1 = 10; //assignment 
Console.WriteLine("Sayı: " + sayi1);
Console.WriteLine("Max: " + int.MaxValue + ", Min: " + int.MinValue);
Int32 sayi11 = 444; 

//short sayi2 = -10, sayi3 = -20; //small int 16bits 
short sayi2 = -10;
short sayi3 = -20;
Console.WriteLine("Sayı: " + (sayi2 + sayi3));
Console.WriteLine("Sayı2: " + sayi2 + ", Sayı3: " + sayi3 + ", Toplam: " + (sayi2 + sayi3));
Console.WriteLine("Sayı2: {0}, Sayı3: {1}, Toplam: {2}", sayi2, sayi3, (sayi2 + sayi3));
Console.WriteLine($"Sayı2: {sayi2} , Sayı3: {sayi3}, Toplam: {sayi2 + sayi3}");

byte sayi4 = 255; // tinyint 8bits 
Console.WriteLine("Sayı4: " + sayi4);

bool durum = true; // bit: false 8 bits 

long sayi5 = 30; // bigint: 64 bits
Int64 sayi55 = 55;


// ondalik sayi tipleri 
float ondalik1 = 1.1f; //32bits //ekrana yazdirdiginda 1,1 seklinde gösterir. cünkü bilgisayar ayarin türkce!!!
Console.WriteLine(ondalik1);

double ondalik2 = -123.456; //64bits //genelde bunu kullanicaz 
Console.WriteLine(ondalik2);

decimal ondalik3 = 45.77m; //192bits 
Console.WriteLine(ondalik3);

char karakter = 'A'; //tek bir karakter icin kullanicaz daha metinsel degil!!!!!!!!
Console.WriteLine(karakter + ':' + (int)karakter); //karakterin sayisal degerini inte cevir demek!!
                                                   //iki nokta üst üste icin tek tirnak kullanirsan, tek tirnak, 
                                                   //tek karakter olarak algilayip sayisini alir ve toplar. 188 gelir.
                                                   //cift tirnak kullanip metinsel veri olarak yazilmali. A=65 gelir. 

Console.WriteLine(karakter + ":" + (int)karakter);

Console.WriteLine(Gunler.Pazar + " " + (int)Gunler.Pazar);


//ctrl+K+D yapmak her seyi formatlar. olmasi gerektigi düzene getirir. parantezleri mesela? daha rahat okumak icin!! 



#endregion 

#region Metinsel Tipler 

string ad = "Zahide Uzun";
Console.WriteLine($"Adı: {ad}");

#endregion 

#region Var 

var number = 123;
Console.WriteLine(number); //123
number = 456;
Console.WriteLine(number); //456

var name = "Zahide"; 


#endregion 






enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

