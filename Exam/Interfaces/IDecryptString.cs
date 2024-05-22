using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Interfaces
{
    internal interface IDecryptString
    {
        string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV);
    }
}
