using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class MainForm
    {
        public void greeting()
        {
            try
            {
                string greetingStatus = System.IO.File.ReadAllText("Cache.txt");
            }

            catch (FileNotFoundException ex)
            {
                string addMs = " Файл будет повторно создан со значением \"Greeting is enabled\".";
                MessageBox.Show(ex.Message + addMs);

                File.Create("Cache.txt").Close();
                using (StreamWriter streamWr = File.AppendText("Cache.txt"))
                {
                    streamWr.Write("Greeting is enabled");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                string greetingStatus = System.IO.File.ReadAllText("Cache.txt");

                if (greetingStatus.Contains("Greeting is enabled") && !greetingStatus.Contains("Work with files..."))
                {
                    MessageBox.Show("ЗДАРОВА!!!", "HELLO EVERYNYAN");
                    cbGreetingStatus.Checked = false;
                }

                if (greetingStatus.Contains("Greeting is disabled"))
                {
                    cbGreetingStatus.Checked = true;
                }
            }
        }
    }
}