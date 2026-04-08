using Calculator.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CalculatorView : Window
    {
        private CalculatorViewModel viewModel = new();

        public CalculatorView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void Button1_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(1);
        private void Button2_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(2);
        private void Button3_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(3);
        private void Button4_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(4);
        private void Button5_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(5);
        private void Button6_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(6);
        private void Button7_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(7);
        private void Button8_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(8);
        private void Button9_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(9);
        private void Button0_Click(object sender, RoutedEventArgs e) => viewModel.AddNumber(0);
        private void ButtonPlus_Click(object sender, RoutedEventArgs e) => viewModel.AddPlus();
        private void ButtonMinus_Click(object sender, RoutedEventArgs e) => viewModel.AddMinus();
        private void ButtonDivide_Click(object sender, RoutedEventArgs e) => viewModel.AddDivide();
        private void ButtonMultiply_Click(object sender, RoutedEventArgs e) => viewModel.AddMultiply();
    }
}