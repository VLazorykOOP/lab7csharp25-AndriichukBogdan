using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab7CSharp
{
    public partial class Task3 : Form
    {
        private Random random = new Random();
        private List<Shape> shapes = new List<Shape>();

        public Task3()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string shapeType = comboBoxShape.SelectedItem.ToString();
            Color shapeColor = pictureBoxColor.BackColor;
            string text = textBoxText.Text;

            int x = random.Next(10, pictureBoxCanvas.Width - 60);
            int y = random.Next(10, pictureBoxCanvas.Height - 60);

            Shape shape = null;
            if (shapeType == "Квадрат")
                shape = new Square(x, y, shapeColor, text);
            else if (shapeType == "Прямокутник")
                shape = new RectangleShape(x, y, shapeColor, text);
            else if (shapeType == "Еліпс")
                shape = new EllipseShape(x, y, shapeColor, text);
            else if (shapeType == "Ромб")
                shape = new Rhombus(x, y, shapeColor, text);

            if (shape != null)
            {
                shapes.Add(shape);
                pictureBoxCanvas.Invalidate();
            }
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
                shape.Draw(e.Graphics);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBoxColor.BackColor = colorDialog1.Color;
        }
    }

    abstract class Shape
    {
        public int X, Y;
        public Color Color;
        public string Text;

        public Shape(int x, int y, Color color, string text)
        {
            X = x;
            Y = y;
            Color = color;
            Text = text;
        }

        public abstract void Draw(Graphics g);
    }

    class Square : Shape
    {
        public Square(int x, int y, Color color, string text) : base(x, y, color, text) { }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, X, Y, 50, 50);
            g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, X + 10, Y + 20);
        }
    }

    class RectangleShape : Shape
    {
        public RectangleShape(int x, int y, Color color, string text) : base(x, y, color, text) { }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, X, Y, 70, 40);
            g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, X + 10, Y + 15);
        }
    }

    class EllipseShape : Shape
    {
        public EllipseShape(int x, int y, Color color, string text) : base(x, y, color, text) { }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, X, Y, 60, 40);
            g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, X + 10, Y + 15);
        }
    }

    class Rhombus : Shape
    {
        public Rhombus(int x, int y, Color color, string text) : base(x, y, color, text) { }

        public override void Draw(Graphics g)
        {
            Point[] points = {
                new Point(X + 25, Y),
                new Point(X + 50, Y + 25),
                new Point(X + 25, Y + 50),
                new Point(X, Y + 25)
            };
            Brush brush = new SolidBrush(Color);
            g.FillPolygon(brush, points);
            g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, X + 5, Y + 20);
        }
    }
}