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
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;

namespace Authentication
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        static void AppendToFile(string file, string value)
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(value);
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string s = Username.Text + "," + Password.Text;
            string fn = @"C:\Windows\Temp\user.txt";
            string path = Directory.GetCurrentDirectory();
            string file = path + @"account.txt";
            try
            {

                AppendToFile(file, s);
                System.Windows.MessageBox.Show("Create Successful");
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                File.Create(file);
            }
        }
    }
}
