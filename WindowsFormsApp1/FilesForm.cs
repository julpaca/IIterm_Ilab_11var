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

namespace TotalCommonAreaOfCirclesSearch
{
    public partial class FileForm : Form
    {
        Circle firstCircle = new Circle();
        Circle secondCircle = new Circle();
        public FileForm(Circle firstC, Circle secondC)
        {
            InitializeComponent();
            firstCircle = firstC;
            secondCircle = secondC;
        }

        private void FilesForm_Load(object sender, EventArgs e)
        {
            if (InformationForFiles.CanCirclesBeSaved == false)
            {
                MessageBox.Show("Данные о кругах не были заполнены полностью, поэтому функции сохранения данных будут отключены.", "Упс!");
                btnSaveResult.Enabled = false;
                btnSaveValues.Enabled = false;
            }

            else if (InformationForFiles.CanResultsBeSaved == false)
            {
                MessageBox.Show("Данные о результате вычисления не были получены, поэтому функция сохранения результата будет отключена.", "Упс!");
                btnSaveResult.Enabled = false;
            }

            else if (InformationForFiles.IsDataCorrect == false)
            {
                MessageBox.Show(".Данные в полях были некорректны, функции сохранения будут отключены.", "Упс!");
                btnSaveResult.Enabled = false;
                btnSaveValues.Enabled = false;
            }
        }

        private void BtnReturnToMainForm_Click(object sender, EventArgs e)
        {
            FileForm.ActiveForm.Hide();
            MainForm MainForm = new MainForm(firstCircle, secondCircle);
            MainForm.ShowDialog();
            Close();
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
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
                writer.WriteLine("x: " + Convert.ToString(firstCircle.XC) + " ");
                writer.WriteLine("y: " + Convert.ToString(firstCircle.YC) + "\n");
                writer.WriteLine("Радиус: " + Convert.ToString(firstCircle.Rad) + "\n\n");

                writer.WriteLine("Второй круг:\n\n");
                writer.WriteLine("Координаты:\n");
                writer.WriteLine("x: " + Convert.ToString(secondCircle.XC) + " ");
                writer.WriteLine("y: " + Convert.ToString(secondCircle.YC) + "\n");
                writer.WriteLine("Радиус: " + Convert.ToString(secondCircle.Rad) + "\n\n");
                writer.WriteLine("Общая площадь этих кругов: " + Convert.ToString(InformationForFiles.totalArea));
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
        }

        private void BtnSaveValues_Click(object sender, EventArgs e)
        {
            GC.Collect();
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "*.txt|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(fileDialog.FileName));
                writer.WriteLine(Convert.ToString(firstCircle.XC));
                writer.WriteLine(Convert.ToString(firstCircle.YC));
                writer.WriteLine(Convert.ToString(firstCircle.Rad));

                writer.WriteLine(Convert.ToString(secondCircle.XC));
                writer.WriteLine(Convert.ToString(secondCircle.YC));
                writer.WriteLine(Convert.ToString(secondCircle.Rad));
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
        }

        private void LoadValues_Click(object sender, EventArgs e)
        {
            double inputData = 0;
            bool lenExeption = false;
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

                            if (values.Contains(""))
                                values = values.Take(values.Count() - 1).ToArray();

                            int dim = 0;
                            if(values.GetLength(dim) != 6)
                            {
                                MessageBox.Show("Количество элементов в файле не совпадает с необходимым.","Упс!");
                                fileReader.Close();
                                lenExeption = true;
                            }
                            else
                            {
                                try
                                {
                                    for (int i = 0; i < values.Length - 1; i++)
                                    {
                                        inputData = Convert.ToDouble(values[i]);
                                    }
                                    firstCircle.XC = Convert.ToDouble(values[0]);
                                    firstCircle.YC = Convert.ToDouble(values[1]);
                                    firstCircle.Rad = Convert.ToDouble(values[2]);

                                    secondCircle.XC = Convert.ToDouble(values[3]);
                                    secondCircle.YC = Convert.ToDouble(values[4]);
                                    secondCircle.Rad = Convert.ToDouble(values[5]);

                                    InformationForFiles.IsDataFromFile = true;
                                    FileForm.ActiveForm.Hide();
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
                        }
                    }

                }

                catch (Exception ex)
                {
                    if (lenExeption == false)
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FilesForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
