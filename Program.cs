try
{

    Console.WriteLine("1. sayıyı giriniz");
    int sayi1 = int.Parse(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    int sonuc = sayi1 / sayi2;
}// Catch bloğu sadece devidebyzero hatalarını yakalar, diğer hiç bir hatayı yakalamaz
catch(DivideByZeroException ex)
{
    // yukarıdaki kod bloğundan iki tür hata meydana gelebilir
    // DevideByZero Exception
    // Format Exception 

    // Catch Bloklarını sadece belirli exceptionları yakalamak için özelleştirebiliriz
    // bunun için, Catch keyword'ünün yanına o exception türünü yazmamız yeterli olacaktır
    Console.WriteLine("ikinci sayı sıfır olmamalı");
}
// format exception hatalarını yakalamak için ne yapabiliriz
// catch blokları çoğaltılabilir
catch(FormatException ex){

    Console.WriteLine("sayı yerine boşluk yada harf yazmayınız");
}