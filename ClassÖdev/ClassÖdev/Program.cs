using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaBilgileri araba = new ArabaBilgileri()
            {
                Id = 1,
                Marka = "Porsche",
                Model = "Panamera",
                MotorHacmi = 4000.2,
                BeygirGucu = 550,
                MaxHız = 304,
                SıfırdanYuzeHizlanma = 3.3,
                KapiSayisi = 4,
                C_Tur = CekisTur.DortCeker,
                Agirlik = 2000.4,
                A_Tur = ArabaTürü.Binek,
                CıkısYili = new DateTime(2020, 5, 19)

            };

            Console.WriteLine("                                                 Arabalar                                        ");
            Console.WriteLine("1.Araba :");
            Console.WriteLine("Id: " + araba.Id);
            Console.WriteLine("Marka: " + araba.Marka);
            Console.WriteLine("Model: " + araba.Model);
            Console.WriteLine("Motor: " + araba.MotorHacmi);
            Console.WriteLine("Beygir: " + araba.BeygirGucu);
            Console.WriteLine("MaxHız: " + araba.MaxHız);
            Console.WriteLine("0-100: " + araba.SıfırdanYuzeHizlanma);
            Console.WriteLine("Çekiş: " + araba.C_Tur + " (*" + (int)araba.C_Tur + "*) ");
            Console.WriteLine("Ağırlık: " + araba.Agirlik);
            Console.WriteLine("Kapı Sayısı: " + araba.KapiSayisi);
            Console.WriteLine("Araba Türü: " + araba.A_Tur + " (*" + (int)araba.A_Tur + "*) ");
            Console.WriteLine("Çıkış Yılı: " + araba.CıkısYili.ToShortDateString());

            Console.WriteLine();

            ArabaBilgileri araba2 = new ArabaBilgileri()
            {
                Id = 2,
                Marka = "Lamborghini",
                Model = "Aventedor",
                MotorHacmi = 6000.5,
                BeygirGucu = 900,
                MaxHız = 400,
                SıfırdanYuzeHizlanma = 1.2,
                KapiSayisi = 2,
                C_Tur = CekisTur.ÖndenCekis,
                Agirlik = 2500.1,
                A_Tur = ArabaTürü.Binek,
                CıkısYili = new DateTime(2019,04,15)
                
            };


            Console.WriteLine("2.Araba");
            Console.WriteLine("Id: " + araba2.Id );
            Console.WriteLine("Marka : " + araba2.Marka);
            Console.WriteLine("Model : " + araba2.Model);
            Console.WriteLine("Motor: " + araba2.MotorHacmi);
            Console.WriteLine("Beygir: " + araba2.BeygirGucu);
            Console.WriteLine("MaxHız: " + araba2.MaxHız);
            Console.WriteLine("0-100: " + araba2.SıfırdanYuzeHizlanma);
            Console.WriteLine("Çekiş: " + araba2.C_Tur + " (*" + (int)araba2.C_Tur + "*) ");
            Console.WriteLine("Ağırlık: " + araba2.Agirlik);
            Console.WriteLine("Kapı Sayısı: " + araba2.KapiSayisi);
            Console.WriteLine("Araba Türü: " + araba2.A_Tur + " (*" + (int)araba2.A_Tur + "*) ");
            Console.WriteLine("Cıkış Yılı: " + araba2.CıkısYili.ToShortDateString());

            Console.ReadLine();






        }
    }
        
        
    
}
