using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Interfaces;
namespace Exam.Classes
{
    internal class SayInfoForUser : ISayIFU
    {
        public void SayInfo()
        {
            Console.WriteLine("Введите строку дял шифрования: ");
            string dataForShifr = Console.ReadLine();
            IShifr shifr = new Shifrovanie(); // Создание экземпляра класса шифрования
            shifr.GetShifr(dataForShifr);

            Console.WriteLine("Введите строку для хеширования: ");
            string dataForHash = Console.ReadLine();
            IHash hash = new Hashirovanie(); // Создание экземпляра класса хэширования
            string hashedString = hash.GetHash(dataForHash);
            Console.WriteLine("Хэш строки: " + hashedString);
            Console.WriteLine("=================================");
        }
    }
}
