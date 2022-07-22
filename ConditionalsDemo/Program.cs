Console.Write("sayı giriniz: "); // kullanici bana metinsel bir tip olarak yazacak. benim bunu sayisala dönüstürmem gerek.
string veri = Console.ReadLine();
int sayi = Convert.ToInt32(veri);
if (sayi > 0)
    Console.WriteLine("pozitif");
else if (sayi < 0)
    Console.WriteLine("negatif");
else
    Console.WriteLine("sıfır");


/* 
  1.kullaniciya 1.vize sorulur
  2.kullanicidan 2.vize alinir
  3.kullaniciya 2.vize sorulur
  4.kullanicidan 2.vize alınır. 
  5.kullaniciya final sorulur.
  6.kullanicidan final alinir. 
  7.vize1 * 0.2 + vize2 * 0.2 + final * 0.6 hesabiyla ortalama hesaplanir.
  8.ortalama 60'tan büyük eşit ise gecti yazdirilir. ortalama ile birlikte
  9.ortalama 60'tan küçük ise kaldı yazdirilir. ortalama ile birlikte
  10. bitir.
  
 */

Console.Write("1.vize notunuzu giriniz: ");
string input = Console.ReadLine();
double vize1 = Convert.ToDouble(input);

Console.Write("2.vize notunuzu giriniz: ");
string input1 = Console.ReadLine();
double vize2 = Convert.ToDouble(input1);

Console.Write("Final notunuzu giriniz: ");
string input2 = Console.ReadLine();
double final = Convert.ToDouble(input2);

double ortalama = ((vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6));

Console.WriteLine("Ortalama: " + ortalama);

if (ortalama >= 60)
    Console.WriteLine("Geçti (" + ortalama + ")");
else if (ortalama < 60)
    Console.WriteLine("Kaldı (" + ortalama + ")");


// tl olarak kullanicidan para alicaz dolar ve euro karsiligini almak istiyorum. 

const double dolarKuru = 16.76; //basina const double eklersen sabit olur degistiremezsin. 
const double euroKuru = 17.48; 

double tl;
double dolar;
double euro;

Console.Write("TL giriniz: ");
tl = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Dolar (d) , Euro (e): ");
string paraBirimi = Console.ReadLine();

//1.kullanim if / else 

if (paraBirimi == "d")
{
    dolar = tl / dolarKuru;
    Console.WriteLine("Dolar: " + dolar);
}
else if (paraBirimi == "e")
{
    Console.WriteLine("Euro: " + (tl / euroKuru));
}
else
    Console.WriteLine("Dolar veya Euro girmediniz!!!!");

//2.kullanim switch / case 
switch (paraBirimi)
{
    case "d": Console.WriteLine("Dolar: " + tl / dolarKuru); 
        break;
    case "e": Console.WriteLine("Euro: " + tl / euroKuru);
        break; 
    default: Console.WriteLine("Dolar veya Euro girmediniz!!!!");
        break; 
}