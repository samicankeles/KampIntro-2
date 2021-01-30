using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKrediManager : ICrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi ödeme planı hesaplandı");
        }
    }
}

