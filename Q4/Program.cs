using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入民國年月日(連續數字):");
			string inputdate = Console.ReadLine(); ;

			int dt = Convert.ToInt32(inputdate);
			int ndtyear = dt / 10000 + 1911;
			int ndtmonth = (dt % 10000)/100;
			int ndtdate = (dt % 100);
			string month = string.Empty;
			string date = string.Empty;


			if (ndtmonth < 10)
			{
				month = $"0{ndtmonth}";
			}
			else
			{
				 month = $"{ndtmonth}";
			}
			if (ndtdate < 10)
			{
				 date = $"0{ndtdate}";
			}
			else
			{
				 date = $"{ndtdate}";
			}



			Console.WriteLine($"{ndtyear}/{month}/{date}");
		}
	}
}
