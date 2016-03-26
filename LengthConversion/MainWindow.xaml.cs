using System;
using System.Linq;
using System.Windows;
using LengthConversion.Models;
using LengthConversion.Decorations;

namespace LengthConversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboUnits.ItemsSource = Enum.GetValues(typeof(Unit)).Cast<Unit>();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            var kilo = new Kilometer
            {
                Value = double.Parse(txtInput.Text),
                ConvertTo = (Unit)cboUnits.SelectedItem
            };

            var converter = new KilometerConverter();
            var result = converter.Convert(kilo);

            result = new RoundingDecorator(result);
            result = new ExponentialDecorator(result);

            txtOutput.Text = result.Value.ToString();

            // round decorator
            // e notation decorator
            // unit name decorator
            // print result
        }
    }
}
