using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入Allen 區分大小寫");
			string input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("未輸入");
				return;
			}

			string answer = "Allen";

			if (input == answer)
			{
				Console.WriteLine("正確");
			}
			else
			{
				Console.WriteLine("錯誤");
			}
		}
	}
}
