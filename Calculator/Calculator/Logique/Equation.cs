using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logique
{
    public class Equation
    {
        private List<IOperand> operands = new();

        public void AddNumber(int i)
        {
            if (operands.Any() && operands.Last() is Number n)
            {
                operands.Remove(n);
                operands.Add(new Number(i + 10 * n.Value));
            }
            else
                operands.Add(new Number(i));
        }

        public void AddPlus() => operands.Add(new AddOperation());
        public void AddMinus() => operands.Add(new MinusOperation());
        public void AddMultiply() => operands.Add(new MultiplyOperation());
        public void AddDivide() => operands.Add(new DivideOperation());

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach(var operand in operands)
            {
                builder.Append(operand.StringValue);
                builder.Append(" ");
            }

            return builder.ToString();
        }
    }
}
