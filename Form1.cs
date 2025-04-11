using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_0
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private Pen currentPen;
        private Color currentColor = Color.Black;
        private Bitmap canvasBitmap;
        private int currentBrushSize = 3;
        private Brushes currentBrush;
        private Dictionary<string, Brushes> brushes = new Dictionary<string, Brushes>();
        private Shapes currentShape;
        private Tool currentTool = Tool.Brush;



        public Form1()
        {
            InitializeComponent();
            InitializeBrushes();

            canvasBitmap = new Bitmap(canvas.Width, canvas.Height);
            canvas.Image = canvasBitmap;

            currentPen = new Pen(currentColor, currentBrushSize);
            currentPen.StartCap = currentPen.EndCap = LineCap.Round;

            canvas.MouseDown += Canvas_MouseDown;
            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseUp += Canvas_MouseUp;
            btnClear.Click += BtnClear_Click;
            btnColor.Click += BtnColor_Click;
            btnBlack.Click += (s, e) => { currentColor = Color.Black; currentPen.Color = currentColor; };
            btnRed.Click += (s, e) => { currentColor = Color.FromArgb(192, 0, 0); currentPen.Color = currentColor; };
            btnGreen.Click += (s, e) => { currentColor = Color.FromArgb(0, 192, 0); currentPen.Color = currentColor; };
            btnBlue.Click += (s, e) => { currentColor = Color.FromArgb(51, 153, 255); currentPen.Color = currentColor; };
            btnYellow.Click += (s, e) => { currentColor = Color.Yellow; currentPen.Color = currentColor; };
            btnDBlue.Click += (s, e) => { currentColor = Color.DarkBlue; currentPen.Color = currentColor; };
            btnGray.Click += (s, e) => { currentColor = Color.Gray; currentPen.Color = currentColor; };
            btnPurple.Click += (s, e) => { currentColor = Color.Purple; currentPen.Color = currentColor; };
            btnCanvasColor.Click += BtnCanvasCol;
            btnSquare.Click += btnSquareC;
            btnRect.Click += btnRectC;
            btnEllipse.Click += btnEllipseC;
            btnCircle.Click += btnCircleC;
            cboBrushType.Click += btnBT;

            this.Resize += Form1_Resize;
        }

        private void InitializeBrushes()
        {
            brushes.Add("Default", new Default());
            brushes.Add("Spray", new Spray());
            brushes.Add("Crayon", new Crayon());
            brushes.Add("Calligraphy", new CalligraphyPen());
            brushes.Add("Oil Paint", new OilPaint());
            brushes.Add("Marker", new Marker());
            brushes.Add("Eraser", new Eraser(canvas));
            currentBrush = brushes["Default"];
        }

        private void cboBrushType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboBrushType.SelectedItem.ToString();
            currentBrush = brushes[selected];
        }

        private void brushSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            currentBrushSize = brushSizeTrackBar.Value;
            currentPen.Width = currentBrushSize;
            UpdateBrushSizeDisplay();
        }

        private void numBrushSize_ValueChanged(object sender, EventArgs e)
        {
            currentBrushSize = (int)numBrushSize.Value;
            brushSizeTrackBar.Value = currentBrushSize;
            currentPen.Width = currentBrushSize;
            UpdateBrushSizeDisplay();
        }

        private void UpdateBrushSizeDisplay()
        {
            lblBrushSize.Text = $"Size: {currentBrushSize}px";
            if (numBrushSize.Value != currentBrushSize)
            {
                numBrushSize.Value = currentBrushSize;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (canvas.Width > 0 && canvas.Height > 0)
            {
                Bitmap newBitmap = new Bitmap(canvas.Width, canvas.Height);
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.Clear(Color.White);
                    if (canvasBitmap != null)
                    {
                        g.DrawImage(canvasBitmap, Point.Empty);
                    }
                }
                canvasBitmap = newBitmap;
                canvas.Image = canvasBitmap;
            }
        }

        private void Canvas_MouseDown(object s, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;

            if (currentTool == Tool.Brush)
            {
                currentShape = null;
            }
            else
            {
                switch (currentTool)
                {
                    case Tool.Square:
                        currentShape = new Square();
                        break;
                    case Tool.Rectangle:
                        currentShape = new ShapeRectangle();
                        break;
                    case Tool.Ellipse:
                        currentShape = new Ellipse();
                        break;
                    case Tool.Circle:
                        currentShape = new Circle();
                        break;
                }

                if (currentShape != null)
                {
                    currentShape.StartPoint = e.Location;
                }
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (currentTool == Tool.Brush)
                {
                    using (Graphics g = Graphics.FromImage(canvasBitmap))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        currentBrush.Draw(g, e.Location, previousPoint, currentPen);
                    }
                    canvas.Invalidate();
                    previousPoint = e.Location;
                }
                else if (currentShape != null)
                {
                    currentShape.EndPoint = e.Location;
                    canvas.Invalidate();
                    using (Graphics g = canvas.CreateGraphics())
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        currentShape.Draw(g, currentPen);
                    }
                }
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            if (currentTool == Tool.Brush)
            {
            }
            else if (currentShape != null)
            {
                currentShape.EndPoint = e.Location;

                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    currentShape.Draw(g, currentPen);
                }

                canvas.Invalidate();
                currentShape = null;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.White);
            }
            canvas.Invalidate();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = currentColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
                currentPen.Color = currentColor;
            }
        }

        private void BtnCanvasCol(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = currentColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.BackColor = colorDialog.Color;

                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    g.Clear(colorDialog.Color);
                }

                canvas.Invalidate();
            }
        }
        private void btnSquareC(object sender, EventArgs e)
        {
            currentTool = Tool.Square;
        }
        private void btnRectC(object sender, EventArgs e)
        {
            currentTool = Tool.Rectangle;
        }
        private void btnEllipseC(object sender, EventArgs e)
        {
            currentTool = Tool.Ellipse;
        }
        private void btnCircleC(object sender, EventArgs e)
        {
            currentTool = Tool.Circle;
        }
        private void btnBT(object sender, EventArgs e)
        {
            currentTool = Tool.Brush;
        }

    }
}
