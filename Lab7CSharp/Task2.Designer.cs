namespace Lab7CSharp
{
    partial class Task2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.GroupBox groupBoxWidth;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton rbSolid;
        private System.Windows.Forms.RadioButton rbDash;
        private System.Windows.Forms.RadioButton rbDot;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.groupBoxWidth = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.rbSolid = new System.Windows.Forms.RadioButton();
            this.rbDash = new System.Windows.Forms.RadioButton();
            this.rbDot = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();

            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            this.btnStart.Location = new System.Drawing.Point(630, 380);
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.Text = "Пуск";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            this.groupBoxColor.Controls.Add(this.rbRed);
            this.groupBoxColor.Controls.Add(this.rbBlue);
            this.groupBoxColor.Controls.Add(this.rbGreen);
            this.groupBoxColor.Location = new System.Drawing.Point(630, 12);
            this.groupBoxColor.Size = new System.Drawing.Size(120, 100);
            this.groupBoxColor.Text = "Колір";

            this.rbRed.Text = "Червоний";
            this.rbRed.Location = new System.Drawing.Point(10, 20);
            this.rbBlue.Text = "Синій";
            this.rbBlue.Location = new System.Drawing.Point(10, 40);
            this.rbGreen.Text = "Зелений";
            this.rbGreen.Location = new System.Drawing.Point(10, 60);

            this.groupBoxWidth.Controls.Add(this.rbThin);
            this.groupBoxWidth.Controls.Add(this.rbMedium);
            this.groupBoxWidth.Controls.Add(this.rbThick);
            this.groupBoxWidth.Location = new System.Drawing.Point(630, 120);
            this.groupBoxWidth.Size = new System.Drawing.Size(120, 100);
            this.groupBoxWidth.Text = "Товщина";

            this.rbThin.Text = "Тонка";
            this.rbThin.Location = new System.Drawing.Point(10, 20);
            this.rbMedium.Text = "Середня";
            this.rbMedium.Location = new System.Drawing.Point(10, 40);
            this.rbThick.Text = "Товста";
            this.rbThick.Location = new System.Drawing.Point(10, 60);

            this.groupBoxStyle.Controls.Add(this.rbSolid);
            this.groupBoxStyle.Controls.Add(this.rbDash);
            this.groupBoxStyle.Controls.Add(this.rbDot);
            this.groupBoxStyle.Location = new System.Drawing.Point(630, 230);
            this.groupBoxStyle.Size = new System.Drawing.Size(120, 100);
            this.groupBoxStyle.Text = "Стиль";

            this.rbSolid.Text = "Суцільна";
            this.rbSolid.Location = new System.Drawing.Point(10, 20);
            this.rbDash.Text = "Пунктир";
            this.rbDash.Location = new System.Drawing.Point(10, 40);
            this.rbDot.Text = "Точкова";
            this.rbDot.Location = new System.Drawing.Point(10, 60);

            this.ClientSize = new System.Drawing.Size(770, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxWidth);
            this.Controls.Add(this.groupBoxStyle);
            this.Text = "Анімований графік";
            this.ResumeLayout(false);
        }
    }
}