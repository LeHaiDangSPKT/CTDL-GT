using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai3_Winform
{
    public class Meaning
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
    public class Word
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
    }
}
