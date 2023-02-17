namespace Week1_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("öğrencinin birinci notunu giriniz: ");
            int not1 = int.Parse(Console.ReadLine());
            Console.Write("Öğrencinin ikinci notunu giriniz");
            int not2 = int.Parse(Console.ReadLine());

            if (not1>100 || not2>100)
            {
                Console.WriteLine("100 den buyuk puan girdiniz");
            }
            else
            {
                int toplam = not1 + not2;
                decimal ortalama = (decimal)toplam / 2;
                Console.WriteLine("Ortalama: " + ortalama);

                if (ortalama >= 50)
                {
                    Console.WriteLine("Geçti!");
                }
                else if (ortalama < 50)
                {
                    Console.WriteLine("Kaldı!");
                }
            }  
        }
    }
}