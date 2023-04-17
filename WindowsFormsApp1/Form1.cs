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
    public partial class Form1 : Form
    {
        int xFirstCircle;
        int yFirstCircle;
        int radFirstCircle;
        int xScndCircle;
        int yScndCircle;
        int radScndCircle;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (have_Text_Boxes_Values(xCoordForFirstCircle, yCoordForFirstCircle, radiusForFirstCircle, xCoordForScndCircle, yCoordForScndCircle, radiusForScndCircle) == true)
            {
                xFirstCircle = Convert.ToInt32(xCoordForFirstCircle.Text);
                yFirstCircle = Convert.ToInt32(yCoordForFirstCircle.Text);
                radFirstCircle = Convert.ToInt32(radiusForFirstCircle.Text);

                xScndCircle = Convert.ToInt32(xCoordForScndCircle.Text);
                yScndCircle = Convert.ToInt32(yCoordForScndCircle.Text);
                radScndCircle = Convert.ToInt32(radiusForScndCircle.Text);

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

        private void textBoxXCoord1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void xCoordForFirstCircle_TextChanged(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isValueCorrect = false;
            isValueCorrect = double.TryParse(xCoordForFirstCircle.Text, out outputValue);
            if (!isValueCorrect)
            {
                MessageBox.Show("В поле были некорректные значения - любые знаки, помимо цифр. Введите данные снова.");
                xCoordForFirstCircle.Clear();
                xCoordForFirstCircle.Focus();
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

        private void yCoordForFirstCircle_TextChanged(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isValueCorrect = false;
            isValueCorrect = double.TryParse(yCoordForFirstCircle.Text, out outputValue);
            if (!isValueCorrect)
            {
                MessageBox.Show("В поле были некорректные значения - любые знаки, помимо цифр. Введите данные снова.");
                yCoordForFirstCircle.Clear();
                yCoordForFirstCircle.Focus();
            }
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

        private void radiusForFirstCircle_TextChanged(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isValueCorrect = false;
            isValueCorrect = double.TryParse(radiusForFirstCircle.Text, out outputValue);
            if (!isValueCorrect)
            {
                MessageBox.Show("В поле были некорректные значения - любые знаки, помимо цифр. Введите данные снова.");
                radiusForFirstCircle.Clear();
                radiusForFirstCircle.Focus();
            }
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

        private void xCoordForScndCircle_TextChanged(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isValueCorrect = false;
            isValueCorrect = double.TryParse(xCoordForScndCircle.Text, out outputValue);
            if (!isValueCorrect)
            {
                MessageBox.Show("В поле были некорректные значения - любые знаки, помимо цифр. Введите данные снова.");
                xCoordForScndCircle.Clear();
                xCoordForScndCircle.Focus();
            }
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

        private void yCoordForScndCircle_TextChanged(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isValueCorrect = false;
            isValueCorrect = double.TryParse(yCoordForScndCircle.Text, out outputValue);
            if (!isValueCorrect)
            {
                MessageBox.Show("В поле были некорректные значения - любые знаки, помимо цифр. Введите данные снова.");
                yCoordForScndCircle.Clear();
                yCoordForScndCircle.Focus();
            }
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
        }

        private void radiusForScndCircle_TextChanged(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isValueCorrect = false;
            isValueCorrect = double.TryParse(radiusForScndCircle.Text, out outputValue);
            if (!isValueCorrect)
            {
                MessageBox.Show("В поле были некорректные значения - любые знаки, помимо цифр. Введите данные снова.");
                radiusForScndCircle.Clear();
                radiusForScndCircle.Focus();
            }
        }
        
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
            double AreaCrosedCircles = 0;
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
                AreaCrosedCircles = pi * rad1 * rad1;
                else if (rad2 < rad1)
                AreaCrosedCircles = pi * rad2 * rad2;

            }
            else
            {
                TmpAcos1 = ((rad1 * rad1 - rad2 * rad2 + distance * distance) / (2 * rad1 * distance));
                TmpAcos2 = ((rad2 * rad2 - rad1 * rad1 + distance * distance) / (2 * rad2 * distance));
                F1 = 2 * Math.Acos(TmpAcos1);
                F2 = 2 * Math.Acos(TmpAcos2);
                TriangleArea1 = (rad1 * rad1 * (F1 - Math.Sin(F1))) / 2;
                TriangleArea2 = (rad2 * rad2 * (F2 - Math.Sin(F2))) / 2;

                AreaCrosedCircles = TriangleArea1 + TriangleArea2;
            }
            show_Answer(AreaCrosedCircles);

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
                labelSaveInFile.Visible = true;
                BtnSaveInFile.Visible = true;
                labelSaveResults.Visible = true;
                btnSaveResults.Visible = true;
            }
            else
            {
                AnswerLabel.Visible = false;
                TotalAreaMessage.Visible = false;
                labelSaveInFile.Visible = false;
                BtnSaveInFile.Visible = false;
                labelSaveResults.Visible = false;
                btnSaveResults.Visible = false;
            }

        }

        private void BtnSaveInFile_Click(object sender, EventArgs e)
        {
            GC.Collect();
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "*.txt|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(fileDialog.FileName));
                writer.WriteLine(xCoordForFirstCircle.Text);
                writer.WriteLine(yCoordForFirstCircle.Text);
                writer.WriteLine(radiusForFirstCircle.Text);
                
                writer.WriteLine(xCoordForScndCircle.Text);
                writer.WriteLine(yCoordForScndCircle.Text);
                writer.WriteLine(radiusForScndCircle.Text);
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
        }

        private void takeValuesFromFile_Click(object sender, EventArgs e)
        {
            double inputData;
            Stream myStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file = openFile.FileName;
                    if (!file.Contains(".txt"))
                    {
                        MessageBox.Show("Файл недопустимого типа.", "Упс!");
                        openFile.ShowDialog();
                    }

                    if ((myStream = openFile.OpenFile()) != null)
                    {
                        using (StreamReader fileReader = new StreamReader(openFile.FileName))
                        {
                            string[] values = fileReader.ReadToEnd().Split('\n');
                            try
                            {
                                for (int i = 0; i < values.Length-1; i++)
                                {
                                    inputData = Convert.ToDouble(values[i]);
                                }
                                xCoordForFirstCircle.Text = values[0];
                                yCoordForFirstCircle.Text = values[1];

                                radiusForFirstCircle.Text = values[2];

                                xCoordForScndCircle.Text = values[3];
                                yCoordForScndCircle.Text = values[4];
                                radiusForScndCircle.Text = values[5];
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            fileReader.Close();
                        }
                    }

                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            GC.Collect();
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "*.txt|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(fileDialog.FileName));
                writer.WriteLine("Первый круг:\n\n");
                writer.WriteLine("Координаты:\n");
                writer.WriteLine("x: " + xCoordForFirstCircle.Text + " ");
                writer.WriteLine("y: " + yCoordForFirstCircle.Text + "\n");
                writer.WriteLine("Радиус: " + radiusForFirstCircle.Text + "\n\n");
                
                writer.WriteLine("Второй круг:\n\n");
                writer.WriteLine("Координаты:\n");
                writer.WriteLine("x: " + xCoordForScndCircle.Text + " ");
                writer.WriteLine("y: " + yCoordForScndCircle.Text + "\n");
                writer.WriteLine("Радиус: " + radiusForScndCircle.Text + "\n\n");
                writer.WriteLine("Общая площадь этих кругов: " + AnswerLabel.Text);
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
        }
    }
}
