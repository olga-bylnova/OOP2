using OOP1._1.figure_factories;

namespace OOP1._1
{
    public partial class Form1 : Form
    {
        Graphics g;
        private bool isMousePressed = false;
        const int limit = 3;
        PointsArray pointsArray;
        Pen pen = new Pen(Color.Black, 2f);
        SolidBrush solidBrush = new SolidBrush(Color.Black);        
        Color fillColor = Color.Black;
        Color lineColor = Color.Black;
        FigureFactory figureFactory;
        Figure figure;
        PointsArray figurePoints;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pointsArray = new PointsArray(limit-1);
            figurePoints = new PointsArray(limit);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            pointsArray.ResetArray();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMousePressed) { return; }
            if (brush_checkBox.Checked)
            {
                pointsArray.SetPoint(e.X, e.Y);
                if (pointsArray.GetPointCount() >= 2)
                {
                    g.DrawLines(pen, pointsArray.GetPoints());
                    pointsArray.SetPoint(e.X, e.Y);
                }
            }
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }
        private void draw_button_Click(object sender, EventArgs e)
        {
            if (!brush_checkBox.Checked)
            {                
                figure = figureFactory.CreateFigure(g, figurePoints.GetPoints());
                figure.Draw(g, fillColor, lineColor, trackBar1.Value, check_fill.Checked, check_line.Checked);
            }
            figurePoints.ResetArray();
        }
        private void ellipse_button_Click(object sender, EventArgs e)
        {
            figureFactory = new EllipseFactory();
        }        
        private void circle_button_Click(object sender, EventArgs e)
        {
            figureFactory = new CircleFactory();
        }
        private void square_button_Click(object sender, EventArgs e)
        {
            figureFactory = new SquareFactory();
        }
        private void rect_button_Click(object sender, EventArgs e)
        {
            figureFactory = new RectangleFactory();
        }
        private void triangle_button_Click(object sender, EventArgs e)
        {
            figureFactory = new PolygonFactory();
        }
        private void line_button_Click(object sender, EventArgs e)
        {
            figureFactory = new LineFactory();
        }
        private void fill_button_Click(object sender, EventArgs e)
        {
            fillColor = ((Button)sender).BackColor;
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
        }
        private void line_color_dialog_button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lineColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }
        private void line_color_button_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
            lineColor = ((Button)sender).BackColor;
        }
        private void fill_color_dialog_button_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDialog2.Color;
                ((Button)sender).BackColor = colorDialog2.Color;
            }
        }
        private void polygon_button_Click(object sender, EventArgs e)
        {
            figureFactory = new PolygonFactory();
        }        
        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (!brush_checkBox.Checked)
            {
                figurePoints.SetPoint(e.X, e.Y);
            }
        }
    }
}