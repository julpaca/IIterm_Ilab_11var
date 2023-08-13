
namespace TotalCommonAreaOfCirclesSearch
{
    partial class FileForm
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
            this.LoadValues = new System.Windows.Forms.Button();
            this.btnSaveValues = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadValues
            // 
            this.LoadValues.Location = new System.Drawing.Point(15, 200);
            this.LoadValues.Name = "LoadValues";
            this.LoadValues.Size = new System.Drawing.Size(147, 53);
            this.LoadValues.TabIndex = 24;
            this.LoadValues.Text = "Загрузить данные из файла";
            this.LoadValues.UseVisualStyleBackColor = true;
            this.LoadValues.Click += new System.EventHandler(this.LoadValues_Click);
            // 
            // btnSaveValues
            // 
            this.btnSaveValues.Location = new System.Drawing.Point(15, 55);
            this.btnSaveValues.Name = "btnSaveValues";
            this.btnSaveValues.Size = new System.Drawing.Size(147, 54);
            this.btnSaveValues.TabIndex = 25;
            this.btnSaveValues.Text = "Сохранить исходные значения";
            this.btnSaveValues.UseVisualStyleBackColor = true;
            this.btnSaveValues.Click += new System.EventHandler(this.BtnSaveValues_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(15, 129);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(147, 54);
            this.btnSaveResult.TabIndex = 32;
            this.btnSaveResult.Text = "Сохранить результат";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Location = new System.Drawing.Point(216, 125);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(142, 58);
            this.btnReturnToMainForm.TabIndex = 35;
            this.btnReturnToMainForm.Text = "Вернуться на главную форму";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.BtnReturnToMainForm_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 292);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.btnSaveResult);
            this.Controls.Add(this.btnSaveValues);
            this.Controls.Add(this.LoadValues);
            this.Name = "FileForm";
            this.Text = "Сохранение/загрузка данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilesForm_FormClosing);
            this.Load += new System.EventHandler(this.FilesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadValues;
        private System.Windows.Forms.Button btnSaveValues;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Button btnReturnToMainForm;
    }
}