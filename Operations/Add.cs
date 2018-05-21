using System;
using SimpleCalc.Operations;

namespace SimpleCalc.Operations {
	public class Add : Operation {
 		public int execute(int num1, int num2){
 			return num1 + num2;
		}

		public override string ToString()
		{
 			return "+";
		}
	}
}
