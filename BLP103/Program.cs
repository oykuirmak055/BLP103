internal class Program
{
    private static void Main(string[] args)
    {
        // Console sınıfı içinde bir metotdur (fonsiyon), konsola çıktı gönderir.
        Console.Write("Merhaba C# ");

        // Console sınıfı içinde bir metotdur (fonsiyon), konsola çıktı gönderir.
        //write metotu ile aynı işi yapar ancak çıktıyı gönderdikten sonra satırbaşı yapar (\r\n)
        Console.WriteLine("Bu ilk programımızın çıktısıdır.");

        // ***************************************************** //
        // Console çıktılarının çeşitleri

        Console.WriteLine("Merhaba, ");
        Console.WriteLine("Programlama Temelleri dersine hoş geldiniz.");

        Console.WriteLine("Çıktı alanında matematiksel ve aritmatiksel işlemler yapılabilir: ");
        Console.WriteLine("Örneğin: 2+2 = " + (2 + 2));
        //Yukarıdaki işlemde 2+2 mesaj olarak verilmiş ve sonucu 2+2 olarak çıktı hesaplanmıştır. İki mesajı + ile birleştirdik.

        //Yer tututcu operatör {} ile konsolda çıktı verilmesi
        Console.WriteLine("{0}, {1} \nörneğin {2}{3}{4}={5}",
            "Merhaba", "yer tutucu operatör ile 0'dan başlarak parametre sayısı kadar mesaj verebiliriz.",
            2, "+", 2, (2 + 2));

        //Yer tututcu operatör $ ile konsolda çıktı verilmesi
        Console.WriteLine($"\nDiğer bir parametre çeşiti; Örneğin {2}+{2}={2+2}");

        // escape character -> \
        // Bu karakter ile bir satır aşağıya geçiş yapılabilir \n
        // satır başı yapılabilir \r
        // ya da ekran çıktılarında  \ " ' gibi karakterleri komut dışına atar
        // Örneğin ekrana \ " ' yazdırmak için;
        Console.WriteLine("Bir satır aşağıdan başla \r\n ekrana yaz:  \\ \" \'");

        /*Değişken tipleri
         C# dilindeki temel veri türleri için tamsayı, kesirli sayı, decimal, char, string ve boolean veri tipleri şeklinde kategoriler kullanılabilir. Aşağıda C# veri tipleri (C# data types) gözükmektedir.

            byte : Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.
            sbyte : Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır.
            short : Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.
            ushort : Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.
            int : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.
            uint : Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.
            long : Uzunluğu 8 byte’tır, -1020 ile 1020 arasında değer alır.
            ulong : Uzunluğu 8 byte’tır, 0 ile 2 x 1020 arasında değer alır.
            float : Uzunluğu 4 byte’tır, 1.5 x 10-45 ile 3.4 x 1038 arasında değer alır.
            double : Uzunluğu 8 byte’tır, 5.0 x 10-324 ile 1.7 x 10308 arasında değer alır.
            decimal : Uzunluğu 12 byte’tır, ±1.0 x 10-28 ile ±7.9 x 1028 arasında değer alır.
            char : Uzunluğu 2 byte’tır, Bütün ınicode karakterleri kapsar.
            string : Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.
            boolean : True – false değer tutan tiptir.
         */

        Console.ReadKey();
        // konsol ekranında veri girişi olana kadar ekranda kal, komutu.
    }
}