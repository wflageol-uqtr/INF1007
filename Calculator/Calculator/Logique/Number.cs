using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logique
{
    public class Number : IOperand
    {
        public decimal Value { get; }

        public string StringValue => Value.ToString();

        public Number(decimal value)
        {
            Value = value;
        }
    }
}
