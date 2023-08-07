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
            //InitializeComponent();
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

            

            /* try
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
                 if (Answer.isCBChecked)
                 {
                     cbGreetingStatus.CheckedChanged -= cbGreetingStatus_CheckedChanged;
                     cbGreetingStatus.Checked = Answer.isCBChecked;
                     cbGreetingStatus.CheckedChanged += cbGreetingStatus_CheckedChanged;
                 }
                 //if (cbGreetingStatus.Checked == Answer.isCBChecked)
                 //{
                 //    cbGreetingStatus.CheckedChanged -= cbGreetingStatus_CheckedChanged;
                 //    cbGreetingStatus.Checked = true;
                 //    cbGreetingStatus.CheckedChanged += cbGreetingStatus_CheckedChanged;
                 //}
                 //cbGreetingStatus.Checked = !Answer.isCBChecked;

                 string greetingStatus = System.IO.File.ReadAllText("Cache.txt");

                 *//*if (greetingStatus.Contains("Work with files..."))
                 {
                     System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
                 }*//*

                 if (greetingStatus.Contains("Greeting is enabled") && !greetingStatus.Contains("Work with files..."))
                 {
                     MessageBox.Show("Лабораторная работа #1, вариант #11. Работу выполнила Науменко Юлия, 415а группа. В этом приложении Вы можете ввести данные о двух кругах для поиска их общей площади.Круги находятся в плоскости. Также Вы можете взять данные о кругах из файла, либо сохранить введённые вами данные в файл.");
                     cbGreetingStatus.Checked = false;
                 }
                 else if (greetingStatus.Contains("Greeting is enabled") && greetingStatus.Contains("Work with files..."))
                 {
                     System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
                     cbGreetingStatus.Checked = false;
                 }

                 if (greetingStatus.Contains("Greeting is disabled"))
                     cbGreetingStatus.Checked = true;
                 else if (greetingStatus.Contains("Greeting is disabled") && greetingStatus.Contains("Work with files..."))
                 {
                     System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
                     cbGreetingStatus.Checked = true;
                 }


                 *//*if (greetingStatus == "Work with files...")
                     cbGreetingStatus.Checked = true;*/

            /* greetingStatus = System.IO.File.ReadAllText("Cache");
             if (greetingStatus == "Ok")
             {
                 MessageBox.Show("Лабораторная работа #1, вариант #11. Работу выполнила Науменко Юлия, 415а группа. В этом приложении Вы можете ввести данные о двух кругах для поиска их общей площади.Круги находятся в плоскости. Также Вы можете взять данные о кругах из файла, либо сохранить введённые вами данные в файл.");
             }
             else
             {
                 cbGreetingStatus.Checked = true;
             }*//*
        }
    }


    *//*private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        string greetingStatus = System.IO.File.ReadAllText("Cache.txt");
        if (greetingStatus.Contains("Work with files..."))
            System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
    }*//*

    private void cbGreetingStatus_CheckedChanged(object sender, EventArgs e)
    {
        cbGreetingStatus.CheckedChanged -= cbGreetingStatus_CheckedChanged;
        cbGreetingStatus.Checked =!(cbGreetingStatus.Checked);
        cbGreetingStatus.CheckedChanged += cbGreetingStatus_CheckedChanged;

        if (cbGreetingStatus.Checked == true)
        {
            System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            Answer.isCBChecked = true;
        }
        else
        {
            System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            Answer.isCBChecked = false;
        }*/
        }
    }
}