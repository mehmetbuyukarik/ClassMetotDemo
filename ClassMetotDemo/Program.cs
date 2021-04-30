using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.Id = 1;
                musteri1.FirstName = "Mehmet";
                musteri1.LastName = "Büyükarık";
                musteri1.AccountNumber = 26;
            }
            Musteri musteri2 = new Musteri();
            {
                musteri2.Id = 2;
                musteri2.FirstName = "Semih";
                musteri2.LastName = "Büyükarık";
                musteri2.AccountNumber = 22;
            }
            MusteriManager MusteriManager = new MusteriManager();

            MusteriManager.AddMusteri(musteri1);
            Console.WriteLine("     ");
            MusteriManager.RemoveMusteri(musteri2);


        }
    }
}
