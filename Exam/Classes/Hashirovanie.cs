using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Exam.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Exam.Classes
{
    internal class Hashirovanie : IHash
    {
        public string GetHash(string data)
        {
            using (SHA256 sha256Hash = SHA256.Create()) // Хэширование при помощи встроенной функции sha256
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
