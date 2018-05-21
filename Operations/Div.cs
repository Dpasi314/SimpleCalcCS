using System;
using SimpleCalc.Operations;

namespace SimpleCalc.Operations {
	public class Div : Operation {
 		public int execute(int num1, int num2){
			if(num2 == 0)
			{
 				return -1;
			}

 			return num1 / num2;
		}
		public override string ToString()
		{
			return "/";
		}

	}
}
