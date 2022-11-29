internal class Program
{
    private static void Main(string[] args)
    {
        int a = 15, b = 5;
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

       

    }
}