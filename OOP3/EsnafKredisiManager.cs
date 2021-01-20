using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi ödeme Planı Hesaplandı");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
