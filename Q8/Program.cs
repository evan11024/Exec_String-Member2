using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入身分證:");
			string input =	Console.ReadLine();	

			if(string.IsNullOrEmpty(input)||input.Length!=10)
			{
				Console.WriteLine("輸入不正確");
				return;
			}

			string start = input.Substring(0, 4);
			string end = input.Substring(8,2);
			string all = start +"****"+ end;

			Console.WriteLine(all);
		}
	}
}
