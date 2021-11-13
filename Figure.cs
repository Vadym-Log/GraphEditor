using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphEditorApp
{
    class Figure
    {   
        public Sing figureSing;
        public Point figurePointBegin, figurePointEnd;
        public Pen figurePen;
        public string figureText;
        public Font figureFont;

        public void DrawFigure(Graphics graph, Pen pen, Point pointBegin, Point pointEnd, Sing sing, Font font, string text)
        {
            int x, y, width, height;
            switch (sing)
            {
                case Sing.pointSing:
                    graph.DrawLine(pen, pointBegin, pointEnd);
                    //Program.form1.newMDIChild.pictureBox1.Image = Program.form1.newMDIChild.bmp;
                    break;
                case Sing.textSing:
                    SolidBrush brush = new SolidBrush(pen.Color);
                    graph.DrawString(text, font, brush, pointBegin);
                    //Program.form1.newMDIChild.pictureBox1.Image = Program.form1.newMDIChild.bmp;
                    break;
                case Sing.lineSing:
                    graph.DrawLine(pen, pointBegin, pointEnd);
                    //Program.form1.newMDIChild.pictureBox1.Image = Program.form1.newMDIChild.bmp;
                    break;
                case Sing.rectSing:
                    x = pointBegin.X;
                    y = pointBegin.Y;
                    width = pointEnd.X - pointBegin.X;
                    height = pointEnd.Y - pointBegin.Y;
                    graph.DrawRectangle(pen, x, y, width, height);
                    //Program.form1.newMDIChild.pictureBox1.Image = Program.form1.newMDIChild.bmp;
                    break;
                case Sing.ellipseSing:
                    x = pointBegin.X;
                    y = pointBegin.Y;
                    width = pointEnd.X - pointBegin.X;
                    height = pointEnd.Y - pointBegin.Y;
                    graph.DrawEllipse(pen, x, y, width, height);
                    //Program.form1.newMDIChild.pictureBox1.Image = Program.form1.newMDIChild.bmp;
                    break;
                case Sing.eraserSing:
                    graph.DrawLine(pen, pointBegin, pointEnd);
                    //Program.form1.newMDIChild.pictureBox1.Image = Program.form1.newMDIChild.bmp;
                    break;
            }
        }
    }
}
