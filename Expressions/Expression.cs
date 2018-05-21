using System;
using System.Collections.Generic;

using SimpleCalc.Operations;

namespace SimpleCalc.Expressions
{
	public class Expression 
	{
		private Operation op;
		private int int1;
		private int int2;
		private List<Expression> exprStack = new List<Expression>();
		public Expression(string op, int int1, int int2)
		{
			this.op = this.operationFactory(op);
			this.int1 = int1;
			this.int2 = int2;
			exprStack.Add(this);
		}

		public int execute()
		{
			return this.op.execute(this.int1, this.int2);
		}

		private Operation operationFactory(object op)
		{
			string operation = op.ToString();
 			if(operation == "+")
 				return new Add();
			if(operation == "-")
 				return new Sub();
			if(operation == "*")
 				return new Mul();
			if(operation == "/")
 				return new Div();
			return new Nop();
		}

		public override string ToString()
		{
 			return this.int1.ToString() + " " + this.op.ToString() + " " + this.int2.ToString() + " = ";
		}

	}
}
