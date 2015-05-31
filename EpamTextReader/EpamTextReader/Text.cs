using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace EpamTextReader
{
    public class Text : IEnumerable<ISentence>
    {
        public IList<ISentence> SentenceList;

        private string FilePath;

        public int Count
        {
            get { return SentenceList.Count; }
        }

        public Text()
        {
            SentenceList = new List<ISentence>();
            FilePath = "";
        }

        public Text(string filePath)
        {
            SentenceList = new List<ISentence>();
            ReadFromFile(filePath);
        }

        public void ReadFromFile(string filePath)
        {

            //FilePath = filePath;
            //string pattern = @"([А-ЯA-Z]((т.п.|т.д.|пр.)|[^?!.\(]|\([^\)]*\))*[.?!])";
            //string line;
            StreamReader file = File.OpenText(FilePath);

            while ((line = file.ReadLine()) != null)
            {
                var sents = System.Text.RegularExpressions.Regex.Matches(line, pattern);
                foreach (var s in sents)
                {
                    Console.WriteLine(s);

                }

            }
            
        }

        public IEnumerator<ISentence> GetEnumerator()
        {
            return SentenceList.GetEnumerator();
        }

       IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}