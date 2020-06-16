namespace _1_ekzamen
{
    partial class ThreeDigitNumbers
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbHundreds = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbOne = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblHundreds = new System.Windows.Forms.Label();
            this.lblTens = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(107, 90);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(103, 20);
            this.tbNumber.TabIndex = 0;
            this.tbNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumber_KeyDown);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // tbHundreds
            // 
            this.tbHundreds.Location = new System.Drawing.Point(216, 160);
            this.tbHundreds.Name = "tbHundreds";
            this.tbHundreds.ReadOnly = true;
            this.tbHundreds.Size = new System.Drawing.Size(45, 20);
            this.tbHundreds.TabIndex = 1;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(216, 199);
            this.tbTen.Name = "tbTen";
            this.tbTen.ReadOnly = true;
            this.tbTen.Size = new System.Drawing.Size(45, 20);
            this.tbTen.TabIndex = 2;
            // 
            // tbOne
            // 
            this.tbOne.Location = new System.Drawing.Point(216, 237);
            this.tbOne.Name = "tbOne";
            this.tbOne.ReadOnly = true;
            this.tbOne.Size = new System.Drawing.Size(45, 20);
            this.tbOne.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Tomato;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(107, 116);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(103, 32);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Расчёт";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblHundreds
            // 
            this.lblHundreds.AutoSize = true;
            this.lblHundreds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHundreds.Location = new System.Drawing.Point(51, 160);
            this.lblHundreds.Name = "lblHundreds";
            this.lblHundreds.Size = new System.Drawing.Size(159, 20);
            this.lblHundreds.TabIndex = 5;
            this.lblHundreds.Text = "В этом числе сотен";
            // 
            // lblTens
            // 
            this.lblTens.AutoSize = true;
            this.lblTens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTens.Location = new System.Drawing.Point(23, 199);
            this.lblTens.Name = "lblTens";
            this.lblTens.Size = new System.Drawing.Size(187, 20);
            this.lblTens.TabIndex = 6;
            this.lblTens.Text = "В этом числе десятков";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOne.Location = new System.Drawing.Point(39, 235);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(171, 20);
            this.lblOne.TabIndex = 7;
            this.lblOne.Text = "В этом числе единиц";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите трёхзначное число\r\n и нажмите кнопку \"Расчёт\"";
            // 
            // ThreeDigitNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(315, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lblTens);
            this.Controls.Add(this.lblHundreds);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbHundreds);
            this.Controls.Add(this.tbNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThreeDigitNumbers";
            this.Text = "Цифры трехзначного числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbHundreds;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbOne;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblHundreds;
        private System.Windows.Forms.Label lblTens;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label label4;
    }
}

