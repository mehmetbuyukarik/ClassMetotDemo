using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        string AddCustomerSuccessfull = "Müşteri Sisteme Başarıyla Eklendi";
        string AddCustomerTemplate = "Müşteri Bilgileri";

        public void AddMusteri(Musteri musteri)
        {
            Console.WriteLine(AddCustomerTemplate);
            Console.WriteLine("             ");
            Console.WriteLine("Id: " + musteri.Id);
            Console.WriteLine("İsim: " + musteri.FirstName);
            Console.WriteLine("Soyad: " + musteri.LastName);
            Console.WriteLine("Hesap No: " + musteri.AccountNumber);
            Console.WriteLine("             ");
            Console.WriteLine(AddCustomerSuccessfull);
        }
        public void RemoveMusteri(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sistemden Silindi");
            Console.WriteLine("Müşteri No: " + musteri.Id);
        }
    }
}
