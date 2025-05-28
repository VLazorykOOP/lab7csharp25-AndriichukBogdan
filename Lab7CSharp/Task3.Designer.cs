namespace Lab7CSharp
{
    partial class Task3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(500, 300);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(530, 160);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 30);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Створити";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Квадрат",
            "Прямокутник",
            "Еліпс",
            "Ромб"});
            this.comboBoxShape.Location = new System.Drawing.Point(530, 30);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShape.TabIndex = 2;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(530, 70);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(121, 20);
            this.textBoxText.TabIndex = 3;
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BackColor = System.Drawing.Color.Red;
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColor.Location = new System.Drawing.Point(530, 110);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(40, 20);
            this.pictureBoxColor.TabIndex = 4;
            this.pictureBoxColor.TabStop = false;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(580, 110);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(70, 23);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.Text = "Колір";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(530, 10);
            this.label1.Text = "Тип фігури:";
            this.label1.Size = new System.Drawing.Size(100, 20);
            // 
            // Task3
            // 
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Task3";
            this.Text = "Task 3 - Фігури";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}