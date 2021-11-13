using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GraphEditorApp
{
    enum Sing
    {
        pointSing,
        textSing,
        lineSing,
        rectSing,
        ellipseSing,
        eraserSing
    }    

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            formWidth = pictureBox1.Size.Width;
            formHeight = pictureBox1.Size.Height;
            bmp = new Bitmap(formWidth, formHeight);
            graph = Graphics.FromImage(bmp);
            graph.Clear(Color.FromKnownColor(KnownColor.White));
            pictureBox1.Image = bmp;
            this.ResizeEnd += new EventHandler(Form2_ResizeEnd);            
            ((Form1)this.ParentForm).ColorHandler += new Form1.HandlerColor(Form2_ColorHandler);
            ((Form1)this.ParentForm).WeightHandler += new Form1.HandlerWeight(Form2_WeightHandler);
        }

        void Form2_WeightHandler(int Weight)
        {
            fontSize = Weight;
            pen = new Pen(fontColor, fontSize);
            eraserPen = new Pen(Color.FromKnownColor(KnownColor.White), fontSize);
        }
        public void Form2_ColorHandler(Color color)
        {
            fontColor = color;
            pen = new Pen(fontColor, fontSize);
        }

        void Form2_ResizeEnd(object sender, EventArgs e)
        {
            formWidth = pictureBox1.Size.Width;
            formHeight = pictureBox1.Size.Height;
            bmp = new Bitmap(formWidth, formHeight);
            graph = Graphics.FromImage(bmp);
            graph.Clear(Color.FromKnownColor(KnownColor.White));            
            pictureBox1.Image = bmp;
            foreach (Figure figure in Figures)
                figure.DrawFigure(graph, figure.figurePen, figure.figurePointBegin, figure.figurePointEnd, figure.figureSing, figure.figureFont, figure.figureText);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (newFigure.figureSing != Sing.pointSing && newFigure.figureSing != Sing.eraserSing && newFigure.figureSing != Sing.textSing)
            {
                if (mouseMove)
                    Figures.Add(newFigure);                
            }
            mouseMove = false;
        }

        bool mouseDown, mouseMove;
        List<Figure> Figures = new List<Figure>();
        Figure newFigure;
        Graphics graph;
        static Color fontColor = Color.Black;
        static int fontSize = 3;
        public Pen pen = new Pen(fontColor, fontSize);
        Pen eraserPen = new Pen(Color.FromKnownColor(KnownColor.White), 3);
        public Font font = new Font("Times", 12);
        Form3 formText;
        int formWidth, formHeight;
        public Bitmap bmp;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                newFigure = new Figure();
                newFigure.figurePointBegin.X = e.X;
                newFigure.figurePointBegin.Y = e.Y;
                Form1 parentForm = (Form1)MdiParent;
                newFigure.figurePen = pen;

                switch (parentForm.currentTool)
                {
                    case Tools.PEN:
                        newFigure.figureSing = Sing.pointSing;
                        break;
                    case Tools.TEXT:
                        newFigure.figureSing = Sing.textSing;
                        formText = new Form3();
                        formText.Owner = this;
                        formText.richTextBox1.Font = this.font;
                        formText.toolStripTextBox2.Text = font.Name + ", " + font.SizeInPoints.ToString() + "pt, " + font.Style.ToString();
                        formText.ApplyHandler += new EventHandler(formText_ApplyHandler);
                        formText.toolStripTextBox1.Text = ColorTranslator.ToHtml(((Form1)this.ParentForm).color);
                        formText.ShowDialog();
                        break;
                    case Tools.LINE:
                        newFigure.figureSing = Sing.lineSing;
                        break;
                    case Tools.RECTANGLE:
                        newFigure.figureSing = Sing.rectSing;
                        break;
                    case Tools.ELLIPSE:
                        newFigure.figureSing = Sing.ellipseSing;
                        break;
                    case Tools.ERASER:
                        newFigure.figureSing = Sing.eraserSing;
                        newFigure.figurePen = eraserPen;
                        break;
                    default:
                        break;
                }
            }
        }

        void formText_ApplyHandler(object sender, EventArgs e)
        {
            Form3 formText = (Form3)sender;
            ControlCollection controls = (Form.ControlCollection)formText.Controls;
            foreach (Control control in controls)
            {
                if ((control as RichTextBox) != null)
                {
                    newFigure.figureText = control.Text;
                    newFigure.figureFont = control.Font;
                    newFigure.figurePen = pen;
                }
            }
            graph.DrawString(newFigure.figureText, newFigure.figureFont, new SolidBrush(pen.Color), newFigure.figurePointBegin);
            pictureBox1.Image = bmp;
            Figures.Add(newFigure);
            if (Figures != null)
                foreach (Figure figure in Figures)
                    figure.DrawFigure(graph, figure.figurePen, figure.figurePointBegin, figure.figurePointEnd, figure.figureSing, figure.figureFont, figure.figureText);                        
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y, width, height;
            Point pointEnd;            
            if (mouseDown)
            {
                mouseMove = true;                
                foreach (Figure figure in Figures)
                    figure.DrawFigure(graph, figure.figurePen, figure.figurePointBegin, figure.figurePointEnd, figure.figureSing, figure.figureFont, figure.figureText);
                newFigure.figurePointEnd = new Point(e.X, e.Y);

                switch (newFigure.figureSing)
                {
                    case Sing.pointSing:
                        graph.DrawLine(newFigure.figurePen, newFigure.figurePointBegin, newFigure.figurePointEnd);
                        pictureBox1.Image = bmp;
                        Figures.Add(newFigure);
                        pointEnd = new Point(newFigure.figurePointEnd.X, newFigure.figurePointEnd.Y);
                        newFigure = new Figure();
                        newFigure.figurePointBegin = pointEnd;
                        newFigure.figurePen = pen;
                        break;
                    case Sing.lineSing:
                        graph.Clear(Color.FromKnownColor(KnownColor.White));                        
                        if (Figures != null)
                            foreach (Figure figure in Figures)
                                figure.DrawFigure(graph, figure.figurePen, figure.figurePointBegin, figure.figurePointEnd, figure.figureSing, figure.figureFont, figure.figureText);
                        graph.DrawLine(newFigure.figurePen, newFigure.figurePointBegin, newFigure.figurePointEnd);
                        pictureBox1.Image = bmp;
                        break;
                    case Sing.rectSing:
                        graph.Clear(Color.FromKnownColor(KnownColor.White));                        
                        if (Figures != null)
                            foreach (Figure figure in Figures)
                                figure.DrawFigure(graph, figure.figurePen, figure.figurePointBegin, figure.figurePointEnd, figure.figureSing, figure.figureFont, figure.figureText);
                        x = newFigure.figurePointBegin.X;
                        y = newFigure.figurePointBegin.Y;
                        width = newFigure.figurePointEnd.X - newFigure.figurePointBegin.X;
                        height = newFigure.figurePointEnd.Y - newFigure.figurePointBegin.Y;
                        graph.DrawRectangle(pen, x, y, width, height);
                        pictureBox1.Image = bmp;
                        break;
                    case Sing.ellipseSing:
                        graph.Clear(Color.FromKnownColor(KnownColor.White));                        
                        if (Figures != null)
                            foreach (Figure figure in Figures)
                                figure.DrawFigure(graph, figure.figurePen, figure.figurePointBegin, figure.figurePointEnd, figure.figureSing, figure.figureFont, figure.figureText);
                        x = newFigure.figurePointBegin.X;
                        y = newFigure.figurePointBegin.Y;
                        width = newFigure.figurePointEnd.X - newFigure.figurePointBegin.X;
                        height = newFigure.figurePointEnd.Y - newFigure.figurePointBegin.Y;
                        graph.DrawEllipse(pen, x, y, width, height);
                        pictureBox1.Image = bmp;
                        break;
                    case Sing.eraserSing:
                        graph.DrawLine(eraserPen, newFigure.figurePointBegin, newFigure.figurePointEnd);
                        pictureBox1.Image = bmp;
                        Figures.Add(newFigure);
                        pointEnd = new Point(newFigure.figurePointEnd.X, newFigure.figurePointEnd.Y);
                        newFigure = new Figure();
                        newFigure.figurePointBegin = pointEnd;
                        newFigure.figurePen = eraserPen;
                        newFigure.figureSing = Sing.eraserSing;
                        break;
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                fs.Close();
            }
        }
    }
}
