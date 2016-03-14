using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请选择模式（1、分数 2、整数 3、混合）：");
            String numType = Console.ReadLine();
            switch (numType)
            {
                case "1": Fraction(); break;
                case "2": Integer(); break;
                case "3": Mixture(); break;
                default: Console.WriteLine("输入有误！"); break;
            }
            Console.ReadLine();
        }
        public static void Fraction()//分数
        {
            Console.Write("请输入生成题目数量：");
            String strnum = Console.ReadLine();//接收字符
            int num = Convert.ToInt32(strnum);//转义

            Console.Write("请输入生成数字上限：");
            String strmaxnum = Console.ReadLine();//接收字符
            int maxnum = Convert.ToInt32(strmaxnum);//转义

            Random R = new Random();
            int symbol = 0;//运算符
            int n1, n2, m1, m2;//分数
            for (int i = 0; i < num; i++)//循环输出
            {
                n1 = R.Next(1, maxnum);
                n2 = R.Next(1, maxnum);
                m1 = R.Next(1, maxnum);
                m2 = R.Next(1, maxnum);
                symbol = R.Next(0, 4);
                if (n1 < n2)
                {
                    Console.Write(n1 + "/" + n2);
                }
                else if (n1 == n2)
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(n2 + "/" + n1);
                }
                switch (symbol)
                {
                    case 0: Console.Write("+"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("*"); break;
                    case 3: Console.Write("/"); break;
                }
                if (m1 < m2)
                {
                    Console.WriteLine(m1 + "/" + m2 + "=");
                }
                else if (m1 > m2)
                {
                    Console.WriteLine(m2 + "/" + m1 + "=");
                }
                else
                {
                    Console.WriteLine(1 + "=");
                }
            }
        }
        public static void Integer()//整数
        {
            Console.Write("请输入生成题目数量：");
            String strnum = Console.ReadLine();//接收字符
            int num = Convert.ToInt32(strnum);//转义

            Console.Write("请输入生成数字上限：");
            String strmaxnum = Console.ReadLine();//接收字符
            int maxnum = Convert.ToInt32(strmaxnum);//转义

            Random R = new Random();
            int symbol = 0;//运算符
            for (int i = 0; i < num; i++)//循环输出
            {
                Console.Write(R.Next(1, maxnum));
                symbol = R.Next(0, 4);
                switch (symbol)
                {
                    case 0: Console.Write("+"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("*"); break;
                    case 3: Console.Write("/"); break;
                }
                Console.WriteLine(R.Next(1, maxnum) + "=");
            }
        }
        public static void Mixture()//混合
        {
            Console.Write("请输入生成题目数量：");
            String strnum = Console.ReadLine();//接收字符
            int num = Convert.ToInt32(strnum);//转义

            Console.Write("请输入生成数字上限：");
            String strmaxnum = Console.ReadLine();//接收字符
            int maxnum = Convert.ToInt32(strmaxnum);//转义

            Random R = new Random();
            int symbol = 0;//运算符
            int n1, n2, m1, m2;//分数
            for (int i = 0; i < num; i++)//循环输出
            {
                if (i < (num / 2))
                {
                    Console.Write(R.Next(1, maxnum));
                    symbol = R.Next(0, 4);
                    switch (symbol)
                    {
                        case 0: Console.Write("+"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("*"); break;
                        case 3: Console.Write("/"); break;
                    }
                    Console.WriteLine(R.Next(1, maxnum) + "=");
                }
                else
                {
                    n1 = R.Next(1, maxnum);
                    n2 = R.Next(1, maxnum);
                    m1 = R.Next(1, maxnum);
                    m2 = R.Next(1, maxnum);
                    symbol = R.Next(0, 4);
                    if (n1 < n2)
                    {
                        Console.Write(n1 + "/" + n2);
                    }
                    else if (n1 == n2)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(n2 + "/" + n1);
                    }
                    switch (symbol)
                    {
                        case 0: Console.Write("+"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("*"); break;
                        case 3: Console.Write("/"); break;
                    }
                    if (m1 < m2)
                    {
                        Console.WriteLine(m1 + "/" + m2 + "=");
                    }
                    else if (m1 > m2)
                    {
                        Console.WriteLine(m2 + "/" + m1 + "=");
                    }
                    else
                    {
                        Console.WriteLine(1 + "=");
                    }
                }
            }
        }
    }
}
