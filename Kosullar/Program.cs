internal class Program
{
    private static void Main(string[] args)
    {
        /*
         program akışını mantıksal bir koşula göre saptıran denetim yapılarına if denir.
        if, if-else ve if-if else-else olarka 3 çeşittir.
        
        genel kullanım:
        if(mantıksal_deyim)
         deyim;

        if(mantıksal_deyim)
        {
          deyimler;
        }
                 
         */

        int vize, final;
        Console.Write("Vize notunu gir: ");
        vize = int.Parse(Console.ReadLine());
        Console.Write("Final notunu gir: ");
        final = int.Parse(Console.ReadLine());

        double ort = vize * 0.4 + final * 0.6;
        // ort = (s1+s2+s3) / 3

        Console.WriteLine($"Vize: {vize} , Final: {final}");
        Console.WriteLine($"Ortalama: {ort}");

        if (ort < 50)
        {
            Console.WriteLine("Dersten kaldı !!!");
        }
        else if (ort == 50 || ort > 50)
        {
            Console.WriteLine("Dersi geçti"); ; ; ; ; ;
        }

        //Klavyeden girilen bir sayının mutlak değerini yazan program (vize sorusu)

        Console.Write("Bir sayı giriniz: ");
        int x = int.Parse(Console.ReadLine());

        if (x >= 0)
        {
            Console.WriteLine("Sayı pozitif. Mutlak alınmadı.");
        }
        else
        {
            Console.WriteLine($"Sayı negatif, mutlak değer alınacak. |{(x * -1)}|");
        }
    }
}