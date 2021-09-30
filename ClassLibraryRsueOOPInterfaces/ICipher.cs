using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOPInterfaces
{
    public interface ICipher
    {
        string Text { get; set; }
        void Encode();
        void Decode();

    }
}
