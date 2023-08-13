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

namespace TotalCommonAreaOfCirclesSearch
{
    public partial class MainForm : Form
    {
        Circle firstCircle = new Circle();
        Circle secondCircle = new Circle();
        public MainForm(Circle firstC, Circle secondC)
        {
            InitializeComponent();
            Greeting();

            try
            {
                firstCircle = firstC;
                secondCircle = secondC;
                tbXCoordForFirstCircle.Text = firstCircle.XC.ToString();
                tbYCoordForFirstCircle.Text = firstCircle.YC.ToString();
                tbRadiusForFirstCircle.Text = firstCircle.Rad.ToString();

                tbXCoordForScndCircle.Text = secondCircle.XC.ToString();
                tbYCoordForScndCircle.Text = secondCircle.YC.ToString();
                tbRadiusForScndCircle.Text = secondCircle.Rad.ToString();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (HaveTextBoxesValues(tbXCoordForFirstCircle, tbYCoordForFirstCircle, tbRadiusForFirstCircle, tbXCoordForScndCircle, tbYCoordForScndCircle, tbRadiusForScndCircle) == true)
            {
                double xFirstCircle = Convert.ToDouble(tbXCoordForFirstCircle.Text);
                double yFirstCircle = Convert.ToDouble(tbYCoordForFirstCircle.Text);
                double RadFirstCircle = Convert.ToDouble(tbRadiusForFirstCircle.Text);

                double xScndCircle = Convert.ToDouble(tbXCoordForScndCircle.Text);
                double yScndCircle = Convert.ToDouble(tbYCoordForScndCircle.Text);
                double RadScndCircle = Convert.ToDouble(tbRadiusForScndCircle.Text);

                if (RadFirstCircle <= 0 || RadScndCircle <= 0)
                    MessageBox.Show("Радиусы должны быть положительными...", "Упс!");
                else
                CalculationDistanceBetweenCircles(xFirstCircle, xScndCircle, yFirstCircle, yScndCircle, RadFirstCircle, RadScndCircle);
            }
        }

        private bool HaveTextBoxesValues(TextBox tbXCoordForFirstCircle, TextBox tbYCoordForFirstCircle, TextBox tbRadiusForFirstCircle, TextBox tbXCoordForScndCircle, TextBox tbYCoordForScndCircle, TextBox tbRadiusForScndCircle)
        {
            if ((tbXCoordForFirstCircle.TextLength == 0)
                || (tbYCoordForFirstCircle.TextLength == 0)
                || (tbRadiusForFirstCircle.TextLength == 0)
                || (tbXCoordForScndCircle.TextLength == 0)
                || (tbYCoordForScndCircle.TextLength == 0)
                || (tbRadiusForScndCircle.TextLength == 0))
            {
                string message = "Но вы ввели не все данные :(";
                string caption = "Упс!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);

                return false;
            }
            else if (double.TryParse(tbXCoordForFirstCircle.Text, out double xfc) == false ||
                     double.TryParse(tbYCoordForFirstCircle.Text, out double yfc) == false ||
                     double.TryParse(tbRadiusForFirstCircle.Text, out double rfc) == false ||
                     double.TryParse(tbXCoordForScndCircle.Text, out double xsc) == false ||
                     double.TryParse(tbYCoordForScndCircle.Text, out double yxs) == false ||
                     double.TryParse(tbRadiusForScndCircle.Text, out double rxs) == false)
            {
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                var result = MessageBox.Show("Как ни странно, в полях остались некорректные данные. Сотрём некорректные данные?", "Упс!", btn);
                if (result == DialogResult.Yes)
                {
                    if (double.TryParse(tbXCoordForFirstCircle.Text, out xfc) == false)
                        tbXCoordForFirstCircle.Clear();
                    if (double.TryParse(tbYCoordForFirstCircle.Text, out yfc) == false)
                        tbYCoordForFirstCircle.Clear(); 
                    if (double.TryParse(tbRadiusForFirstCircle.Text, out rfc) == false)
                        tbRadiusForFirstCircle.Clear();
                    if (double.TryParse(tbXCoordForScndCircle.Text, out xsc) == false)
                        tbXCoordForScndCircle.Clear();
                    if (double.TryParse(tbYCoordForScndCircle.Text, out yxs) == false)
                        tbYCoordForScndCircle.Clear();
                    if (double.TryParse(tbRadiusForScndCircle.Text, out rxs) == false)
                        tbRadiusForScndCircle.Clear();
                }
                return false;
            } 
            else
                return true;
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox objTb = (TextBox)sender;
            string txt = objTb.Text;
            bool isDigit = int.TryParse(txt, out int n);
            
            try
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
                
                if ((e.KeyChar == '-') && ((String.IsNullOrEmpty(txt)) || (objTb.SelectionStart == 0) )) return;

                if ((e.KeyChar == ',') && (isDigit == true)) return;

                if ((e.KeyChar == (char)Keys.Back)) return;
                
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalculationDistanceBetweenCircles(double x1, double x2, double y1, double y2, double rad1, double rad2)
        {
            double tmp = 0;
            tmp = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
            double distanceBetweenCenters = Math.Sqrt(tmp);
            double distanceBetweenCircles = distanceBetweenCenters - rad1 - rad2;
            if (ValidatingDistance(distanceBetweenCircles)==true)
            {
                CalculationareaCrossedCircles(rad1, rad2, distanceBetweenCenters);
            }
        }
        private bool ValidatingDistance(double distance)
        {
            string message = "Оу, кажется, у этих кругов нет общей площади. Сотрём введённые данные?";
            string caption = "Упс!";

            if (distance >= 0)
            {
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, btn);
                if (result == DialogResult.Yes)
                {
                    tbXCoordForFirstCircle.Clear();
                    tbYCoordForFirstCircle.Clear();
                    tbRadiusForFirstCircle.Clear();
                    tbXCoordForScndCircle.Clear();
                    tbYCoordForScndCircle.Clear();
                    tbRadiusForScndCircle.Clear();
                }
                return false;
            }
            else return true;
        }

        private void CalculationareaCrossedCircles(double rad1, double rad2, double distance)
        {
            double areaCrossedCircles = 0;
            double triangleArea1 = 0;
            double triangleArea2 = 0;
            double tmpAcos1 = 0;
            double tmpAcos2 = 0;
            double f1 = 0;
            double f2 = 0;
            double pi = 3.14;
            if (distance < Math.Abs(rad1 - rad2))
            {
                if (rad1 < rad2)
                    areaCrossedCircles = pi * rad1 * rad1;

                else if (rad2 < rad1)
                    areaCrossedCircles = pi * rad2 * rad2;
                else if (rad1 == rad2)
                    areaCrossedCircles = pi * rad2 * rad2;
            }
            else
            {
                tmpAcos1 = ((rad1 * rad1 - rad2 * rad2 + distance * distance) / (2 * rad1 * distance));
                tmpAcos2 = ((rad2 * rad2 - rad1 * rad1 + distance * distance) / (2 * rad2 * distance));
                f1 = 2 * Math.Acos(tmpAcos1);
                f2 = 2 * Math.Acos(tmpAcos2);
                triangleArea1 = (rad1 * rad1 * (f1 - Math.Sin(f1))) / 2;
                triangleArea2 = (rad2 * rad2 * (f2 - Math.Sin(f2))) / 2;

                areaCrossedCircles = triangleArea1 + triangleArea2;
                areaCrossedCircles = Math.Round(areaCrossedCircles, 3);
            }

            InformationForFiles.totalArea = areaCrossedCircles;
            InformationForFiles.CanResultsBeSaved = true;
            ShowAnswer(areaCrossedCircles);

        }
        private void ShowAnswer(double area)
        {
            string totalArea = area.ToString();
            AnswerLabel.Text = totalArea;
        }
        private void AnswerLabel_TextChanged(object sender, EventArgs e)
        {
            if (AnswerLabel.Text != "NaN")
            {
                AnswerLabel.Visible = true;
                lbltotalAreaMessage.Visible = true;
            }
            else
            {
                AnswerLabel.Visible = false;
                lbltotalAreaMessage.Visible = false;
            }

        }
        private void btnReadyValues_Click(object sender, EventArgs e)
        {
            tbXCoordForFirstCircle.Text = "1";
            tbYCoordForFirstCircle.Text = "2";
            tbRadiusForFirstCircle.Text = "3";

            tbXCoordForScndCircle.Text = "4";
            tbYCoordForScndCircle.Text = "5";
            tbRadiusForScndCircle.Text = "6";
        }

        private void btnGoToFilesForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(tbXCoordForFirstCircle.Text, out double xfc) == false ||
                     double.TryParse(tbYCoordForFirstCircle.Text, out double yfc) == false ||
                     double.TryParse(tbRadiusForFirstCircle.Text, out double rfc) == false ||
                     double.TryParse(tbXCoordForScndCircle.Text, out double xsc) == false ||
                     double.TryParse(tbYCoordForScndCircle.Text, out double yxs) == false ||
                     double.TryParse(tbRadiusForScndCircle.Text, out double rxs) == false)
                {
                    InformationForFiles.IsDataCorrect = false;
                }
                else
                {
                    firstCircle.XC = Convert.ToDouble(tbXCoordForFirstCircle.Text);
                    firstCircle.YC = Convert.ToDouble(tbYCoordForFirstCircle.Text);
                    firstCircle.Rad = Convert.ToDouble(tbRadiusForFirstCircle.Text);

                    secondCircle.XC = Convert.ToDouble(tbXCoordForScndCircle.Text);
                    secondCircle.YC = Convert.ToDouble(tbYCoordForScndCircle.Text);
                    secondCircle.Rad = Convert.ToDouble(tbRadiusForScndCircle.Text);
                    InformationForFiles.CanCirclesBeSaved = true;
                    InformationForFiles.IsDataCorrect = true;
                }
            }

            catch
            {
                InformationForFiles.CanCirclesBeSaved = false;
                InformationForFiles.CanResultsBeSaved = false;
            }
            CheckingCb(sender, e);
            File.AppendAllText("Cache.txt", "\n\nWork with files...");
            MainForm.ActiveForm.Hide();
            FileForm fileWork = new FileForm(firstCircle, secondCircle);
            fileWork.ShowDialog();
            Close();
        }

        /*private void CheckingCb (object sender, EventArgs e) {
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
        }*/
    }
}
