using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ICrediManager tasıtKrediManager = new TasıtKrediManager();
            ICrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager() , new List<ILoggerService> {fileLoggerService, new SmsLoggerService(), new DatabaseLoggerService() });

            List<ICrediManager> krediler = new List<ICrediManager>() { tasıtKrediManager,konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 

        }
    }
}
