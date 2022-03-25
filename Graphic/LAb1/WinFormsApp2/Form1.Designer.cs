
namespace WinFormsApp2
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
            this.first_x = new System.Windows.Forms.TextBox();
            this.first_y = new System.Windows.Forms.TextBox();
            this.second_x = new System.Windows.Forms.TextBox();
            this.second_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.system_algorythm = new System.Windows.Forms.TextBox();
            this.Bresenhems = new System.Windows.Forms.TextBox();
            this.DigitalDifferentialAnalyzer = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_x
            // 
            this.first_x.Location = new System.Drawing.Point(63, 572);
            this.first_x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.first_x.Name = "first_x";
            this.first_x.Size = new System.Drawing.Size(189, 23);
            this.first_x.TabIndex = 0;
            // 
            // first_y
            // 
            this.first_y.Location = new System.Drawing.Point(63, 614);
            this.first_y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.first_y.Name = "first_y";
            this.first_y.Size = new System.Drawing.Size(189, 23);
            this.first_y.TabIndex = 1;
            // 
            // second_x
            // 
            this.second_x.Location = new System.Drawing.Point(300, 571);
            this.second_x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.second_x.Name = "second_x";
            this.second_x.Size = new System.Drawing.Size(191, 23);
            this.second_x.TabIndex = 2;
            // 
            // second_y
            // 
            this.second_y.Location = new System.Drawing.Point(300, 606);
            this.second_y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.second_y.Name = "second_y";
            this.second_y.Size = new System.Drawing.Size(191, 23);
            this.second_y.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 575);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 574);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 617);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 614);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y2";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Green;
            this.start.Location = new System.Drawing.Point(568, 550);
            this.start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(117, 39);
            this.start.TabIndex = 9;
            this.start.Text = "Побудувати";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.StartBuilding_Click);
            // 
            // default_algorithm
            // 
            this.system_algorythm.Enabled = false;
            this.system_algorythm.Location = new System.Drawing.Point(97, 532);
            this.system_algorythm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.system_algorythm.Name = "default_algorithm";
            this.system_algorythm.Size = new System.Drawing.Size(45, 23);
            this.system_algorythm.TabIndex = 10;
            // 
            // Bresenhems
            // 
            this.Bresenhems.Enabled = false;
            this.Bresenhems.Location = new System.Drawing.Point(260, 532);
            this.Bresenhems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bresenhems.Name = "Bresenhems";
            this.Bresenhems.Size = new System.Drawing.Size(45, 23);
            this.Bresenhems.TabIndex = 11;
            // 
            // CDAs
            // 
            this.DigitalDifferentialAnalyzer.Enabled = false;
            this.DigitalDifferentialAnalyzer.Location = new System.Drawing.Point(416, 532);
            this.DigitalDifferentialAnalyzer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DigitalDifferentialAnalyzer.Name = "CDAs";
            this.DigitalDifferentialAnalyzer.Size = new System.Drawing.Size(45, 23);
            this.DigitalDifferentialAnalyzer.TabIndex = 12;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Location = new System.Drawing.Point(736, 550);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(125, 40);
            this.clear.TabIndex = 13;
            this.clear.Text = "Видалити";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.deleteSymbols_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 498);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(13, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вбудований \r\nалгоритм";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(180, 525);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Алгоритм \r\nБрезенхема";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(343, 525);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Алгоритм \r\nЦДА";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 540);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "мс";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 540);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "мс";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 540);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "мс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(915, 647);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.DigitalDifferentialAnalyzer);
            this.Controls.Add(this.Bresenhems);
            this.Controls.Add(this.system_algorythm);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.second_y);
            this.Controls.Add(this.second_x);
            this.Controls.Add(this.first_y);
            this.Controls.Add(this.first_x);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(931, 686);
            this.MinimumSize = new System.Drawing.Size(931, 686);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_x;
        private System.Windows.Forms.TextBox first_y;
        private System.Windows.Forms.TextBox second_x;
        private System.Windows.Forms.TextBox second_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox system_algorythm;
        private System.Windows.Forms.TextBox Bresenhems;
        private System.Windows.Forms.TextBox DigitalDifferentialAnalyzer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}




