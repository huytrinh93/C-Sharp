using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormApplication
{
    class TextDocument
    {
        List<String> lines = new List<String>();

        public TextDocument()
        {

        }
        public string FilePath
        {
            get;
            set;
        }

        public Boolean Load(String fileName)
        {

            lines.Clear();

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(fileName))
                {
                    // http://msdn.microsoft.com/en-us/library/ms228388(v=vs.80).aspx
                    // http://msdn.microsoft.com/en-us/library/ms131448.aspx
                    String newline = "";
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((newline = sr.ReadLine()) != null)
                    {
                            lines.Add(newline);
                    }
                }
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public override String ToString()
        {
            String addline = "";
            foreach (String line in lines)
            {
                addline +=  line + "\n";
            }
            return addline;
        }

        public Boolean Save(String fileName, string text)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    String name = System.IO.Path.GetFileNameWithoutExtension(FilePath);
                    String line = name + text;
                    sw.WriteLine(line);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
