using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;

namespace Bai2
{
    class RealNumberException : Exception
    {
        public RealNumberException() : base() { }
        public RealNumberException(String messsage) : base(messsage) { }
        public RealNumberException(String message, Exception innerException) : base(message, innerException) { }
        public RealNumberException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base() { }
        public NegativeNumberException(String messsage) : base(messsage) { }
        public NegativeNumberException(String message, Exception innerException) : base(message, innerException) { }
        public NegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    class ZeroAnhdNegativeNumberException : Exception
    {
        public ZeroAnhdNegativeNumberException() : base() { }
        public ZeroAnhdNegativeNumberException(String messsage) : base(messsage) { }
        public ZeroAnhdNegativeNumberException(String message, Exception innerException) : base(message, innerException) { }
        public ZeroAnhdNegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    class Calculator
    {
        public List<string> Postfix;
        public double Result;
        public Stack<double> stackForCalculation = new Stack<double>();
        public Calculator() { }
        public Calculator(List<string> Postfix)
        {
            this.Postfix = new List<string>(Postfix);
        }
        public void AddPostfix(List<string> Postfix)
        {
            this.Postfix = new List<string>(Postfix);
        }
        public void Calculation()
        {
            int error = 0;
            double temp2, temp1;
            int indexOfPostfix = 0;
            try
            {
                while (indexOfPostfix < Postfix.Count)
                {
                    if (Postfix[indexOfPostfix] == "+")
                    {
                        temp2 = stackForCalculation.Pop().key;
                        temp1 = stackForCalculation.Pop().key;
                        stackForCalculation.Push(new Node<double>(temp1 + temp2));
                    }
                    else if (Postfix[indexOfPostfix] == "-")
                    {
                        temp2 = stackForCalculation.Pop().key;
                        temp1 = stackForCalculation.Pop().key;
                        stackForCalculation.Push(new Node<double>(temp1 - temp2));
                    }
                    else if (Postfix[indexOfPostfix] == "*")
                    {
                        temp2 = stackForCalculation.Pop().key;
                        temp1 = stackForCalculation.Pop().key;
                        stackForCalculation.Push(new Node<double>(temp1 * temp2));
                    }
                    else if (Postfix[indexOfPostfix] == "/")
                    {
                        temp2 = stackForCalculation.Pop().key;
                        if (temp2 == 0)
                            throw new DivideByZeroException();
                        temp1 = stackForCalculation.Pop().key;
                        stackForCalculation.Push(new Node<double>(temp1 / temp2));
                    }
                    else if (Postfix[indexOfPostfix] == "^")
                    {
                        temp2 = stackForCalculation.Pop().key;
                        temp1 = stackForCalculation.Pop().key;
                        stackForCalculation.Push(new Node<double>(Math.Pow(temp1, temp2)));
                    }
                    else if (Postfix[indexOfPostfix] == "sin")
                    {
                        temp1 = stackForCalculation.Pop().key;
                        stackForCalculation.Push(new Node<double>(Math.Sin(temp1)));
                    }
                    else if (Postfix[indexOfPostfix] == "cos")
                    {
                        temp1 = stackForCalculation.Pop().key;
                        stackForCalculation.Push(new Node<double>(Math.Cos(temp1)));
                    }
                    else if (Postfix[indexOfPostfix] == "log")
                    {
                        temp1 = stackForCalculation.Pop().key;
                        if (temp1 <= 0)
                            throw new ZeroAnhdNegativeNumberException();
                        stackForCalculation.Push(new Node<double>(Math.Log10(temp1)));
                    }
                    else if (Postfix[indexOfPostfix] == "ln")
                    {
                        temp1 = stackForCalculation.Pop().key;
                        if (temp1 <= 0)
                            throw new ZeroAnhdNegativeNumberException();
                        stackForCalculation.Push(new Node<double>(Math.Log(temp1, Math.E)));
                    }
                    else if (Postfix[indexOfPostfix] == "sqrt")
                    {
                        temp1 = stackForCalculation.Pop().key;
                        if (temp1 < 0)
                            throw new NegativeNumberException();
                        stackForCalculation.Push(new Node<double>(Math.Sqrt(temp1)));
                    }
                    else if (Postfix[indexOfPostfix] == "!")
                    {
                        temp1 = stackForCalculation.Pop().key;
                        if (temp1 != (int)temp1)
                            throw new RealNumberException();
                        stackForCalculation.Push(new Node<double>(Factorial(temp1)));
                    }
                    else
                        stackForCalculation.Push(new Node<double>(ConvertStringToNumber(Postfix[indexOfPostfix])));
                    indexOfPostfix++;
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("\tLỗi chia cho 0!");
                error = 1;
            }
            catch (ZeroAnhdNegativeNumberException)
            {
                Console.WriteLine("\tLỗi log() và ln() chứa số không dương!");
                error = 1;
            }
            catch (NegativeNumberException)
            {
                Console.WriteLine("\tLỗi sqrt() chứa số âm!");
                error = 1;
            }
            catch (RealNumberException)
            {
                Console.WriteLine("\tLỗi giai thừa không phải số nguyên!");
                error = 1;
            }
            if (error == 0)
                Result = stackForCalculation.Pop().key;
            else
                Result = double.NaN;
        }
        public double ConvertStringToNumber(string _string)
        {
            return double.Parse(_string, CultureInfo.InvariantCulture.NumberFormat);
        }
        public double Factorial(double nums)
        {
            double factorial = 1;
            for (var i = 1; i <= Math.Abs(nums); i++)
                factorial *= i;
            if (nums < 0)
                factorial *= -1;
            return factorial;
        }
    }
}
