using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Meaning
    {
        public int Proper;
        public string WordType;
        public string meaning;

        public Meaning(int Proper, string WordType, string meaning)
        {
            this.Proper = Proper;
            this.WordType = WordType;
            this.meaning = meaning;
        }
    }
    class Word
    {
        public string word;
        public List<Meaning> meanings = new List<Meaning>();
        public Word() { }
        public Word(string word, int Proper, string WordType, string meaning)
        {
            this.word = word;
            this.meanings.Add(new Meaning(Proper, WordType, meaning));
        }
        public Word(string word, Meaning meaning)
        {
            this.word = word;
            this.meanings.Add(meaning);
        }
        public Word(Word word)
        {
            this.word = word.word;
            this.meanings = word.meanings;
        }
        public void PrintWord()
        {
            Console.WriteLine("\tTừ: {0}", word);
            Console.WriteLine("\tNghĩa thông thường ({0}): ", word.ToLower());
            foreach(var meaning in meanings)
            {
                if(meaning.Proper == 0)
                    Console.WriteLine("\t{0} - {1};", meaning.WordType, meaning.meaning);
            }
            Console.WriteLine("\tTên riêng ({0}):", word);
            foreach (var meaning in meanings)
            {
                if (meaning.Proper == 1)
                    Console.WriteLine("\t{0} - {1};", meaning.WordType, meaning.meaning);
            }
        }
    }
}
