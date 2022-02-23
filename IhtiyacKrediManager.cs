using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // KrediManager kalıtım
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtyaç kredisi ödeme planı hesaplandı"); 
        }
    }
}
