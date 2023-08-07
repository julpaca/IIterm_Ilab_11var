namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.xCoordForFirstCircle = new System.Windows.Forms.TextBox();
            this.radiusForFirstCircle = new System.Windows.Forms.TextBox();
            this.yCoordForFirstCircle = new System.Windows.Forms.TextBox();
            this.xCoordForScndCircle = new System.Windows.Forms.TextBox();
            this.yCoordForScndCircle = new System.Windows.Forms.TextBox();
            this.radiusForScndCircle = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.TotalAreaMessage = new System.Windows.Forms.Label();
            this.labelAboutProgram = new System.Windows.Forms.Label();
            this.labelFirstCircleInfo = new System.Windows.Forms.Label();
            this.labelScndCircleInfo = new System.Windows.Forms.Label();
            this.buttonReadyValues = new System.Windows.Forms.Button();
            this.cbGreetingStatus = new System.Windows.Forms.CheckBox();
            this.btnGoToFileWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите -/+ x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите -/+ y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите радиус круга:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите -/+ х:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите -/+ y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите радиус круга:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(25, 335);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(118, 46);
            this.calculate.TabIndex = 12;
            this.calculate.Text = "Посчитать!";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // xCoordForFirstCircle
            // 
            this.xCoordForFirstCircle.Location = new System.Drawing.Point(22, 134);
            this.xCoordForFirstCircle.Name = "xCoordForFirstCircle";
            this.xCoordForFirstCircle.Size = new System.Drawing.Size(74, 20);
            this.xCoordForFirstCircle.TabIndex = 13;
            this.xCoordForFirstCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // radiusForFirstCircle
            // 
            this.radiusForFirstCircle.Location = new System.Drawing.Point(22, 173);
            this.radiusForFirstCircle.Name = "radiusForFirstCircle";
            this.radiusForFirstCircle.Size = new System.Drawing.Size(74, 20);
            this.radiusForFirstCircle.TabIndex = 14;
            this.radiusForFirstCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // yCoordForFirstCircle
            // 
            this.yCoordForFirstCircle.Location = new System.Drawing.Point(105, 134);
            this.yCoordForFirstCircle.Name = "yCoordForFirstCircle";
            this.yCoordForFirstCircle.Size = new System.Drawing.Size(74, 20);
            this.yCoordForFirstCircle.TabIndex = 15;
            this.yCoordForFirstCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // xCoordForScndCircle
            // 
            this.xCoordForScndCircle.Location = new System.Drawing.Point(22, 253);
            this.xCoordForScndCircle.Name = "xCoordForScndCircle";
            this.xCoordForScndCircle.Size = new System.Drawing.Size(74, 20);
            this.xCoordForScndCircle.TabIndex = 16;
            this.xCoordForScndCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // yCoordForScndCircle
            // 
            this.yCoordForScndCircle.Location = new System.Drawing.Point(105, 253);
            this.yCoordForScndCircle.Name = "yCoordForScndCircle";
            this.yCoordForScndCircle.Size = new System.Drawing.Size(74, 20);
            this.yCoordForScndCircle.TabIndex = 17;
            this.yCoordForScndCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // radiusForScndCircle
            // 
            this.radiusForScndCircle.Location = new System.Drawing.Point(25, 292);
            this.radiusForScndCircle.Name = "radiusForScndCircle";
            this.radiusForScndCircle.Size = new System.Drawing.Size(71, 20);
            this.radiusForScndCircle.TabIndex = 18;
            this.radiusForScndCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLabel.Location = new System.Drawing.Point(512, 145);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 20);
            this.AnswerLabel.TabIndex = 19;
            this.AnswerLabel.Visible = false;
            this.AnswerLabel.TextChanged += new System.EventHandler(this.AnswerLabel_TextChanged);
            // 
            // TotalAreaMessage
            // 
            this.TotalAreaMessage.AutoSize = true;
            this.TotalAreaMessage.Location = new System.Drawing.Point(398, 118);
            this.TotalAreaMessage.Name = "TotalAreaMessage";
            this.TotalAreaMessage.Size = new System.Drawing.Size(186, 13);
            this.TotalAreaMessage.TabIndex = 21;
            this.TotalAreaMessage.Text = "Общая площадь кругов составила:";
            this.TotalAreaMessage.Visible = false;
            // 
            // labelAboutProgram
            // 
            this.labelAboutProgram.AutoSize = true;
            this.labelAboutProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutProgram.Location = new System.Drawing.Point(31, 9);
            this.labelAboutProgram.Name = "labelAboutProgram";
            this.labelAboutProgram.Size = new System.Drawing.Size(712, 48);
            this.labelAboutProgram.TabIndex = 26;
            this.labelAboutProgram.Text = resources.GetString("labelAboutProgram.Text");
            this.labelAboutProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstCircleInfo
            // 
            this.labelFirstCircleInfo.AutoSize = true;
            this.labelFirstCircleInfo.Location = new System.Drawing.Point(19, 100);
            this.labelFirstCircleInfo.Name = "labelFirstCircleInfo";
            this.labelFirstCircleInfo.Size = new System.Drawing.Size(174, 13);
            this.labelFirstCircleInfo.TabIndex = 27;
            this.labelFirstCircleInfo.Text = "Введите данные о первом круге:";
            // 
            // labelScndCircleInfo
            // 
            this.labelScndCircleInfo.AutoSize = true;
            this.labelScndCircleInfo.Location = new System.Drawing.Point(19, 219);
            this.labelScndCircleInfo.Name = "labelScndCircleInfo";
            this.labelScndCircleInfo.Size = new System.Drawing.Size(173, 13);
            this.labelScndCircleInfo.TabIndex = 28;
            this.labelScndCircleInfo.Text = "Введите данные о втором круге:";
            // 
            // buttonReadyValues
            // 
            this.buttonReadyValues.Location = new System.Drawing.Point(198, 225);
            this.buttonReadyValues.Name = "buttonReadyValues";
            this.buttonReadyValues.Size = new System.Drawing.Size(119, 48);
            this.buttonReadyValues.TabIndex = 29;
            this.buttonReadyValues.Text = "Хочу готовые значения!";
            this.buttonReadyValues.UseVisualStyleBackColor = true;
            this.buttonReadyValues.Click += new System.EventHandler(this.buttonReadyValues_Click);
            // 
            // cbGreetingStatus
            // 
            this.cbGreetingStatus.AutoSize = true;
            this.cbGreetingStatus.Location = new System.Drawing.Point(22, 421);
            this.cbGreetingStatus.Name = "cbGreetingStatus";
            this.cbGreetingStatus.Size = new System.Drawing.Size(148, 17);
            this.cbGreetingStatus.TabIndex = 32;
            this.cbGreetingStatus.Text = "Отключить приветствие";
            this.cbGreetingStatus.UseVisualStyleBackColor = true;
            // 
            // btnGoToFileWork
            // 
            this.btnGoToFileWork.Location = new System.Drawing.Point(569, 335);
            this.btnGoToFileWork.Name = "btnGoToFileWork";
            this.btnGoToFileWork.Size = new System.Drawing.Size(174, 48);
            this.btnGoToFileWork.TabIndex = 33;
            this.btnGoToFileWork.Text = "Сохранить/Загрузить данные";
            this.btnGoToFileWork.UseVisualStyleBackColor = true;
            this.btnGoToFileWork.Click += new System.EventHandler(this.btnGoToFileWork_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.btnGoToFileWork);
            this.Controls.Add(this.cbGreetingStatus);
            this.Controls.Add(this.buttonReadyValues);
            this.Controls.Add(this.labelScndCircleInfo);
            this.Controls.Add(this.labelFirstCircleInfo);
            this.Controls.Add(this.labelAboutProgram);
            this.Controls.Add(this.TotalAreaMessage);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.radiusForScndCircle);
            this.Controls.Add(this.yCoordForScndCircle);
            this.Controls.Add(this.xCoordForScndCircle);
            this.Controls.Add(this.yCoordForFirstCircle);
            this.Controls.Add(this.radiusForFirstCircle);
            this.Controls.Add(this.xCoordForFirstCircle);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
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
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox xCoordForFirstCircle;
        private System.Windows.Forms.TextBox radiusForFirstCircle;
        private System.Windows.Forms.TextBox yCoordForFirstCircle;
        private System.Windows.Forms.TextBox xCoordForScndCircle;
        private System.Windows.Forms.TextBox yCoordForScndCircle;
        private System.Windows.Forms.TextBox radiusForScndCircle;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label TotalAreaMessage;
        private System.Windows.Forms.Label labelAboutProgram;
        private System.Windows.Forms.Label labelFirstCircleInfo;
        private System.Windows.Forms.Label labelScndCircleInfo;
        private System.Windows.Forms.Button buttonReadyValues;
        private System.Windows.Forms.CheckBox cbGreetingStatus;
        private System.Windows.Forms.Button btnGoToFileWork;
    }
}

