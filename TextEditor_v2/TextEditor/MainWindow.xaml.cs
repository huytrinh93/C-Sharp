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

using System.Windows.Forms;
using System.IO;

namespace FormApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        string activeFileName = null;
        string activeFilePath = null;
        Boolean modified = false;
        TextDocument formBox = new TextDocument();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void New()
        {
            textBox.Text = "";
            activeFileName = "Untitled";
            activeFilePath = null;
            UpdateTitle();
        }
        private void Save()
        {
            if (String.IsNullOrEmpty(activeFilePath))
            {
                // File has never been saved, must prompt for name
                SaveAs();
            }
            else
            {
                // Save document
                using (TextWriter tr = new StreamWriter(activeFilePath))
                {
                    tr.Write(textBox.Text);
                }
            }
            unsetModifiedState();
        }

        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = activeFileName; // Default file name
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!formBox.Save(saveFileDialog.FileName,textBox.Text))
                {
                    // http://msdn.microsoft.com/en-us/library/Aa984357
                    System.Windows.Forms.MessageBox.Show("An error occurred saving the grades.", "Grader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                activeFilePath = saveFileDialog.FileName;
                activeFileName = new FileInfo(activeFilePath).Name;
            }
            UpdateTitle();
            unsetModifiedState();
        }

        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.FileName = activeFileName; // Default file name
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = "";
                activeFilePath = openFileDialog.FileName;
                activeFileName = new FileInfo(activeFilePath).Name;
                formBox.Load(openFileDialog.FileName);
                textBox.Text = formBox.ToString();
            }
            UpdateTitle();
        }

        private void MenuHandler_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.MenuItem item = (System.Windows.Controls.MenuItem)sender;
            switch (item.Name)
            {
                case "NewMenu":
                    if (handleSaveRequest())
                        New();
                    break;

                case "OpenMenu":
                    if (handleSaveRequest())
                        Open();
                    break;

                case "SaveMenu":
                    Save();
                    break;

                case "SaveAsMenu":
                    SaveAs();
                    break;

                case "ExitMenu":
                    if (handleSaveRequest())
                        window1.Close();
                    break;
            }
        }
        private void UpdateTitle()
        {
            window1.Title = activeFileName + " - " + "text editor v 0.1";
        }
        private void ehDragOverMult(object sender, System.Windows.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(System.Windows.DataFormats.FileDrop))
                e.Effects = System.Windows.DragDropEffects.Copy;
            e.Handled = true;
        }

        private void ehDropMult(object sender, System.Windows.DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(System.Windows.DataFormats.FileDrop);
            System.Windows.Controls.TextBox tb = (System.Windows.Controls.TextBox)sender;

            foreach (string file in files)
            {
                StreamReader fileToLoad = new StreamReader(file);
                tb.Text += fileToLoad.ReadToEnd();
                fileToLoad.Close();
            }
            setModifiedState();
        }
        private void about_menu_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Developed by Huy Trinh.\n\nCopyright October 2015, Personal Project.";
            string caption = "Credit";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            // Display message box
            System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
            // No need to process message box results since OK is the only option.
            unsetModifiedState();
        }
        private void setModifiedState()
        {
            modified = true;
            SaveMenu.IsEnabled = true;
            SaveAsMenu.IsEnabled = true;
        }
        private void unsetModifiedState()
        {
            modified = false;
            SaveMenu.IsEnabled = false;
            SaveAsMenu.IsEnabled = false;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            setModifiedState();
        }
        private Boolean handleSaveRequest()
        {
            if (!modified) return true;

            string messageBoxText = "The text editor needs to be saved.\nDo you want to save?";
            string caption = "Text Editor";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxImage icon = MessageBoxImage.Warning;
            // Display message box
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
            // Process message box results
            switch (messageBoxResult)
            {
                case MessageBoxResult.Yes: // Save document and exit
                    SaveAs();
                    return true;

                case MessageBoxResult.No: // Exit without saving
                    return true;

                case MessageBoxResult.Cancel: // Don't exit
                    return false;
            }

            return false;

        }
    }
}
