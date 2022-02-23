using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // KrediManager kalıtım
    class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
