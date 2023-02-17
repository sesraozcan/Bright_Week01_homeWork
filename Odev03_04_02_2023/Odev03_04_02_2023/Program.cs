using System.Reflection.PortableExecutable;

namespace Odev03_04_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("üssünü alacağınız sayıyı giriniz: ");
            int tabanSayi = int.Parse(Console.ReadLine());
            Console.Write("üssü giriniz: ");
            int usSayi = int.Parse(Console.ReadLine());
            
            if (usSayi==2) 
            {
                double result = Math.Pow(tabanSayi, usSayi);
                Console.WriteLine(result);

            } else if (usSayi==3) 
                    {
                double result = Math.Pow(tabanSayi, usSayi);
                Console.WriteLine(result);
            }
            else if (usSayi != 2 || usSayi!= 3)
            {
                Console.WriteLine("Lütfen üs olarak 2 veya 3 değerlerini giriniz");
                aa
            }
          
        }
    }
}

