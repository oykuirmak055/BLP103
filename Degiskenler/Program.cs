using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Verilerimize daha kolay ulaşabilmek ve kullanmak için çeşitli değişkenler tanımlarız.
         * Bir değişken tanımlamak için gerekli formül şu şekildedir:
         * Özel anahtar kelimesi + Veri Tipi (int, string, boolean, vb.) + Değişken adı;
         */

        //C# Değişken Tanımlama Kuralları

        //Değişken isimlerinde boşluk bulunmamalıdır.
        //int islem sonucu = 5321017; // Hatalı bir kullanım örneği.
        //int islem_sonucu = 5321017; // Doğru bir kullanım örneği.
        //Değişken isimlerimiz rakam veya özel bir karakter ile başlayamaz.
        //Tanımlayacağımız her değişken için bir veri tipi belirlenmelidir.

        //Örneğin iki tam sayının toplama örneği
        int a = 5, b;
        // her birini ayrı ayrı da tanımlabilirsiniz.
        // int a;
        // int b;

        //sonucu tutacak değişkenimiz, toplama değerleri tam sayı olduğundan;
        int toplamaSonuc;

        a = 6; // değer atama, bu işlem ile a'ya ön tanımlı olan 5 değerini değiştirmiş olduk.
        b = 2222; //değer atama

        toplamaSonuc = a + b; //değer atama + operatörü ile iki tam sayının toplaması

        Console.WriteLine($"{a} + {b} = {toplamaSonuc}");


        //Sabit değişkenler, örneğin PI=3.14 sayısını sabit tanımlama;
        const double PI = 3.14; //PI değişkenin değeri değişemez, değiştiği anda hata verecektir. 

        //veri dönüşümleri
        string sayi1 = "123", sayi2 = "100"; // bu bir tam sayı değil, metinsel veridir.
        // bu nedenle iki değişkenin toplamı iki metnin birleşimidir. sonuç: 123100
        Console.WriteLine(sayi2 + sayi1);

        //fakat içerisindeki değer bir tam sayı değeri fakat string ifade ise bunu tam sayıya dönüştürebiliriz.
        
        Console.WriteLine( int.Parse(sayi2) + Convert.ToInt32(sayi1));
        // int.Parse ile Convert.ToInt32 arasındaki farkı araştırınız.

    }
}