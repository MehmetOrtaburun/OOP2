using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class BasvuruManager
    {
        // Method injection 
        public void BasvuruYap(IKrediManager krediManager,List< ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendir
            // Hangi kredi türünü yollarsak yollayalım polimorfizimden dolayı çalışacaktır. 
            krediManager.Hesapla();

            // Sistemde hangi loglayıcı seçilmişse onunla loglanacak. 
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
             
        }

        // Aynı veri türünden verileri tutmak için liste tutrız 
        // IKrediManager tütünden diğer kredi türlerini yollayacağımızdan dolayı Liste oalrak tutlım
        // Bu şekilde birden fazla kredinin hesabını yaparız. 
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler,List<ILoggerService> loggers)
        {
            // bu bilgiileri yazdırmak için foreach ile listedeki her bir kredinin hesabını yaparız.
            foreach (var kredi in krediler )
            {
                foreach (var logger in loggers)
                {
                    kredi.Hesapla();
                    logger.Log();
                }
                
            }

        }

    }
}
