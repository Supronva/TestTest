using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTextReader
{
    class Word: IWord
    {
        private readonly String WordValue;

        private readonly Int32 LenghtWord;

        public Word(String word)
        {
            WordValue = word;
            LenghtWord = word.Length;
        }

        public string GetWord
        {
            get {return WordValue; }
        }

        public int Lenght
        {
            get { return LenghtWord; }
        }

        public override String ToString()
        {
            return WordValue;
        }
    }
}
