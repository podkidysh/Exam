using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Exam.Interfaces;

namespace Exam.Classes
{
    internal class Shifrovanie : IShifr
    {
        public void GetShifr(string data)
        {
            IEncryptString encryptString = new EncryptString(); // Создание экземпляра класса для шифрования
            IDecryptString decryptString = new DecryptString(); // Создание экземпляра класса для дешифрования

            try
            {


                byte[] key = Encoding.UTF8.GetBytes("0123456789ABCDEF0123456789ABCDEF"); // 256-битный (32-байтный) ключ
                byte[] iv = Encoding.UTF8.GetBytes("1234567890ABCDEF"); // 128-битный (16-байтный) вектор

                using (Aes myAes = Aes.Create())
                {
                    byte[] encrypted = encryptString.EncryptStringToBytes_Aes(data, key, iv);
                    Console.WriteLine("Зашифрованная строка: ");
                    Console.WriteLine(Encoding.UTF8.GetString(encrypted));

                    string decrypted = decryptString.DecryptStringFromBytes_Aes(encrypted, key, iv);
                    Console.WriteLine("Дешифрованная строка: ");
                    Console.WriteLine(decrypted);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }      
    }
}
