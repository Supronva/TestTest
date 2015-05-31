using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTextReader
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Input sentence, separator space: ");
            //var inputText = Console.ReadLine();
            //ISentence sentence = new Sentence(inputText);
            //Console.WriteLine(sentence.Count.ToString());
            //Console.ReadLine();
            Console.WriteLine("Введите путь: ");
            string filePath = Console.ReadLine();
            Text t = new Text(filePath);
           Console.WriteLine(t.SentenceList.Count());

            //Console.WriteLine(t.Count());
            Console.ReadKey();

      }
    }
}
