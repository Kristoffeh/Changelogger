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
using static System.Net.Mime.MediaTypeNames;

namespace Changelogger
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

        private void btnConvert_Click(object sender,RoutedEventArgs e)
        {
            try
            {
                string str = txtChangelog.Text;
                txtOutput.Text += $"\\n• " + str;
                txtChangelog.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.StackTrace}");
            }
        }

        private void btnCopy_Click(object sender,RoutedEventArgs e)
        {
            try
            {
                Clipboard.SetText(txtOutput.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.StackTrace}");
            }

        }
    }
}
