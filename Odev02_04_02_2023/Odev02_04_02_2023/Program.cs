namespace Odev02_04_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vize Notunu Giriniz: ");
            int vize = int.Parse(Console.ReadLine());

            Console.Write("Final Notunu Giriniz: ");
            int final = int.Parse(Console.ReadLine());

            if (vize>100 || final>100) Console.WriteLine("100'den büyük bir not girdiniz");

            int basari = (((vize * 40) / 100) + ((final * 60) / 100));

            if (basari >= 60) 
            {
                Console.WriteLine("Başarılı");
            }
            else if (basari < 60) 
            {
                Console.WriteLine("Başarısız");
            }
                
            }
        }
    }