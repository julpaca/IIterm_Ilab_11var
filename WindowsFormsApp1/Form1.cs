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
        Circle firstCircle = new Circle();
        Circle secondCircle = new Circle();
        public MainForm(Circle firstC, Circle secondC)
        {
            InitializeComponent();
            greeting();

            if (Answer.isDataFromFile == true)
            {
                try
                {
                    firstCircle = firstC;
                    secondCircle = secondC;
                    xCoordForFirstCircle.Text = firstCircle.xC.ToString();
                    yCoordForFirstCircle.Text = firstCircle.yC.ToString();
                    radiusForFirstCircle.Text = firstCircle.rad.ToString();

                    xCoordForScndCircle.Text = secondCircle.xC.ToString();
                    yCoordForScndCircle.Text = secondCircle.yC.ToString();
                    radiusForScndCircle.Text = secondCircle.rad.ToString();
                }
           
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            if (have_Text_Boxes_Values(xCoordForFirstCircle, yCoordForFirstCircle, radiusForFirstCircle, xCoordForScndCircle, yCoordForScndCircle, radiusForScndCircle) == true)
            {
                double xFirstCircle = Convert.ToDouble(xCoordForFirstCircle.Text);
                double yFirstCircle = Convert.ToDouble(yCoordForFirstCircle.Text);
                double radFirstCircle = Convert.ToDouble(radiusForFirstCircle.Text);

                double xScndCircle = Convert.ToDouble(xCoordForScndCircle.Text);
                double yScndCircle = Convert.ToDouble(yCoordForScndCircle.Text);
                double radScndCircle = Convert.ToDouble(radiusForScndCircle.Text);

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
            else if (double.TryParse(xCoordForFirstCircle.Text, out double xfc) == false ||
                     double.TryParse(yCoordForFirstCircle.Text, out double yfc) == false ||
                     double.TryParse(radiusForFirstCircle.Text, out double rfc) == false ||
                     double.TryParse(xCoordForScndCircle.Text, out double xsc) == false ||
                     double.TryParse(yCoordForScndCircle.Text, out double yxs) == false ||
                     double.TryParse(radiusForScndCircle.Text, out double rxs) == false)
            {
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                var result = MessageBox.Show("Как ни странно, в полях остались некорректные данные. Сотрём некорректные данные?", "Упс!", btn);
                if (result == DialogResult.Yes)
                {
                    if (double.TryParse(xCoordForFirstCircle.Text, out xfc) == false)
                        xCoordForFirstCircle.Clear();
                    if (double.TryParse(yCoordForFirstCircle.Text, out yfc) == false)
                        yCoordForFirstCircle.Clear(); 
                    if (double.TryParse(radiusForFirstCircle.Text, out rfc) == false)
                        radiusForFirstCircle.Clear();
                    if (double.TryParse(xCoordForScndCircle.Text, out xsc) == false)
                        xCoordForScndCircle.Clear();
                    if (double.TryParse(yCoordForScndCircle.Text, out yxs) == false)
                        yCoordForScndCircle.Clear();
                    if (double.TryParse(radiusForScndCircle.Text, out rxs) == false)
                        radiusForScndCircle.Clear();
                }
                return false;
            } 
            else return true;
        }

        /*private void tbTextLeave(object sender, EventArgs e)
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
        }*/

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox obj_tb = (TextBox)sender;
            string txt = obj_tb.Text;
            bool isDigit = int.TryParse(txt, out int n);
            
            try
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
                
                if ((e.KeyChar == '-') && (String.IsNullOrEmpty(txt))) return;

                if ((e.KeyChar == ',') && (isDigit == true)) return;

                if ((e.KeyChar == (char)Keys.Back)) return;
                
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculation_Distance_Between_Circles(double x1, double x2, double y1, double y2, double rad1, double rad2)
        {
            double tmp = 0;
            tmp = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
            double distanceBetweenCenters = Math.Sqrt(tmp);
            double distanceBetweenCircles = distanceBetweenCenters - rad1 - rad2;
            validatingDistance(distanceBetweenCircles);
            calculation_Area_Crossed_Circles(rad1, rad2, distanceBetweenCenters);
        }
        private void validatingDistance(double distance)
        {
            string message = "Оу, кажется, у этих кругов нет общей площади. Сотрём введённые данные?";
            string caption = "Упс!";

            if (distance >= 0)
            {
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, btn);
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

        private void calculation_Area_Crossed_Circles(double rad1, double rad2, double distance)
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
                else if (rad1 == rad2)
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
                //Answer.haveCirclesCollectiveArea = true;
            }

            Answer.answer = AreaCrossedCircles;
            Answer.canResultsBeSaved = true;
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
                /*if (String.IsNullOrEmpty(Convert.ToString(Answer.answer)))
                    Answer.canResultsBeSaved = false;
                else
                    Answer.canResultsBeSaved = true;*/
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
