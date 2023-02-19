internal class Program
{
    private static void Main(string[] args)
    {
    
        //girilen saya kadar olan çift sayıların toplamını yazdırır
        Console.WriteLine("bir sayı giriniz");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;
        for (int i = 1; i < sayi; i++)
        {
            
            if (i % 2 == 0)
                toplam += i;

        }
        Console.WriteLine("toplam:" + toplam);
    }
}