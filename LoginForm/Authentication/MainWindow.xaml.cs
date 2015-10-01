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
using System.IO;
using System.Windows.Forms;

namespace Authentication
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
        
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            string fn = @"C:\Windows\Temp\user.txt";
            try
            {
                using (StreamReader sr = new StreamReader(fn, true))
                {
                    s = sr.ReadLine();
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                File.Create(fn);
            }
            string[] ss = s.Split(',');
            if (Username.Text == ss[0])
            {
                if (Password.Text == ss[1])
                {
                    this.Hide();
                    Properties.Settings.Default.Save();
                    System.Windows.MessageBox.Show("Login Successful");
                    this.Show();
                }
                else
                {
                    MessageBlock.Text = "Sorry wrong Password";
                }
            }
            else
            {
                MessageBlock.Text = "Sorry wrong Username";
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Window1 form2 = new Window1();
            form2.Show();
        }
    }
}
