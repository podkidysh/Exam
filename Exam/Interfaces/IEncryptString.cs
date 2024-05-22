using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Interfaces
{
    internal interface IEncryptString
    {
        byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV);
    }
}
