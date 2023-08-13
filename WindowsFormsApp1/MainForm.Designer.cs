namespace TotalCommonAreaOfCirclesSearch
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbXCoordForFirstCircle = new System.Windows.Forms.TextBox();
            this.tbRadiusForFirstCircle = new System.Windows.Forms.TextBox();
            this.tbYCoordForFirstCircle = new System.Windows.Forms.TextBox();
            this.tbXCoordForScndCircle = new System.Windows.Forms.TextBox();
            this.tbYCoordForScndCircle = new System.Windows.Forms.TextBox();
            this.tbRadiusForScndCircle = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.lbltotalAreaMessage = new System.Windows.Forms.Label();
            this.lblFirstCircleInfo = new System.Windows.Forms.Label();
            this.lblScndCircleInfo = new System.Windows.Forms.Label();
            this.btnReadyValues = new System.Windows.Forms.Button();
            this.cbGreetingStatus = new System.Windows.Forms.CheckBox();
            this.btnGoToFilesForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите -/+ x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите -/+ y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите радиус круга:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите -/+ х:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите -/+ y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите радиус круга:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(23, 259);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 46);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Посчитать!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // tbXCoordForFirstCircle
            // 
            this.tbXCoordForFirstCircle.Location = new System.Drawing.Point(20, 58);
            this.tbXCoordForFirstCircle.Name = "tbXCoordForFirstCircle";
            this.tbXCoordForFirstCircle.Size = new System.Drawing.Size(74, 20);
            this.tbXCoordForFirstCircle.TabIndex = 13;
            this.tbXCoordForFirstCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // tbRadiusForFirstCircle
            // 
            this.tbRadiusForFirstCircle.Location = new System.Drawing.Point(20, 97);
            this.tbRadiusForFirstCircle.Name = "tbRadiusForFirstCircle";
            this.tbRadiusForFirstCircle.Size = new System.Drawing.Size(74, 20);
            this.tbRadiusForFirstCircle.TabIndex = 14;
            this.tbRadiusForFirstCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // tbYCoordForFirstCircle
            // 
            this.tbYCoordForFirstCircle.Location = new System.Drawing.Point(103, 58);
            this.tbYCoordForFirstCircle.Name = "tbYCoordForFirstCircle";
            this.tbYCoordForFirstCircle.Size = new System.Drawing.Size(74, 20);
            this.tbYCoordForFirstCircle.TabIndex = 15;
            this.tbYCoordForFirstCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // tbXCoordForScndCircle
            // 
            this.tbXCoordForScndCircle.Location = new System.Drawing.Point(20, 177);
            this.tbXCoordForScndCircle.Name = "tbXCoordForScndCircle";
            this.tbXCoordForScndCircle.Size = new System.Drawing.Size(74, 20);
            this.tbXCoordForScndCircle.TabIndex = 16;
            this.tbXCoordForScndCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // tbYCoordForScndCircle
            // 
            this.tbYCoordForScndCircle.Location = new System.Drawing.Point(103, 177);
            this.tbYCoordForScndCircle.Name = "tbYCoordForScndCircle";
            this.tbYCoordForScndCircle.Size = new System.Drawing.Size(74, 20);
            this.tbYCoordForScndCircle.TabIndex = 17;
            this.tbYCoordForScndCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // tbRadiusForScndCircle
            // 
            this.tbRadiusForScndCircle.Location = new System.Drawing.Point(23, 216);
            this.tbRadiusForScndCircle.Name = "tbRadiusForScndCircle";
            this.tbRadiusForScndCircle.Size = new System.Drawing.Size(71, 20);
            this.tbRadiusForScndCircle.TabIndex = 18;
            this.tbRadiusForScndCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLabel.Location = new System.Drawing.Point(510, 69);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 20);
            this.AnswerLabel.TabIndex = 19;
            this.AnswerLabel.Visible = false;
            this.AnswerLabel.TextChanged += new System.EventHandler(this.AnswerLabel_TextChanged);
            // 
            // lbltotalAreaMessage
            // 
            this.lbltotalAreaMessage.AutoSize = true;
            this.lbltotalAreaMessage.Location = new System.Drawing.Point(396, 42);
            this.lbltotalAreaMessage.Name = "lbltotalAreaMessage";
            this.lbltotalAreaMessage.Size = new System.Drawing.Size(186, 13);
            this.lbltotalAreaMessage.TabIndex = 21;
            this.lbltotalAreaMessage.Text = "Общая площадь кругов составила:";
            this.lbltotalAreaMessage.Visible = false;
            // 
            // lblFirstCircleInfo
            // 
            this.lblFirstCircleInfo.AutoSize = true;
            this.lblFirstCircleInfo.Location = new System.Drawing.Point(17, 24);
            this.lblFirstCircleInfo.Name = "lblFirstCircleInfo";
            this.lblFirstCircleInfo.Size = new System.Drawing.Size(174, 13);
            this.lblFirstCircleInfo.TabIndex = 27;
            this.lblFirstCircleInfo.Text = "Введите данные о первом круге:";
            // 
            // lblScndCircleInfo
            // 
            this.lblScndCircleInfo.AutoSize = true;
            this.lblScndCircleInfo.Location = new System.Drawing.Point(17, 143);
            this.lblScndCircleInfo.Name = "lblScndCircleInfo";
            this.lblScndCircleInfo.Size = new System.Drawing.Size(173, 13);
            this.lblScndCircleInfo.TabIndex = 28;
            this.lblScndCircleInfo.Text = "Введите данные о втором круге:";
            // 
            // btnReadyValues
            // 
            this.btnReadyValues.Location = new System.Drawing.Point(213, 126);
            this.btnReadyValues.Name = "btnReadyValues";
            this.btnReadyValues.Size = new System.Drawing.Size(119, 48);
            this.btnReadyValues.TabIndex = 29;
            this.btnReadyValues.Text = "Хочу готовые значения!";
            this.btnReadyValues.UseVisualStyleBackColor = true;
            this.btnReadyValues.Click += new System.EventHandler(this.btnReadyValues_Click);
            // 
            // cbGreetingStatus
            // 
            this.cbGreetingStatus.AutoSize = true;
            this.cbGreetingStatus.Location = new System.Drawing.Point(20, 345);
            this.cbGreetingStatus.Name = "cbGreetingStatus";
            this.cbGreetingStatus.Size = new System.Drawing.Size(148, 17);
            this.cbGreetingStatus.TabIndex = 32;
            this.cbGreetingStatus.Text = "Отключить приветствие";
            this.cbGreetingStatus.UseVisualStyleBackColor = true;
            // 
            // btnGoToFilesForm
            // 
            this.btnGoToFilesForm.Location = new System.Drawing.Point(399, 259);
            this.btnGoToFilesForm.Name = "btnGoToFilesForm";
            this.btnGoToFilesForm.Size = new System.Drawing.Size(174, 48);
            this.btnGoToFilesForm.TabIndex = 33;
            this.btnGoToFilesForm.Text = "Сохранить/Загрузить данные";
            this.btnGoToFilesForm.UseVisualStyleBackColor = true;
            this.btnGoToFilesForm.Click += new System.EventHandler(this.btnGoToFilesForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 378);
            this.Controls.Add(this.btnGoToFilesForm);
            this.Controls.Add(this.cbGreetingStatus);
            this.Controls.Add(this.btnReadyValues);
            this.Controls.Add(this.lblScndCircleInfo);
            this.Controls.Add(this.lblFirstCircleInfo);
            this.Controls.Add(this.lbltotalAreaMessage);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.tbRadiusForScndCircle);
            this.Controls.Add(this.tbYCoordForScndCircle);
            this.Controls.Add(this.tbXCoordForScndCircle);
            this.Controls.Add(this.tbYCoordForFirstCircle);
            this.Controls.Add(this.tbRadiusForFirstCircle);
            this.Controls.Add(this.tbXCoordForFirstCircle);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Поиск общей площади кругов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbXCoordForFirstCircle;
        private System.Windows.Forms.TextBox tbRadiusForFirstCircle;
        private System.Windows.Forms.TextBox tbYCoordForFirstCircle;
        private System.Windows.Forms.TextBox tbXCoordForScndCircle;
        private System.Windows.Forms.TextBox tbYCoordForScndCircle;
        private System.Windows.Forms.TextBox tbRadiusForScndCircle;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label lbltotalAreaMessage;
        private System.Windows.Forms.Label lblFirstCircleInfo;
        private System.Windows.Forms.Label lblScndCircleInfo;
        private System.Windows.Forms.Button btnReadyValues;
        private System.Windows.Forms.CheckBox cbGreetingStatus;
        private System.Windows.Forms.Button btnGoToFilesForm;
    }
}

