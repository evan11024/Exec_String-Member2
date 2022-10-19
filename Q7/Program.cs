using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入第一個數:");
			string input = Console.ReadLine();
			Console.Write("請輸入第二個數:");
			string input2 = Console.ReadLine();

			if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(input2))
			{
				Console.WriteLine("輸入不正確");
			}

			decimal number1 = Convert.ToDecimal(input);
			decimal number2 = Convert.ToDecimal(input2);
			decimal sum = number1 + number2;
			string answer = sum.ToString("#.##");

			Console.WriteLine(answer);
		}
	}
}
