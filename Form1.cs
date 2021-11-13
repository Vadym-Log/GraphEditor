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
    public enum Tools
    { 
        PEN,
        TEXT,
        LINE,
        RECTANGLE,
        ELLIPSE,
        ERASER,
        NONE
    }

    public partial class Form1 : Form
    {            
        public Form1()
        {
            InitializeComponent();
            toolStrip1.ImageList = imageList1;
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                toolStrip1.Items[i].ImageIndex = i;
                menuItemTool.DropDownItems[i].ImageIndex = i;
            }
            ((ToolStripButton)toolStrip1.Items[0]).CheckState = CheckState.Checked;
            this.toolStripTextBox1.Text = ColorTranslator.ToHtml(Color.Black);
            this.toolStripComboBox1.Text = "3";
        }

        public Tools currentTool;

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ImageIndex)            
            {
                case 0:
                    currentTool = Tools.PEN;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case 1:
                    currentTool = Tools.TEXT;
                    размерToolStripMenuItem.Enabled = false;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case 2:
                    currentTool = Tools.LINE;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    currentTool = Tools.RECTANGLE;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case 4:
                    currentTool = Tools.ELLIPSE;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case 5:
                    currentTool = Tools.ERASER;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = false;
                    break;
                default:
                    currentTool = Tools.NONE;
                    break;
            }
            SetToolStripButtonsPushedState((ToolStripButton)e.ClickedItem);
            SetMenuItemsCheckedState((ToolStripMenuItem)menuItemTool.DropDownItems[e.ClickedItem.ImageIndex]);
        }
        private void SetToolStripButtonsPushedState(ToolStripButton button)
        {
            foreach (ToolStripButton btnItem in toolStrip1.Items)
            {
                if (btnItem == button)
                    btnItem.CheckState = CheckState.Checked;
                else
                    btnItem.CheckState = CheckState.Unchecked;
            }
        }

        private void menuItemTool_Click(object sender, EventArgs e)
        {            
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Text)
            { 
                case "Карандаш":
                    currentTool = Tools.PEN;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case "Текст":
                    currentTool = Tools.TEXT;
                    размерToolStripMenuItem.Enabled = false;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case "Линия":
                    currentTool = Tools.LINE;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case "Прямоугольник":
                    currentTool = Tools.RECTANGLE;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case "Эллипс":
                    currentTool = Tools.ELLIPSE;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = true;
                    break;
                case "Резинка":
                    currentTool = Tools.ERASER;
                    размерToolStripMenuItem.Enabled = true;
                    цветToolStripMenuItem.Enabled = false;
                    break;
                default:
                    currentTool = Tools.NONE;
                    break;
            }
            SetMenuItemsCheckedState(item);
            SetToolStripButtonsPushedState((ToolStripButton)toolStrip1.Items[item.ImageIndex]);
        }

        private void SetMenuItemsCheckedState(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem menuItem in menuItemTool.DropDownItems)
            {
                if (menuItem == item)
                    menuItem.Checked = true;
                else
                    menuItem.Checked = false;
            }
        }
        public Form2 newMDIChild;
        private void menuItemNew_Click(object sender, EventArgs e)
        {
            newMDIChild = newMDIChild = new Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Окно " + this.MdiChildren.Length.ToString();
            newMDIChild.Show();
        }

        public Color color = Color.Black;
        public delegate void HandlerColor(Color color);
        public event HandlerColor ColorHandler;
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && this.MdiChildren.Length != 0)
            {
                color = colorDialog1.Color;
                toolStripTextBox1.Text = ColorTranslator.ToHtml(color);                
                ColorHandler.Invoke(color);
            }
        }

        public int Weight;
        public delegate void HandlerWeight(int Weight);
        public event HandlerWeight WeightHandler;
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length != 0)
            {
                Weight = Convert.ToInt32(this.toolStripComboBox1.Text);
                WeightHandler.Invoke(Weight);
            }
        }        
    }
}
