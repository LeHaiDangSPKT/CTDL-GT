using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;

namespace Bai3_Winform
{
    public class HashTable
    {
        public LIST[,] hashtable = new LIST[26, 50];
        public List<Word> history = new List<Word>();
        public HashTable()
        {
            for (var i = 0; i < 26; i++)
                for (var j = 0; j < 50; j++)
                    hashtable[i, j] = new LIST();
        }
        public void AddDictionary()
        {
            string[] lines = File.ReadAllLines(@"TuDien.txt");

            int section = 0;
            string word;
            int Proper;
            string WordType;
            string meaning;
            foreach (var line in lines)
            {
                section = 0;
                word = "";
                Proper = 0;
                WordType = "";
                meaning = "";
                foreach (var c in line)
                    if (c == '_')
                        section++;
                    else if (section == 0)
                        word += c;
                    else if (section == 1)
                        if (c == '0')
                            Proper = 0;
                        else
                            Proper = 1;
                    else if (section == 2)
                        WordType += c;
                    else if (section == 3)
                        meaning += c;
                    word = Regex.Replace(word, @"\s+", " ");
                    word = word.Trim();
                    word = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());
                    if (SearchItem(word) == null)
                        AddItem(new Word(word, Proper, WordType, meaning));
                    else
                        SearchItem(word).meanings.Add(new Meaning(Proper, WordType, meaning));
            }

        }
        public void AddItem(Word word)
        {
            hashtable[HashFunction(word.word).Item1, HashFunction(word.word).Item2].AddLast(word);
        }
        public Tuple<int, int> HashFunction(string str)
        {
            return Tuple.Create(str.ToLower()[0] - 97, str.Length);
        }

        public Word SearchItem(string word)
        {
            Word searchWord = hashtable[HashFunction(word).Item1, HashFunction(word).Item2]
                .SeachItem(word);
            return searchWord;
        }

        public void PrintTable()
        {
            for (var i = 0; i < 26; i++)
            {
                Console.Write("{0} -> ", Char.ConvertFromUtf32(i + 97));
                for (var j = 0; j < 50; j++)
                    hashtable[i, j].PrintList();
                Console.WriteLine();
            }
        }
    }
}
