using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetMenager

    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi:"+urun.adi+" "+ urun.fiyati);
        }
        public void Ekle2(string urunAdi , string aciklamasi ) 
        {
            Console.WriteLine("Sepete Eklendi: "+urunAdi);


        }
    }
}
