using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Bai2
{
    class Program
    {
        public static Calculator calculator = new Calculator();
        public static List<Tuple<string, List<string>, double>> history = new List<Tuple<string, List<string>, double>>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("\t\tMENU");
            Console.WriteLine("\t1.Nhập biểu thức tính toán");
            Console.WriteLine("\t2.Lịch sử tính toán");

            switch (InputMenu())
            {
                case 1:
                    Calculate();
                    Menu();
                    break;
                case 2:
                    History();
                    Menu();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        public static int InputMenu()
        { 
            int Input = 0;
            bool checkInput = false;
            do
            {
                try
                {
                    Console.Write("\tNhập lựa chọn: ");
                    Input = Convert.ToInt32(Console.ReadLine());
                    if (Input < 1 || Input > 2)
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

            return Input;
        }
        public static void Calculate()
        {
            string Infix;
            List<string> Postfix;
            double Result;

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("\t     TÍNH TOÁN");
            Console.WriteLine("\t- Nhập 5 phép tính +, -, *, /, ^ và hai dấu ( ) như thể thức bình thường");
            Console.WriteLine("\t- Những phép tính nâng cao là: sin(a), cos(a), log(a), ln(a), sqrt(a). Với a là số hạng");
            Console.WriteLine("\t- Đối với phép tính ! thì nhập ngay sau số hạng a!");
            Expression expression = new Expression();
            expression.Input();
            Infix = expression.Infix;
            expression.ConvertInfixToPostfix();
            expression.PrintPostfix();
            Postfix = expression.Postfix;
            calculator.AddPostfix(Postfix);
            calculator.Calculation();
            Result = calculator.Result;
            if (double.IsNaN(Result))
                Console.WriteLine("\tKhông có kết quả do lỗi tính toán!");
            else
                Console.WriteLine("\tKết quả: {0}", calculator.Result);
            history.Add(new Tuple<string, List<string>, double>(Infix, Postfix, Result));
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }
        public static void History()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("\t     LỊCH SỬ");
            Console.WriteLine("\t---=%=---");
            foreach (var item in history)
            {
                Console.WriteLine("\tInfix: {0}", item.Item1);
                Console.Write("\tPostfix: ");
                foreach (var s in item.Item2)
                    Console.Write("{0} ", s);
                Console.WriteLine();
                if(double.IsNaN(item.Item3))
                    Console.WriteLine("\tKhông có kết quả do lỗi tính toán!");
                else
                    Console.WriteLine("\tKết quả: {0}", item.Item3);
                Console.WriteLine("\t---=%=---");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }
    }
}
