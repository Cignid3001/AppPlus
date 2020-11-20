using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите второго число:");
            string num2 = Console.ReadLine();
            string result = "";
            if (num1.Length > num2.Length)
            {
                while (num2.Length != num1.Length)
                {
                    num2 = 0 + num2;
                }
            }
            else if (num1.Length < num2.Length)
            {
                while (num1.Length != num2.Length)
                {
                    num1 = 0 + num1;
                }
            }
            Console.WriteLine($"{num1}, {num2}");
            int i = 0;
            while (num1 != "")
            {
                string ns1 = Convert.ToString(num1[num1.Length - 1]);
                int ni1 = Convert.ToInt32(ns1);
                string ns2 = Convert.ToString(num2[num2.Length - 1]);
                int ni2 = Convert.ToInt32(ns2);
                int ni3 = ni1 + ni2 + i;
                if (ni3 > 9)
                {
                    i = 1;
                    ni3 %= 10;
                }
                else
                {
                    i = 0;
                }
                string ns3 = Convert.ToString(ni3);
                result = ns3 + result;
                num1 = num1.Substring(0, num1.Length - 1);
                num2 = num2.Substring(0, num2.Length - 1);
            }
            if (i == 1)
            {
                result = "1" + result;
            }
        }
    }
}
