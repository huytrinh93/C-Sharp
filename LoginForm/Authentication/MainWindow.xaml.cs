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
    /// Check file from account text file
    /// Scan file using array list of user and pass
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
            //string fn = @"C:\Windows\Temp\user.txt";
            string path = Directory.GetCurrentDirectory();
            string file = path + @"account.txt";

            List<string> user = new List<string>();
            List<string> pass = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(file, true))
                {
                    while (sr.EndOfStream == false)
                    {
                        s = sr.ReadLine();
                        string[] ss = s.Split(',');
                        user.Add(ss[0]);
                        pass.Add(ss[1]);
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                File.Create(file);
            }
            if(user.Contains(Username.Text))
            {
                for (int i = 0; i < user.Count; i++)
                {
                    if (Username.Text == user.ElementAt(i))
                    {
                        if (Password.Text == pass.ElementAt(i))
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
