using System;
using SimpleCalc.Operations;

namespace SimpleCalc.Operations {
	public class Nop : Operation {
 		public int execute(int num1, int num2){
			Console.WriteLine("ERROR: Argument not understood!");
 			return -1;
		}

		public override string ToString()
		{
			return "NOP";
		}

	}
}
