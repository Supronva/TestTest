using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTextReader
{
    public interface ISentence : IEnumerable<IWord>
    {
        Char Separator { get; }

        Int32 Count { get; }

        String ToString();
    }
}
