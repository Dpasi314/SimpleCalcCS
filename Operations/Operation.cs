using System;

namespace SimpleCalc.Operations {
	public interface Operation {
 		int execute(int num1, int num2);
		string ToString();
	}
}
