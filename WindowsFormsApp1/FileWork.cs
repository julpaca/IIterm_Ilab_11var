using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FileWork : Form
    {
        Circle firstCircle = new Circle();
        Circle secondCircle = new Circle();
        public FileWork(Circle firstC, Circle secondC)
        {
            InitializeComponent();
            firstCircle = firstC;
            secondCircle = secondC;
        }

        private void FileWork_Load(object sender, EventArgs e)
        {
            if (Answer.canCirclesBeSaved == false)
            {
                MessageBox.Show("Данные о кругах не были заполнены полностью, поэтому функции сохранения данных будут отключены.", "Упс!");
                btnSaveResults.Enabled = false;
                BtnSaveValuesInFile.Enabled = false;
            }

            else if (Answer.canResultsBeSaved == false)
            {
                MessageBox.Show("Данные о результате вычисления не были получены, поэтому функция сохранения результата будет отключена.", "Упс!");
                btnSaveResults.Enabled = false;
            }

            else if (Answer.isDataCorrect == false)
            {
                MessageBox.Show(".Данные в полях были некорректны, функции сохранения будут отключены.", "Упс!");
                btnSaveResults.Enabled = false;
                BtnSaveValuesInFile.Enabled = false;
            }
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            FileWork.ActiveForm.Hide();
            MainForm MainForm = new MainForm(firstCircle, secondCircle);
            MainForm.ShowDialog();
            Close();
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
                writer.WriteLine("x: " + Convert.ToString(firstCircle.xC) + " ");
                writer.WriteLine("y: " + Convert.ToString(firstCircle.yC) + "\n");
                writer.WriteLine("Радиус: " + Convert.ToString(firstCircle.rad) + "\n\n");

                writer.WriteLine("Второй круг:\n\n");
                writer.WriteLine("Координаты:\n");
                writer.WriteLine("x: " + Convert.ToString(secondCircle.xC) + " ");
                writer.WriteLine("y: " + Convert.ToString(secondCircle.yC) + "\n");
                writer.WriteLine("Радиус: " + Convert.ToString(secondCircle.rad) + "\n\n");
                writer.WriteLine("Общая площадь этих кругов: " + Convert.ToString(Answer.answer));
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
        }

        private void BtnSaveValuesInFile_Click(object sender, EventArgs e)
        {
            GC.Collect();
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "*.txt|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(fileDialog.FileName));
                writer.WriteLine(Convert.ToString(firstCircle.xC));
                writer.WriteLine(Convert.ToString(firstCircle.yC));
                writer.WriteLine(Convert.ToString(firstCircle.rad));

                writer.WriteLine(Convert.ToString(secondCircle.xC));
                writer.WriteLine(Convert.ToString(secondCircle.yC));
                writer.WriteLine(Convert.ToString(secondCircle.rad));
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
        }

        private void LoadValuesFromFile_Click(object sender, EventArgs e)
        {
            double inputData = 0;
            bool exAboutLen = false;
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
                            int dim = 0;
                            if(values.GetLength(dim) != 6)
                            {
                                MessageBox.Show("Количество элементов в файле не совпадает с необходимым.","Упс!");
                                fileReader.Close();
                                exAboutLen = true;
                            }
                            else
                            {
                                try
                                {
                                    for (int i = 0; i < values.Length - 1; i++)
                                    {
                                        inputData = Convert.ToDouble(values[i]);
                                    }
                                    firstCircle.xC = Convert.ToDouble(values[0]);
                                    firstCircle.yC = Convert.ToDouble(values[1]);
                                    firstCircle.rad = Convert.ToDouble(values[2]);

                                    secondCircle.xC = Convert.ToDouble(values[3]);
                                    secondCircle.yC = Convert.ToDouble(values[4]);
                                    secondCircle.rad = Convert.ToDouble(values[5]);

                                    Answer.isDataFromFile = true;
                                    FileWork.ActiveForm.Hide();
                                    MessageBox.Show("Данные были успешно загружены.", "Поздравляю!");
                                    MainForm mainForm = new MainForm(firstCircle, secondCircle);
                                    mainForm.ShowDialog();
                                    Close();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            //fileReader.Close();
                        }
                    }

                }

                catch (Exception ex)
                {
                    if (exAboutLen == false)
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FileWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            string greetingStatus = System.IO.File.ReadAllText("Cache.txt");
            if (greetingStatus.Contains("Work with files...") && greetingStatus.Contains("Greeting is enabled"))
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            } 
            else if (greetingStatus.Contains("Work with files...") && greetingStatus.Contains("Greeting is disabled"))
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            }
            else if (greetingStatus.Contains("Work with files..."))
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            }
        }


        /*private void btnSaveResults_Click(object sender, EventArgs e)
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
                writer.WriteLine("x: " + Convert.ToString(FirstCircle.xCoord) + " ");
                writer.WriteLine("y: " + Convert.ToString(FirstCircle.yCoord) + "\n");
                writer.WriteLine("Радиус: " + Convert.ToString(FirstCircle.radius) + "\n\n");

                writer.WriteLine("Второй круг:\n\n");
                writer.WriteLine("Координаты:\n");
                writer.WriteLine("x: " + Convert.ToString(SecondCircle.xCoord) + " ");
                writer.WriteLine("y: " + Convert.ToString(SecondCircle.yCoord) + "\n");
                writer.WriteLine("Радиус: " + Convert.ToString(SecondCircle.radius) + "\n\n");
                writer.WriteLine("Общая площадь этих кругов: " + Convert.ToString(Answer.answer));
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
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
                writer.WriteLine(Convert.ToString(FirstCircle.xCoord));
                writer.WriteLine(Convert.ToString(FirstCircle.yCoord));
                writer.WriteLine(Convert.ToString(FirstCircle.radius));

                writer.WriteLine(Convert.ToString(SecondCircle.xCoord));
                writer.WriteLine(Convert.ToString(SecondCircle.yCoord));
                writer.WriteLine(Convert.ToString(SecondCircle.radius));
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
        }*/
    }
}
