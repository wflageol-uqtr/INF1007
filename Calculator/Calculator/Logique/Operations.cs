using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logique
{
    public class AddOperation : IOperand
    {
        public string StringValue => "+";
    }
    public class MinusOperation : IOperand
    {
        public string StringValue => "-";
    }
    public class MultiplyOperation : IOperand
    {
        public string StringValue => "*";
    }
    public class DivideOperation : IOperand
    {
        public string StringValue => "/";
    }
}
