using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        /* int a = 15, b = 5;
         Console.WriteLine("{0} {1} {2} = {3}", a, "+", b, a + b);
         Console.WriteLine("{0} {1} {2} = {3}", a, "-", b, a - b);
         Console.WriteLine("{0} {1} {2} = {3}", a, "/", b, a / b);
         Console.WriteLine("{0} {1} {2} = {3}", a, "*", b, a * b);
         Console.WriteLine("{0} {1} {2} = {3}", a, "%", b, a % b);
         Console.WriteLine("{0} {1} {2} = {3}", a, "^", b, a ^ b);
         // yukarıda işlem operatörleri kullanılmıştır.

         //aşağıdaki çıktıları inceleyiniz
         int x, y, sonuc;
         float fsonuc;

         x = 7;
         y = 5;

         sonuc = x / y;
         Console.WriteLine("x / y: {0}", sonuc); //sonuc tam sayı olduğundan sonuç 1'dir.

         fsonuc = (float)x / y;
         Console.WriteLine("x / y: {0}", fsonuc); //7 sayısı float tipine dönüştüğünden sonuç float türündedir. 1,4

         fsonuc = x / (float)y;
         Console.WriteLine("x / y: {0}", fsonuc); //5 sayısı float tipine dönüştüğünden sonuç float türündedir. 1,4

         fsonuc = (float)x / (float)y;
         Console.WriteLine("x / y: {0}", fsonuc); //7 ve 5 sayısı float tipine dönüştüğünden sonuç float türündedir. 1,4

         fsonuc = (float)(x / y);
         Console.WriteLine("x / y: {0}", fsonuc); //7 ve 5 tam sayı olduğundan sonuc float değere dönüşünce 1,000000 1 olarak çıkar.

         //Arttırma operatörü

         int sayac = 0;
         Console.WriteLine("Sayaç değeri: " + sayac);
         sayac = sayac + 1;
         Console.WriteLine("Sayaç değeri: "+ sayac);
         sayac++;
         Console.WriteLine("Sayaç değeri: " + sayac);
         sayac +=2 ;
         Console.WriteLine("Sayaç değeri: " + sayac);
         sayac--;
         Console.WriteLine("Sayaç değeri: " + sayac);
         sayac -= 2;
         Console.WriteLine("Sayaç değeri: " + sayac);
         sayac *= 10; // sayac = sayac * 10
         Console.WriteLine("Sayaç değeri: " + sayac);
         sayac = 1;
         Console.WriteLine("---------------");
         Console.WriteLine("Sayaç değeri: " + ++sayac);
         Console.WriteLine("Sayaç değeri: " + sayac);
         Console.WriteLine("Sayaç değeri: " + sayac++);
         Console.WriteLine("Sayaç değeri: " + sayac);*/

        /*
        int sayi1=5, sayi2=6;
        //bool sonuc = sayi1 == sayi2;

        Console.WriteLine("{0} {2} {1} sonuç : {3}",
            sayi1, sayi2, "==", (sayi1 == sayi2));

        Console.WriteLine("{0} {2} {1} sonuç : {3}",
            sayi1, sayi2, "!=", (sayi1 != sayi2));

        Console.WriteLine("{0} {2} {1} sonuç : {3}",
            sayi1, sayi2, ">", (sayi1 > sayi2));

        Console.WriteLine("{0} {2} {1} sonuç : {3}",
            sayi1, sayi2, "<", (sayi1 < sayi2));

        Console.WriteLine("{0} {2} {1} sonuç : {3}",
            sayi1, sayi2, ">=", (sayi1 >= sayi2));

        Console.WriteLine("{0} {2} {1} sonuç : {3}",
            sayi1, sayi2, "<=", (sayi1 <= sayi2));

        sayi1 = 10;
        sayi2 = 30;

        bool mantiksalKarsilastirma;
        mantiksalKarsilastirma = (sayi1 < sayi2) && (sayi2 > 45);
        Console.WriteLine("AND =" +mantiksalKarsilastirma);
        mantiksalKarsilastirma = (sayi1 < sayi2) || (sayi2 > 15);
        Console.WriteLine("OR =" + mantiksalKarsilastirma);
        */

        bool A, B, C, Q;
        A = true; B = false; C = true;
        Q = (A && B || B && C) && (B || C);
        Console.WriteLine("(A && B || B && C) && (B || C) = " + Q);

        A = false; B = true; C = true;
        Q = (A && B || B && C) && (B || C);

        Console.WriteLine("(A && B || B && C) && (B || C) = " + Q); 
    }
}