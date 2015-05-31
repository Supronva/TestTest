using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTextReader
{
    public interface IWord
    {
        String GetWord { get; }

        Int32 Lenght { get; }

        String ToString();
    }
}
