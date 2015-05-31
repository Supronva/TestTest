using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace EpamTextReader
{
    class Sentence : ISentence
    {
        public IList<IWord> WordList;

        public readonly Char SeparatorSentence;

        public char Separator
        {
            get { return SeparatorSentence; }
        }

        public int Count
        {
            get { return WordList.Count; }
        }

        public Sentence(String sentence, Char separator = ' ')
        {
            WordList = new List<IWord>();
            SeparatorSentence = separator;
            foreach (var item in sentence.Split(separator))
                WordList.Add(new Word(item));
        }

        public override String ToString()
        {
            return WordList.Aggregate("", (current, item) => current + item.GetWord + SeparatorSentence);
        }

        public IEnumerator<IWord> GetEnumerator()
        {
            return WordList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
