using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bai2
{
    class Expression
    {
        public string Infix;
        public List<string> Postfix = new List<string>();
        public Stack<string> stackForConvert = new Stack<string>();
        public Expression() { }
        public Expression(string Infix)
        {
            this.Infix = Infix;
        }
        public void Input()
        {
            do
            {
                Console.Write("\tNhập biểu thức: ");
                Infix = Console.ReadLine();
                Infix = Regex.Replace(Infix, " ", "");
                Infix = Infix.ToLower();
                if (CheckInfix() == 0)
                    Console.WriteLine("\tCó lỗi xảy ra, vui lòng nhập lại!");
            } while (CheckInfix() == 0);
            Console.WriteLine("\tNhập biểu thức thành công!");
        }
        public int CheckInfix()
        {
            int checkParentheses = 0;
            for (var i = 0; i < Infix.Length; i++)
            {
                if (Infix[i] == '(')
                    checkParentheses++;
                else if (Infix[i] == ')')
                    if (checkParentheses > 0)
                        checkParentheses--;
                    else
                    {
                        checkParentheses = -1;
                        break;
                    }
            }
            if (checkParentheses != 0)
                return 0;
            if (Regex.Match(Infix, @"^(\(?[-+]?(sin\()?(cos\()?(log\()?(ln\()?(sqrt\()?)*\d+(\.\d+)?(\)?\!?)*([-+*/^](\(?[-+]?(sin\()?(cos\()?(log\()?(ln\()?(sqrt\()?)*\d+(\.\d+)?(\)?\!?)*)*$").Success)
                return 1;
            return 0;
        }

        public void ConvertInfixToPostfix()
        {
            int indexOfInfix = 0;
            while (indexOfInfix < Infix.Length)
            {
                if (Infix[indexOfInfix] == '!')
                {
                    stackForConvert.Push(new Node<string>(Infix[indexOfInfix].ToString()));
                    indexOfInfix++;
                }
                else if (Infix[indexOfInfix] >= 97 && Infix[indexOfInfix] <= 122)
                    GetSpecialFuction(ref indexOfInfix);
                else if (Infix[indexOfInfix] == '(' ||
                    Infix[indexOfInfix] == 's' ||
                    Infix[indexOfInfix] == ')')
                    Parentheses(ref indexOfInfix);
                else if (Infix[indexOfInfix] == '+' ||
                    Infix[indexOfInfix] == '-' ||
                    Infix[indexOfInfix] == '*' ||
                    Infix[indexOfInfix] == '/' ||
                    Infix[indexOfInfix] == '^')
                {
                    if (indexOfInfix == 0 || Infix[indexOfInfix-1] == '(')
                        Postfix.Add(StringOfNums(ref indexOfInfix));
                    else if (Infix[indexOfInfix + 1] == '+' ||
                            Infix[indexOfInfix + 1] == '-')
                    {
                        PushNPopOperator(ref indexOfInfix);
                        Postfix.Add(StringOfNums(ref indexOfInfix));
                    }
                    else
                        PushNPopOperator(ref indexOfInfix);
                }
                else if (Infix[indexOfInfix] >= 48 && Infix[indexOfInfix] <= 57)
                    Postfix.Add(StringOfNums(ref indexOfInfix));
            }
            PopAll();
        }
        public void GetSpecialFuction(ref int index)
        {
            string SpecialFunction = "";
            while (Infix[index] != '(')
            {
                SpecialFunction += Infix[index];
                index++;
            }
            index++;
            stackForConvert.Push(new Node<string>(SpecialFunction));
        }
        public void Parentheses(ref int index)
        {
            if (Infix[index] == '(')
                stackForConvert.Push(new Node<string>(Infix[index].ToString()));
            else
            {
                while (stackForConvert.pHead.key == "+" ||
                       stackForConvert.pHead.key == "-" ||
                       stackForConvert.pHead.key == "*" ||
                       stackForConvert.pHead.key == "/" ||
                       stackForConvert.pHead.key == "^")
                    Postfix.Add(stackForConvert.Pop().key);

                if (stackForConvert.pHead.key != "(") 
                    Postfix.Add(stackForConvert.Pop().key);
                else
                {
                    Node<string> temp = stackForConvert.Pop();
                    temp = null;
                }
            }
            index++;
        }
        public string StringOfNums(ref int index)
        {
            int signOfNums = 0;
            string nums = "";
            if(Infix[index] == '+' || Infix[index] == '-')
                while (Infix[index] == '+' || Infix[index] == '-')
                {
                    if (Infix[index] == '-')
                        signOfNums++;
                    index++;
                }
            if (signOfNums % 2 != 0)
                nums += '-';
            while (index < Infix.Length && (Infix[index] >= 48 && Infix[index] <= 57 || Infix[index] == '.'))
            {
                nums += Infix[index];
                index++;
            }
            return nums;
        }
        public void PushNPopOperator(ref int index)
        {
            while (stackForConvert.pHead != null && OperatorPrecedence(Infix[index].ToString()) - OperatorPrecedence(stackForConvert.pHead.key) <= 0)
                Postfix.Add(stackForConvert.Pop().key);
            stackForConvert.Push(new Node<string>(Infix[index].ToString()));
            index++;
        }
        public int OperatorPrecedence(string Operator)
        {
            if (Operator == "+" || Operator == "-")
                return 0;
            else if (Operator == "*" || Operator == "/")
                return 1;
            else if (Operator == "^")
                return 2;
            else return -1;
        }
        public void PopAll()
        {
            while (stackForConvert.pHead != null)
                Postfix.Add(stackForConvert.Pop().key);
        }
        public void PrintPostfix()
        {
            Console.Write("\tPostfix: ");
            foreach (var item in Postfix)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }
    }
}
