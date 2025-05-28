using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Task2 : Form
    {
        private Timer timer;
        private float x;
        private const float xMin = -2f;
        private const float xMax = 2f;
        private const float step = 0.05f;

        private Pen graphPen = new Pen(Color.Black, 2);
        private PointF[] points = new PointF[0];

        public Task2()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;

            x = xMin;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (x > xMax)
            {
                timer.Stop();
                return;
            }

            float y = (1 - x * x) * (x - 2);
            Array.Resize(ref points, points.Length + 1);
            points[points.Length - 1] = ToScreenCoords(x, y);
            x += step;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawAxes(g);

            if (points.Length > 1)
                g.DrawLines(graphPen, points);
        }

        private void DrawAxes(Graphics g)
        {
            Pen axisPen = new Pen(Color.Gray, 1);
            int cx = panel1.Width / 2;
            int cy = panel1.Height / 2;

            g.DrawLine(axisPen, 0, cy, panel1.Width, cy);
            g.DrawLine(axisPen, cx, 0, cx, panel1.Height);
        }

        private PointF ToScreenCoords(float x, float y)
        {
            float scaleX = panel1.Width / 4f;
            float scaleY = -panel1.Height / 10f;
            float sx = panel1.Width / 2f + x * scaleX;
            float sy = panel1.Height / 2f + y * scaleY;
            return new PointF(sx, sy);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            x = xMin;
            points = new PointF[0];

            if (rbRed.Checked) graphPen.Color = Color.Red;
            else if (rbBlue.Checked) graphPen.Color = Color.Blue;
            else if (rbGreen.Checked) graphPen.Color = Color.Green;

            if (rbThin.Checked) graphPen.Width = 1;
            else if (rbMedium.Checked) graphPen.Width = 2;
            else if (rbThick.Checked) graphPen.Width = 3;

            if (rbSolid.Checked) graphPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else if (rbDash.Checked) graphPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            else if (rbDot.Checked) graphPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            timer.Start();
        }
    }
}