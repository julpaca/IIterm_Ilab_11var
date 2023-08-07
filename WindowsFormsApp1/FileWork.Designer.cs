
namespace WindowsFormsApp1
{
    partial class FileWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
        {
            this.LoadValuesFromFile = new System.Windows.Forms.Button();
            this.BtnSaveValuesInFile = new System.Windows.Forms.Button();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadValuesFromFile
            // 
            this.LoadValuesFromFile.Location = new System.Drawing.Point(15, 200);
            this.LoadValuesFromFile.Name = "LoadValuesFromFile";
            this.LoadValuesFromFile.Size = new System.Drawing.Size(147, 53);
            this.LoadValuesFromFile.TabIndex = 24;
            this.LoadValuesFromFile.Text = "Загрузить данные из файла";
            this.LoadValuesFromFile.UseVisualStyleBackColor = true;
            this.LoadValuesFromFile.Click += new System.EventHandler(this.LoadValuesFromFile_Click);
            // 
            // BtnSaveValuesInFile
            // 
            this.BtnSaveValuesInFile.Location = new System.Drawing.Point(15, 55);
            this.BtnSaveValuesInFile.Name = "BtnSaveValuesInFile";
            this.BtnSaveValuesInFile.Size = new System.Drawing.Size(147, 54);
            this.BtnSaveValuesInFile.TabIndex = 25;
            this.BtnSaveValuesInFile.Text = "Сохранить исходные значения";
            this.BtnSaveValuesInFile.UseVisualStyleBackColor = true;
            this.BtnSaveValuesInFile.Click += new System.EventHandler(this.BtnSaveValuesInFile_Click);
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Location = new System.Drawing.Point(15, 129);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(147, 54);
            this.btnSaveResults.TabIndex = 32;
            this.btnSaveResults.Text = "Сохранить результат";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Location = new System.Drawing.Point(216, 125);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(142, 58);
            this.btnReturnToMainForm.TabIndex = 35;
            this.btnReturnToMainForm.Text = "Вернуться на главную форму";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // FileWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 292);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.btnSaveResults);
            this.Controls.Add(this.BtnSaveValuesInFile);
            this.Controls.Add(this.LoadValuesFromFile);
            this.Name = "FileWork";
            this.Text = "FileWork";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileWork_FormClosing);
            this.Load += new System.EventHandler(this.FileWork_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadValuesFromFile;
        private System.Windows.Forms.Button BtnSaveValuesInFile;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Button btnReturnToMainForm;
    }
}