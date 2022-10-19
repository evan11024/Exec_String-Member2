using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入ALLEN不拘大小寫:");
			string name = Console.ReadLine();

			if (string.IsNullOrEmpty(name))
			{
				Console.WriteLine("您沒有輸入");
				return;
			}

			string nameU=name.ToUpper();
			string answer = "ALLEN";

			if (nameU == answer)
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
