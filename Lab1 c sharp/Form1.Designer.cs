namespace Lab1_c_sharp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxVector = new System.Windows.Forms.RichTextBox();
            this.textBoX1 = new System.Windows.Forms.TextBox();
            this.textBoX2 = new System.Windows.Forms.TextBox();
            this.textBoX3 = new System.Windows.Forms.TextBox();
            this.textBoY2 = new System.Windows.Forms.TextBox();
            this.textBoY1 = new System.Windows.Forms.TextBox();
            this.textBoY3 = new System.Windows.Forms.TextBox();
            this.textBoZ1 = new System.Windows.Forms.TextBox();
            this.textBoZ2 = new System.Windows.Forms.TextBox();
            this.textBoZ3 = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalcButton);
            this.panel1.Controls.Add(this.textBoZ3);
            this.panel1.Controls.Add(this.textBoZ2);
            this.panel1.Controls.Add(this.textBoZ1);
            this.panel1.Controls.Add(this.textBoY3);
            this.panel1.Controls.Add(this.textBoY1);
            this.panel1.Controls.Add(this.textBoY2);
            this.panel1.Controls.Add(this.textBoX3);
            this.panel1.Controls.Add(this.textBoX2);
            this.panel1.Controls.Add(this.textBoX1);
            this.panel1.Controls.Add(this.richTextBoxVector);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 557);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vector\'s calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Input 1 vector (x, y, z)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Input 2 vector (x, y, z)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Input 3 vector (x, y, z)";
            // 
            // richTextBoxVector
            // 
            this.richTextBoxVector.Location = new System.Drawing.Point(0, 258);
            this.richTextBoxVector.Name = "richTextBoxVector";
            this.richTextBoxVector.Size = new System.Drawing.Size(630, 298);
            this.richTextBoxVector.TabIndex = 11;
            this.richTextBoxVector.Text = "";
            // 
            // textBoX1
            // 
            this.textBoX1.Location = new System.Drawing.Point(151, 58);
            this.textBoX1.Name = "textBoX1";
            this.textBoX1.Size = new System.Drawing.Size(39, 20);
            this.textBoX1.TabIndex = 1;
            // 
            // textBoX2
            // 
            this.textBoX2.Location = new System.Drawing.Point(151, 92);
            this.textBoX2.Name = "textBoX2";
            this.textBoX2.Size = new System.Drawing.Size(39, 20);
            this.textBoX2.TabIndex = 4;
            // 
            // textBoX3
            // 
            this.textBoX3.Location = new System.Drawing.Point(151, 128);
            this.textBoX3.Name = "textBoX3";
            this.textBoX3.Size = new System.Drawing.Size(39, 20);
            this.textBoX3.TabIndex = 7;
            // 
            // textBoY2
            // 
            this.textBoY2.Location = new System.Drawing.Point(196, 92);
            this.textBoY2.Name = "textBoY2";
            this.textBoY2.Size = new System.Drawing.Size(40, 20);
            this.textBoY2.TabIndex = 5;
            // 
            // textBoY1
            // 
            this.textBoY1.Location = new System.Drawing.Point(196, 58);
            this.textBoY1.Name = "textBoY1";
            this.textBoY1.Size = new System.Drawing.Size(40, 20);
            this.textBoY1.TabIndex = 2;
            // 
            // textBoY3
            // 
            this.textBoY3.Location = new System.Drawing.Point(196, 128);
            this.textBoY3.Name = "textBoY3";
            this.textBoY3.Size = new System.Drawing.Size(40, 20);
            this.textBoY3.TabIndex = 8;
            // 
            // textBoZ1
            // 
            this.textBoZ1.Location = new System.Drawing.Point(242, 58);
            this.textBoZ1.Name = "textBoZ1";
            this.textBoZ1.Size = new System.Drawing.Size(40, 20);
            this.textBoZ1.TabIndex = 3;
            // 
            // textBoZ2
            // 
            this.textBoZ2.Location = new System.Drawing.Point(242, 92);
            this.textBoZ2.Name = "textBoZ2";
            this.textBoZ2.Size = new System.Drawing.Size(40, 20);
            this.textBoZ2.TabIndex = 6;
            // 
            // textBoZ3
            // 
            this.textBoZ3.Location = new System.Drawing.Point(242, 128);
            this.textBoZ3.Name = "textBoZ3";
            this.textBoZ3.Size = new System.Drawing.Size(40, 20);
            this.textBoZ3.TabIndex = 9;
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcButton.Location = new System.Drawing.Point(-1, 206);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(629, 46);
            this.CalcButton.TabIndex = 10;
            this.CalcButton.Text = "C     A     L     C     U     L     A     T     E     ";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 581);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.TextBox textBoZ3;
        private System.Windows.Forms.TextBox textBoZ2;
        private System.Windows.Forms.TextBox textBoZ1;
        private System.Windows.Forms.TextBox textBoY3;
        private System.Windows.Forms.TextBox textBoY1;
        private System.Windows.Forms.TextBox textBoY2;
        private System.Windows.Forms.TextBox textBoX3;
        private System.Windows.Forms.TextBox textBoX2;
        private System.Windows.Forms.TextBox textBoX1;
        private System.Windows.Forms.RichTextBox richTextBoxVector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

