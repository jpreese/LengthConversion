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
using LengthConversion.Models;

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

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            var kilo = new Kilometer
            {
                Value = 1,
                ConvertTo = Unit.Foot
            };

            var converter = new KilometerConverter();
            converter.Convert(kilo);

            Console.WriteLine(converter.Convert(kilo));
        }
    }
}
