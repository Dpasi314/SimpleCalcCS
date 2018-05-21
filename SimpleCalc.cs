using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleCalc.Operations;
using SimpleCalc.Expressions;

namespace SimpleCalc
{
	class SimpleCalc
	{
 		public static void Main(string[] args)
		{
			int ans;
			Console.Write("Input > ");
			string input = Console.ReadLine();
			List<string> inpt = input.Split(' ').ToList();
			while(inpt.Count > 1) 
			{
 		
 		       		if(inpt.Count % 2 == 0)
 		       		{
 					Console.Write("Invalid input.\n");
 		       			continue;
 		       		}

 		       		Expression e = new Expression(inpt[1], int.Parse(inpt[0]), int.Parse(inpt[2]));
 		       		ans = e.execute();
 		       		Console.Write(e.ToString());
 		       		Console.Write(e.execute() + "\n");
 		       		inpt.RemoveAt(0);
 		       		inpt.RemoveAt(1);
 		       		inpt[0] = ans.ToString();
			}
		}
	}
}
