using Calculator.Logique;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string EquationString { get; set; } = "";

        private Equation equation = new();

        public CalculatorViewModel()
        {
            UpdateEquationString();
        }

        public void AddNumber(int i) 
        {
            equation.AddNumber(i);
            UpdateEquationString();
        }

        public void AddPlus()
        {
            equation.AddPlus();
            UpdateEquationString();
        }
        public void AddMinus()
        {
            equation.AddMinus();
            UpdateEquationString();
        }

        public void AddMultiply()
        {
            equation.AddMultiply();
            UpdateEquationString();
        }

        public void AddDivide()
        {
            equation.AddDivide();
            UpdateEquationString();
        }

        private void UpdateEquationString()
        {
            EquationString = equation.ToString() ?? "";
            
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("EquationString"));
        }
    }
}
