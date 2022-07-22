


//#region HesapMakinesi
////1) Conditionals ve Methods
////Algoritma:
////1) Kullanıcıdan ilk sayı istenir.
////2) Kullanıcıdan ikinci sayı istenir.
////3) Kullanıcıdan yapılması istenen işlem istenir (+, -, *, /).
////4) Kullanıcının yaptığı girişlere göre hesaplama işlemi yapılır.
////5) Hesap sonucu ekrana yazdırılır.

////İpucu:
////Sayısal tipte bir değişkene herhangi bir sayısal değer atanabildiği gibi herhangi bir aritmetik işlem yapılarak bu işlemin sonucu da atanabilir.

////Örnek 1:
////double sayi = 1;
////double toplam = 2 + 3;

////Örnek 2:
////double sayi1 = 4;
////double sayi2 = 5;
////double carpim = sayi1 * sayi2;

//double number1, number2;


//Console.Write("İşlem yapmak istediğiniz ilk sayıyı giriniz: ");
//number1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("İşlem yapmak istediğiniz ikinci sayıyı giriniz: ");
//number2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Yapmak istediğiniz işlemi giriniz (+ , - , * , / , %) : ");
//string islem = Console.ReadLine();




//Calculate(number1, number2, islem);

//static void Calculate(double number1, double number2, string islem)
//{
//    double result =0; // neden?? 
//    switch (islem)
//    {
//        case "+":
//            result = number1 + number2;
//            break;
//        case "-":
//            result = number1 - number2;
//            break;
//        case "*":
//            result = number1 * number2;
//            break;
//        case "/":
//            result = number1 / number2;
//            break;
//        case "%":
//            result = number1 % number2;
//            break;
//        default:
//            Console.WriteLine("Yanlış işlem girdiniz!!!!!");
//            break;
//    }
//    Console.WriteLine(" Sonuç: " + " " + result);
//    Console.ReadLine();

//}

//#endregion 

//Console.Clear();

//#region YasHesaplama

////5) DateTime(Bonus)
////Ekrandan kullanıcının doğum tarihini alan ve yaşını hesaplayan basit bir konsol uygulaması.
////1 - Kullanıcıdan doğum tarihi istenir
////2 - Yaş hesaplanır
////3 - Ekrana yaş yazdırılır


//Console.Write("Doğum yılınızı giriniz.  : ");
//int tarih = Convert.ToInt32(Console.ReadLine());

//int mevcutYil = DateTime.Now.Year;
//int yas = mevcutYil - tarih;


//Console.WriteLine(yas + " " + " yaşındasınız.");
//Console.ReadLine();


//#endregion

//Console.Clear();

//#region Faktoriyel
////Faktoriyel:
////Bir sayının sürekli 1 azaltılarak arka arkaya yapılan çarpım faktoriyeldir.
////Örneğin 5 faktoriyel 5! şeklinde gösterilir ve 5! = 5 * 4 * 3 * 2 * 1 olarak hesaplanır.
////Basit bir faktoriyel hesaplama konsol uygulaması yazınız:
////1) Kullanıcıdan tek seferlik pozitif bir tam sayı alınır.
////2) Kullanıcının girdiği sayının faktoriyeli hesaplanarak ekrana yazdırılır.


//Console.Write("Bir sayi giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int faktoriyel = 1;
//for (int i = 1; i <= sayi; i++)
//{
//    faktoriyel *= i;
//}
//Console.WriteLine(sayi + "! = " + faktoriyel);

//Console.ReadLine();


//#endregion


//Console.Clear();

#region palindrom

Console.WriteLine("Bir kelime giriniz");
string deger = Console.ReadLine();
string degerters="";

if (deger.Contains("q") || deger.Length<3)
{
    Console.WriteLine("HATALI GİRİŞ!!");
}
else
{
    for (int i = deger.Length-1; i>=0 ; i--)
    {
        degerters += deger[i];
    }
    if(deger==degerters)
        Console.WriteLine("Palindrom kelime!");
    else
        Console.WriteLine("Palindrom kelime değildir!");
    
}
#endregion