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
    public partial class MainForm : Form
    {
        Circle firstCircle = new Circle(0, 0, 0);
        Circle secondCircle = new Circle(0, 0, 0);
        public MainForm(Circle firstC, Circle secondC)
        {
            InitializeComponent();
            try
            {
                //string greetingStatus = System.IO.File.ReadAllText("Cache.txt");

                firstCircle = firstC;
                secondCircle = secondC;
                xCoordForFirstCircle.Text = firstCircle.xC.ToString();
                yCoordForFirstCircle.Text = firstCircle.yC.ToString();
                radiusForFirstCircle.Text = firstCircle.rad.ToString();

                xCoordForScndCircle.Text = secondCircle.xC.ToString();
                yCoordForScndCircle.Text = secondCircle.yC.ToString();
                radiusForScndCircle.Text = secondCircle.rad.ToString();
                greeting();
            }
            /* catch (FileNotFoundException ex)
             {
                 string addMs = " Файл будет повторно создан со значением \"Greeting is enabled\"."; ;
                 MessageBox.Show(ex.Message + addMs);

                 File.Create("Cache.txt").Close();
                 using (StreamWriter streamWr = File.AppendText("Cache.txt"))
                 {
                     streamWr.Write("Greeting is enabled");
                 }
             }*/

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*finally
            {
                cbGreetingStatus.Checked = Answer.isCBChecked;
                
                string greetingStatus = System.IO.File.ReadAllText("Cache.txt");

                *//*if (greetingStatus.Contains("Work with files...")) {
                    System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
                }*//*

                if (greetingStatus.Contains("Greeting is enabled"))
                {
                    MessageBox.Show("Лабораторная работа #1, вариант #11. Работу выполнила Науменко Юлия, 415а группа. В этом приложении Вы можете ввести данные о двух кругах для поиска их общей площади.Круги находятся в плоскости. Также Вы можете взять данные о кругах из файла, либо сохранить введённые вами данные в файл.");
                    cbGreetingStatus.Checked = false;
                }


                if (greetingStatus.Contains("Greeting is disabled"))
                    cbGreetingStatus.Checked = true;
                
                *//*
                if (greetingStatus == "Work with files...")
                    cbGreetingStatus.Checked = true;*/


            /*firstCircle = firstC;
            secondCircle = secondC;
            xCoordForFirstCircle.Text = firstCircle.xC.ToString();
            yCoordForFirstCircle.Text = firstCircle.yC.ToString();
            radiusForFirstCircle.Text = firstCircle.rad.ToString();

            xCoordForScndCircle.Text = secondCircle.xC.ToString();
            yCoordForScndCircle.Text = secondCircle.yC.ToString();
            radiusForScndCircle.Text = secondCircle.rad.ToString();*/

            /*greetingStatus = System.IO.File.ReadAllText("Cache");
            if (greetingStatus == "Ok")
            {
                MessageBox.Show("Лабораторная работа #1, вариант #11. Работу выполнила Науменко Юлия, 415а группа. В этом приложении Вы можете ввести данные о двух кругах для поиска их общей площади.Круги находятся в плоскости. Также Вы можете взять данные о кругах из файла, либо сохранить введённые вами данные в файл.");
            }
            else
            {
                cbGreetingStatus.Checked = true;
            }*//*
        }*/
        }



        private void calculate_Click(object sender, EventArgs e)
        {
            if (have_Text_Boxes_Values(xCoordForFirstCircle, yCoordForFirstCircle, radiusForFirstCircle, xCoordForScndCircle, yCoordForScndCircle, radiusForScndCircle) == true)
            {
                int xFirstCircle = Convert.ToInt32(xCoordForFirstCircle.Text);
                int yFirstCircle = Convert.ToInt32(yCoordForFirstCircle.Text);
                int radFirstCircle = Convert.ToInt32(radiusForFirstCircle.Text);

                int xScndCircle = Convert.ToInt32(xCoordForScndCircle.Text);
                int yScndCircle = Convert.ToInt32(yCoordForScndCircle.Text);
                int radScndCircle = Convert.ToInt32(radiusForScndCircle.Text);

                calculation_Distance_Between_Circles(xFirstCircle, xScndCircle, yFirstCircle, yScndCircle, radFirstCircle, radScndCircle);
            }
        }

        private bool have_Text_Boxes_Values(TextBox xCoordForFirstCircle, TextBox yCoordForFirstCircle, TextBox radiusForFirstCircle, TextBox xCoordForScndCircle, TextBox yCoordForScndCircle, TextBox radiusForScndCircle)
        {
            if ((xCoordForFirstCircle.TextLength == 0)
                || (yCoordForFirstCircle.TextLength == 0)
                || (radiusForFirstCircle.TextLength == 0)
                || (xCoordForScndCircle.TextLength == 0)
                || (yCoordForScndCircle.TextLength == 0)
                || (radiusForScndCircle.TextLength == 0))
            {
                string message = "Но вы ввели не все данные :(";
                string caption = "Упс!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);

                return false;
            }
            else return true;
        }

        private void tbTextLeave(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                double num = Convert.ToDouble(tb.Text);
            }
            catch
            {
                MessageBox.Show("В поле были некорректные значения - любые знаки, помимо цифр. Введите данные снова.", "Упс!", MessageBoxButtons.OK);
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                tb.Clear();
            }
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                    return;
                if ((e.KeyChar == '-') && (yCoordForFirstCircle.Text.Length == 0)) return;

                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (Char)Keys.Enter)
                        radiusForFirstCircle.Focus();
                    return;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void textBoxXCoord1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                    return;
                if ((e.KeyChar == '-') && (yCoordForFirstCircle.Text.Length == 0)) return;

                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (Char)Keys.Enter)
                        radiusForFirstCircle.Focus();
                    return;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        private void textBoxYCoord1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if ((e.KeyChar == '-') && (yCoordForFirstCircle.Text.Length == 0)) return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Enter)
                    radiusForFirstCircle.Focus();
                return;
            }

            e.Handled = true;
        }


        private void textBoxRad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
                return;
            if ((e.KeyChar == '0') && (radiusForFirstCircle.Text.Length != 0))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Enter)
                    radiusForFirstCircle.Focus();
                return;
            }
            e.Handled = true;
        }

  
        private void textBoxXCoord2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if ((e.KeyChar == '-') && (yCoordForFirstCircle.Text.Length == 0)) return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Enter)
                    radiusForFirstCircle.Focus();
                return;
            }
            e.Handled = true;
        }

  
        private void textBoxYCoord2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if ((e.KeyChar == '-') && (yCoordForFirstCircle.Text.Length == 0)) return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Enter)
                    radiusForFirstCircle.Focus();
                return;
            }
            e.Handled = true;
        }

 
        private void textBoxRad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
                return;
            if ((e.KeyChar == '0') && (radiusForScndCircle.Text.Length != 0))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Enter)
                    radiusForFirstCircle.Focus();
                return;
            }
            e.Handled = true;
        }*/


        private void validatingDistance(double distance)
        {
            string message = "Оу, кажется, у этих кругов нет общей площади. Сотрём введённые данные?";
            string caption = "Упс!";

            if (distance >= 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    xCoordForFirstCircle.Clear();
                    yCoordForFirstCircle.Clear();
                    radiusForFirstCircle.Clear();
                    xCoordForScndCircle.Clear();
                    yCoordForScndCircle.Clear();
                    radiusForScndCircle.Clear();
                }
            }
        }
        private void calculation_Distance_Between_Circles(int x1, int x2, int y1, int y2, int rad1, int rad2)
        {
            double tmp = 0;
            tmp = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
            double distanceBetweenCenters = Math.Sqrt(tmp);
            double distanceBetweenCircles = distanceBetweenCenters - rad1 - rad2;
            validatingDistance(distanceBetweenCircles);
            calculation_Area_Crossed_Circles(rad1, rad2, distanceBetweenCenters);
        }

        private void calculation_Area_Crossed_Circles(int rad1, int rad2, double distance)
        {
            double AreaCrossedCircles = 0;
            double TriangleArea1 = 0;
            double TriangleArea2 = 0;
            double TmpAcos1 = 0;
            double TmpAcos2 = 0;
            double F1 = 0;
            double F2 = 0;
            double pi = 3.14;
            if (distance < Math.Abs(rad1 - rad2))
            {
                if (rad1 < rad2)
                    AreaCrossedCircles = pi * rad1 * rad1;
                else if (rad2 < rad1)
                    AreaCrossedCircles = pi * rad2 * rad2;

            }
            else
            {
                TmpAcos1 = ((rad1 * rad1 - rad2 * rad2 + distance * distance) / (2 * rad1 * distance));
                TmpAcos2 = ((rad2 * rad2 - rad1 * rad1 + distance * distance) / (2 * rad2 * distance));
                F1 = 2 * Math.Acos(TmpAcos1);
                F2 = 2 * Math.Acos(TmpAcos2);
                TriangleArea1 = (rad1 * rad1 * (F1 - Math.Sin(F1))) / 2;
                TriangleArea2 = (rad2 * rad2 * (F2 - Math.Sin(F2))) / 2;

                AreaCrossedCircles = TriangleArea1 + TriangleArea2;
                AreaCrossedCircles = Math.Round(AreaCrossedCircles, 3);
                Answer.answer = AreaCrossedCircles;
                Answer.haveCirclesCollectiveArea = true;
            }
            show_Answer(AreaCrossedCircles);

        }
        private void show_Answer(double area)
        {
            string answer = area.ToString();
            AnswerLabel.Text = answer;
        }
        private void AnswerLabel_TextChanged(object sender, EventArgs e)
        {
            if (AnswerLabel.Text != "NaN")
            {
                AnswerLabel.Visible = true;
                TotalAreaMessage.Visible = true;
            }
            else
            {
                AnswerLabel.Visible = false;
                TotalAreaMessage.Visible = false;
            }

        }
        private void buttonReadyValues_Click(object sender, EventArgs e)
        {
            xCoordForFirstCircle.Text = "1";
            yCoordForFirstCircle.Text = "2";
            radiusForFirstCircle.Text = "3";

            xCoordForScndCircle.Text = "4";
            yCoordForScndCircle.Text = "5";
            radiusForScndCircle.Text = "6";
        }

        private void btnGoToFileWork_Click(object sender, EventArgs e)
        {
            //checkingGreetingStatus.Checked = false;
            try
            {
                firstCircle.xC = Convert.ToDouble(xCoordForFirstCircle.Text); /*= Convert.ToDouble(xCoordForFirstCircle.Text)*/;
                firstCircle.yC = Convert.ToDouble(yCoordForFirstCircle.Text);
                firstCircle.rad = Convert.ToDouble(radiusForFirstCircle.Text);

                secondCircle.xC = Convert.ToDouble(xCoordForScndCircle.Text);
                secondCircle.yC = Convert.ToDouble(yCoordForScndCircle.Text);
                secondCircle.rad = Convert.ToDouble(radiusForScndCircle.Text);
                Answer.canCirclesBeSaved = true;
                if (String.IsNullOrWhiteSpace(Convert.ToString(Answer.answer)))
                    Answer.canResultsBeSaved = false;
                else
                    Answer.canResultsBeSaved = true;
            }

            catch
            {
                Answer.canCirclesBeSaved = false;
                Answer.canResultsBeSaved = false;
            }
            checking_cb(sender, e);
            File.AppendAllText("Cache.txt", "\n\nWork with files...");

            /*StreamWriter sw = new StreamWriter("Cache.txt");
            sw.Write("Work with files...");
            sw.Close();*/

            //System.IO.File.WriteAllText("Cache.txt", "Work with files...");
            //Answer.isCBChecked = cbGreetingStatus.Checked;
            MainForm.ActiveForm.Hide();
            FileWork fileWork = new FileWork(firstCircle, secondCircle);
            //fileWork.Tag = this;
            fileWork.ShowDialog();
            Close();
        }

        private void checking_cb (object sender, EventArgs e) {
            if (cbGreetingStatus.Checked == true)
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            if (cbGreetingStatus.Checked == false)
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbGreetingStatus.Checked == true)
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            }

            if (cbGreetingStatus.Checked == false)
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            }

        }

        /*private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string greetingStatus = System.IO.File.ReadAllText("Cache.txt");
            if (greetingStatus == "Work with files...")
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
        }

        private void cbGreetingStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGreetingStatus.Checked == true)
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            }
            else
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            Answer.isCBChecked = cbGreetingStatus.Checked;
        }*/

        /*private void cbGreetingStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGreetingStatus.Checked == true)
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            }
            else
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
        }*/
    }
}
