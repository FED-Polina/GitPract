namespace PractGit
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mult = new System.Windows.Forms.TextBox();
            this.label_mul = new System.Windows.Forms.Label();
            this.textBox_dev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(51, 105);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(75, 20);
            this.textBox_add.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // textBox_sub
            // 
            this.textBox_sub.Location = new System.Drawing.Point(145, 105);
            this.textBox_sub.Name = "textBox_sub";
            this.textBox_sub.Size = new System.Drawing.Size(75, 20);
            this.textBox_sub.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // textBox_mult
            // 
            this.textBox_mult.Location = new System.Drawing.Point(226, 105);
            this.textBox_mult.Name = "textBox_mult";
            this.textBox_mult.Size = new System.Drawing.Size(75, 20);
            this.textBox_mult.TabIndex = 7;
            // 
            // label_mul
            // 
            this.label_mul.AutoSize = true;
            this.label_mul.Location = new System.Drawing.Point(223, 86);
            this.label_mul.Name = "label_mul";
            this.label_mul.Size = new System.Drawing.Size(11, 13);
            this.label_mul.TabIndex = 8;
            this.label_mul.Text = "*";
            // textBox_dev
            // 
            this.textBox_dev.Location = new System.Drawing.Point(51, 170);
            this.textBox_dev.Name = "textBox_dev";
            this.textBox_dev.Size = new System.Drawing.Size(75, 20);
            this.textBox_dev.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 267);
            this.Controls.Add(this.label_mul);
            this.Controls.Add(this.textBox_mult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_dev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_sub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mult;
        private System.Windows.Forms.Label label_mul;
        private System.Windows.Forms.TextBox textBox_dev;
        private System.Windows.Forms.Label label3;
    }
}

