
namespace Lab7CSharp
{
    partial class Task1
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
            this.Plus = new System.Windows.Forms.RadioButton();
            this.Minus = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Divine = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.Location = new System.Drawing.Point(210, 258);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(64, 24);
            this.Plus.TabIndex = 0;
            this.Plus.TabStop = true;
            this.Plus.Text = "Plus";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.CheckedChanged += new System.EventHandler(this.Plus_CheckedChanged);
            // 
            // Minus
            // 
            this.Minus.AutoSize = true;
            this.Minus.Location = new System.Drawing.Point(423, 258);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(76, 24);
            this.Minus.TabIndex = 1;
            this.Minus.TabStop = true;
            this.Minus.Text = "Minus";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(620, 258);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Multi";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Divine
            // 
            this.Divine.AutoSize = true;
            this.Divine.Location = new System.Drawing.Point(826, 258);
            this.Divine.Name = "Divine";
            this.Divine.Size = new System.Drawing.Size(77, 24);
            this.Divine.TabIndex = 3;
            this.Divine.TabStop = true;
            this.Divine.Text = "Divine";
            this.Divine.UseVisualStyleBackColor = true;
            this.Divine.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(620, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Result.Location = new System.Drawing.Point(383, 337);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(254, 66);
            this.Result.TabIndex = 6;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Location = new System.Drawing.Point(474, 103);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(0, 20);
            this.ResultText.TabIndex = 7;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 482);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Divine);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task1";
            this.Text = "Task Calulatot(1)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Plus;
        private System.Windows.Forms.RadioButton Minus;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton Divine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label ResultText;
    }
}

