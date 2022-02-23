using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // <ınterfaceler kendisini implemente eden classların referansını tutarlar.
   
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
 
            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>()
            {
                new DatabaseLoggerService(),
                new FileLoggerService(),
                new SmsLoggerService()

            };

            // kredi bilgilerini hesaplamak için liste oluşturalım
            List<IKrediManager> krediler = new List<IKrediManager>() {
                        
                            ihtiyacKrediManager,
                            tasitKrediManager,
                            konutKrediManager
                
            };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler, loggers);
          
        }
    }
}
