namespace Lab7CSharp
{
    partial class Task2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ColorB3 = new System.Windows.Forms.RadioButton();
            this.ColorB1 = new System.Windows.Forms.RadioButton();
            this.ColorB2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorB2);
            this.groupBox1.Controls.Add(this.ColorB1);
            this.groupBox1.Controls.Add(this.ColorB3);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ColorB3
            // 
            this.ColorB3.AutoSize = true;
            this.ColorB3.Location = new System.Drawing.Point(8, 116);
            this.ColorB3.Name = "ColorB3";
            this.ColorB3.Size = new System.Drawing.Size(66, 24);
            this.ColorB3.TabIndex = 0;
            this.ColorB3.TabStop = true;
            this.ColorB3.Text = "Blue";
            this.ColorB3.UseVisualStyleBackColor = true;
            this.ColorB3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ColorB1
            // 
            this.ColorB1.AutoSize = true;
            this.ColorB1.Location = new System.Drawing.Point(8, 34);
            this.ColorB1.Name = "ColorB1";
            this.ColorB1.Size = new System.Drawing.Size(64, 24);
            this.ColorB1.TabIndex = 1;
            this.ColorB1.TabStop = true;
            this.ColorB1.Text = "Red";
            this.ColorB1.UseVisualStyleBackColor = true;
            // 
            // ColorB2
            // 
            this.ColorB2.AutoSize = true;
            this.ColorB2.Location = new System.Drawing.Point(8, 76);
            this.ColorB2.Name = "ColorB2";
            this.ColorB2.Size = new System.Drawing.Size(79, 24);
            this.ColorB2.TabIndex = 2;
            this.ColorB2.TabStop = true;
            this.ColorB2.Text = "Green";
            this.ColorB2.UseVisualStyleBackColor = true;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 603);
            this.Controls.Add(this.groupBox1);
            this.Name = "Task2";
            this.Text = "Task2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ColorB2;
        private System.Windows.Forms.RadioButton ColorB1;
        private System.Windows.Forms.RadioButton ColorB3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}