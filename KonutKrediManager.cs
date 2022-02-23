using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // KrediManager kalıtım
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
