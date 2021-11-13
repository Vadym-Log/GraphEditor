using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphEditorApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();            
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler ApplyHandler;

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ApplyHandler != null && this.richTextBox1.Text != "")
                ApplyHandler.Invoke(this, new EventArgs());
            this.Close();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.form1.color = colorDialog1.Color;
                toolStripTextBox1.Text = ColorTranslator.ToHtml(Program.form1.color);
                Program.form1.toolStripTextBox1.Text = ColorTranslator.ToHtml(Program.form1.color);
                Form2 form = (Form2)this.Owner;
                form.Form2_ColorHandler(Program.form1.color);
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                ((Form2)(this.Owner)).font = fontDialog1.Font;
                toolStripTextBox2.Text = fontDialog1.Font.Name + ", " + fontDialog1.Font.SizeInPoints.ToString() + "pt, " + fontDialog1.Font.Style.ToString();
            }
        }
    }
}
