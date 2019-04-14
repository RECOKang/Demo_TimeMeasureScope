using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSF.AOP;
using CSF.Common;

namespace Demo_TimeMeasureScope
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = ProxyFactory.Create<Calculator>();

            var result1 = obj.Addition(11, 11);
            var result2 = obj.Subtraction(10, 11);
            var result3 = obj.Multiplication(10, 11);
            var result4 = obj.Division(10, 1);
            Console.WriteLine($"加法:{result1}\n減法:{result2}\n乘法:{result3}\n除法:{result4}");
            Console.ReadLine();
        }
    }
    public class Calculator : MarshalByRefObject
    {
        //加法
        [TimeMeasure]
        public int Addition(int x, int y) => x + y;
        //減法
        [TimeMeasure]
        public int Subtraction(int x, int y) => x - y;
        //乘法
        [TimeMeasure]
        public int Multiplication(int x, int y) => x * y;
        //除法
        [TimeMeasure]
        public int Division(int x, int y) => x / y;

    }
}
