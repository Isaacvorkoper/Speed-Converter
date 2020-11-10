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

namespace Hastighed
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

        private void kmtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (kmtBox.Text == "")
            {
                msBox.Text = "";
            }
            else
            {
                try
                {
                    msBox.Text = (double.Parse(kmtBox.Text) * 3.6).ToString();
                    msBox.CaretIndex = msBox.Text.Length;
                }
                catch (Exception)
                {
                    MessageBox.Show("Input skal være et gyldigt tal");
                }
            }
        }

        private void msBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (msBox.Text == "")
            {
                kmtBox.Text = "";
            }
            else
            {
                try
                {
                    kmtBox.Text = (double.Parse(msBox.Text) / 3.6).ToString() + " km/t";
                    kmtBox.CaretIndex = msBox.Text.Length;
                }
                catch (Exception)
                {

                    MessageBox.Show("Input skal være et gydigt tal");
                }
            }
        }

        private void msBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            msBox.Clear();
        }

        private void kmtBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            kmtBox.Clear();
        }
    }
}
