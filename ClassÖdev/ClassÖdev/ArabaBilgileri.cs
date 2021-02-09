using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassÖdev
{
    class ArabaBilgileri
    {
            public int Id { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public byte KapiSayisi { get; set; }
            public short BeygirGucu { get; set; }
            public int MyProperty { get; set; }
            public ArabaTürü A_Tur { get; set; }
            public short MaxHız { get; set; }
            public CekisTur C_Tur { get; set; }
            public double SıfırdanYuzeHizlanma { get; set; }
            public double Agirlik { get; set; }
            public double MotorHacmi { get; set; }
            public DateTime CıkısYili { get; set; }


    }
}
