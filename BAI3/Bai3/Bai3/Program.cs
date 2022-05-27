using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Bai3
{
    class Program
    {
        public static HashTable hashTable = new HashTable();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            hashTable.AddDictionary();
            Menu();
        }
        public static void Tittle()
        {
           
        }
        public static void Menu()
        {
            Console.WriteLine("\t\t     MENU");
            Console.WriteLine("\t\t1.Tra cứu từ từ");
            Console.WriteLine("\t\t2.Lịch sử tra cứu");
            Console.WriteLine("\t\t3.Thêm từ");
            Console.WriteLine("\t\t4.Thêm nghĩa");
            Console.WriteLine("\t\t5.Xóa từ");
            Console.WriteLine("\t\t6.Xóa nghĩa");
            Console.WriteLine("\t\t7.In tất cả các từ");
            
            switch(Input0())
            {
                case 1:
                    Input1();
                    Console.WriteLine("\tNhấn một phím bất kì để tiếp tục!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    History();
                    Console.WriteLine("\tNhấn một phím bất kì để tiếp tục!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    AddNewWord();
                    Console.WriteLine("\tNhấn một phím bất kì để tiếp tục!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    AddNewMeaning();
                    Console.WriteLine("\tNhấn một phím bất kì để tiếp tục!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 5:
                    RemoveWord();
                    Console.WriteLine("\tNhấn một phím bất kì để tiếp tục!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 6:
                    RemoveMeaning();
                    Console.WriteLine("\tNhấn một phím bất kì để tiếp tục!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 7:
                    PrintAll();
                    Console.Clear();
                    Menu();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        public static int Input0()
        {
            bool checkInput = false;
            int Input = 0;
            do
            {
                try
                {
                    Console.Write("\t\tNhập yêu cầu: ");
                    Input = Convert.ToInt32(Console.ReadLine());
                    if (Input < 1 || Input > 7)
                        throw new ArgumentOutOfRangeException();
                    checkInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\t\tYêu cầu chỉ nhập số!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("\t\tYêu cầu nhập trong khoảng từ 1 - 7");
                }
            } while (!checkInput);

            return Input;
        }

        public static void Input1()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\tTRA CỨU");
            string Input;
            Word word;
            Console.Write("\tNhập từ cần tra cứu: ");
            Input = Console.ReadLine();
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            Console.WriteLine("\t\t---=%=---");
            if (word == null)
            {
                Console.WriteLine("\tKhông tìm thấy từ \"{0}\" ", Input);
                hashTable.history.Add(new Word(Input, null));
            }
            else
            {
                word.PrintWord();
                hashTable.history.Add(word);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }

        public static void History()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\tLỊCH SỬ TRA CỨU");
            Console.WriteLine("\t\t---=*=---");
            foreach (var item in hashTable.history)
            {
                if (item.meanings.Contains(null))
                {
                    Console.WriteLine("\tTừ: {0}", item.word);
                    Console.WriteLine("\tKhông tìm thấy từ!");
                }
                else
                {
                    item.PrintWord();
                }
                Console.WriteLine("\t\t---=*=---");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public static void AddNewWord()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\tTHÊM TỪ");
            string Input;
            Word word;
            Console.Write("\tNhập từ muốn thêm: ");
            Input = Console.ReadLine();
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);

            if (word != null)
                Console.WriteLine("\tTừ \"{0}\" đã tồn tại", Input);
            else
            {
                int numsOfMeaning = 0;
                bool checkInput = false;
                do
                {
                    try
                    {
                        Console.Write("\tNhập số ý nghĩa: ");
                        numsOfMeaning = Convert.ToInt32(Console.ReadLine());
                        if (numsOfMeaning < 1)
                            throw new ArgumentOutOfRangeException();
                        checkInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\tYêu cầu chỉ nhập số!");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("\tYêu cầu nhập lớn hơn 1");
                    }
                } while (!checkInput);

                for(var i = 0; i < numsOfMeaning; i++)
                {
                    Console.WriteLine("\tNghĩa {0}: ", i+1);
                    if (i == 0)
                        hashTable.AddItem(new Word(Input, ProperInput(), WordTypeInput(), MeaningInput()));
                    else
                        hashTable.SearchItem(Input).meanings.Add(new Meaning(ProperInput(), WordTypeInput(), MeaningInput()));
                }

            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public static int ProperInput()
        {
            Console.WriteLine("\t=====================");
            Console.WriteLine("\tNHẬP LOẠI NGHĨA");
            Console.WriteLine("\t\t1.Nghĩa bình thường");
            Console.WriteLine("\t\t2.Tên riêng");
            int Input = 0;
            bool checkInput = false;
            do
            {
                try
                {
                    Console.Write("\tNhập loại nghĩa: ");
                    Input = Convert.ToInt32(Console.ReadLine());
                    if (Input < 1 || Input > 9)
                        throw new ArgumentOutOfRangeException();
                    checkInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\t\tYêu cầu chỉ nhập số!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("\t\tYêu cầu nhập 1 - 2!");
                }
            } while (!checkInput);

            switch (Input)
            {
                case 1:
                    return 0;
                case 2:
                    return 1;
                default:
                    return -1;
            }
        }
        public static string WordTypeInput()
        {
            Console.WriteLine("\t=====================");
            Console.WriteLine("\tNHẬP TỪ LOẠI");
            Console.WriteLine("\t\t1.Noun(Danh từ)");
            Console.WriteLine("\t\t2.Verb(Động từ)");
            Console.WriteLine("\t\t3.Adjective(Tính từ)");
            Console.WriteLine("\t\t4.Adverb(Trạng từ)");
            Console.WriteLine("\t\t5.Preposition(Giới từ)");
            Console.WriteLine("\t\t6.Determiners(Từ hạn định)");
            Console.WriteLine("\t\t7.Pronouns(Đại từ)");
            Console.WriteLine("\t\t8.Conjunctions(Liên từ)");
            Console.WriteLine("\t\t9.Interjections(Thán từ)");
            int Input = 0;
            bool checkInput = false;
            do
            {
                try
                {
                    Console.Write("\tNhập loại từ: ");
                    Input = Convert.ToInt32(Console.ReadLine());
                    if (Input < 1 || Input > 9 )
                        throw new ArgumentOutOfRangeException();
                    checkInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\t\tYêu cầu chỉ nhập số!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("\t\tYêu cầu nhập 1 - 9!");
                }
            } while (!checkInput);

            switch (Input)
            {
                case 1:
                    return "Noun(Danh từ)";
                case 2:
                    return "Verb(Động từ)";
                case 3:
                    return "Adjective(Tính từ)";
                case 4:
                    return "Adverb(Trạng từ)";
                case 5:
                    return "Preposition(Giới từ)";
                case 6:
                    return "Determiners(Từ hạn định)";
                case 7:
                    return "Pronouns(Đại từ)";
                case 8:
                    return "Conjunctions(Liên từ)";
                case 9:
                    return "Interjections(Thán từ)";
                default:
                    return "Không rõ";
            }
        }

        public static string MeaningInput()
        {
            Console.WriteLine("\t=====================");
            Console.WriteLine("\tNHẬP NGHĨA");
            string Input;
            Console.Write("\tNhập nghĩa của từ: ");
            Input = Console.ReadLine();
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            return Input;
        }
        public static void AddNewMeaning()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\tTHÊM NGHĨA");
            string Input;
            Word word;
            Console.Write("\tNhập từ muốn thêm nghĩa: ");
            Input = Console.ReadLine();
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            if (word == null)
                Console.WriteLine("\tKhông tìm thấy từ \"{0}\" ", Input);
            else
                word.meanings.Add(new Meaning(ProperInput(), WordTypeInput(), MeaningInput()));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public static void RemoveWord()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            string Input;
            Word word;
            Console.Write("\tNhập từ muốn xóa: ");
            Input = Console.ReadLine();
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            if (word == null)
                Console.WriteLine("\tKhông tìm thấy từ \"{0}\" ", Input);
            else
            {
                LIST list = hashTable.hashtable[hashTable.HashFunction(word.word).Item1, hashTable.HashFunction(word.word).Item2];
                if (list.pHead.key == word)
                    list.RemoveFirst();
                else if (list.pTail.key == word)
                    list.RemoveLast();
                else
                {
                    Node temp = list.pHead;
                    while (temp.pNext.key != word)
                        temp = temp.pNext;
                    list.RemoveAfter(temp);
                }
                Console.WriteLine("\tĐã xóa từ \"{0}\"!", Input);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public static void RemoveMeaning()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            string Input;
            Word word;
            Console.Write("\tNhập từ muốn xóa nghĩa: ");
            Input = Console.ReadLine();
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            if (word == null)
                Console.WriteLine("\tKhông tìm thấy từ \"{0}\" ", Input);
            else
            {
                Console.WriteLine("\tDanh sách nghĩa của từ \"{0}\"", Input);
                int index = 1;
                foreach (var meaning in word.meanings)
                {
                    Console.WriteLine("\t{0}. {1} - {2} - {3}", index, meaning.Proper, meaning.WordType, meaning.meaning);
                    index++;
                }
                int posOfMeaning = 0;
                bool checkInput = false;
                do
                {
                    try
                    {
                        Console.Write("\tNhập vị trí nghĩa muốn xóa: ");
                        posOfMeaning = Convert.ToInt32(Console.ReadLine());
                        if (posOfMeaning < 1 || posOfMeaning > index)
                            throw new ArgumentOutOfRangeException();
                        checkInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\t\tYêu cầu chỉ nhập số!");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("\t\tYêu cầu nhập 1 - 9!");
                    }
                } while (!checkInput);
                word.meanings.Remove(word.meanings[posOfMeaning-1]);
                Console.WriteLine("\tĐã xóa nghĩa của từ \"{0}\"!", Input);
            }
        }
        public static void PrintAll()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\tIN RA HASHTABLE");
            hashTable.PrintTable();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
    }
}
