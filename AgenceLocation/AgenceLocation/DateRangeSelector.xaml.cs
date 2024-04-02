using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgenceLocation
{
    /// <summary>
    /// Logique d'interaction pour DateRangeSelector.xaml
    /// </summary>
    public partial class DateRangeSelector : Page
    {
        private Action<DateTime, DateTime> confirmAction;
        private Action cancelAction;

        public DateRangeSelector(Action<DateTime, DateTime> confirmAction, Action cancelAction)
        {
            InitializeComponent();

            this.confirmAction = confirmAction;
            this.cancelAction = cancelAction;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            confirmAction(StartDatePicker.SelectedDate.Value, EndDatePicker.SelectedDate.Value);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            cancelAction();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateConfirmButton();
        }

        private void UpdateConfirmButton()
        {
            if (StartDatePicker.SelectedDate != null
                && EndDatePicker.SelectedDate != null
                && StartDatePicker.SelectedDate <= EndDatePicker.SelectedDate)
            {
                ConfirmButton.IsEnabled = true;
            }
            else
            {
                ConfirmButton.IsEnabled = false;
            }
        }
    }
}
