using System.Drawing;
namespace GraphEditorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEraser = new System.Windows.Forms.ToolStripMenuItem();
            this.стильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Карандаш.jpg");
            this.imageList1.Images.SetKeyName(1, "Текст.jpg");
            this.imageList1.Images.SetKeyName(2, "Линия.jpg");
            this.imageList1.Images.SetKeyName(3, "Прямоугольник.jpg");
            this.imageList1.Images.SetKeyName(4, "Эллипс.jpg");
            this.imageList1.Images.SetKeyName(5, "Резинка.jpg");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPen,
            this.toolStripButtonText,
            this.toolStripButtonLine,
            this.toolStripButtonRect,
            this.toolStripButtonEllipse,
            this.toolStripButtonEraser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(348, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonPen
            // 
            this.toolStripButtonPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPen.Image = global::GraphEditorApp.Properties.Resources.Карандаш;
            this.toolStripButtonPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPen.Name = "toolStripButtonPen";
            this.toolStripButtonPen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPen.Text = "Карандаш";
            this.toolStripButtonPen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonText
            // 
            this.toolStripButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonText.Image = global::GraphEditorApp.Properties.Resources.Текст;
            this.toolStripButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonText.Name = "toolStripButtonText";
            this.toolStripButtonText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonText.Text = "Текст";
            this.toolStripButtonText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = global::GraphEditorApp.Properties.Resources.Линия;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLine.Text = "Линия";
            this.toolStripButtonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonRect
            // 
            this.toolStripButtonRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRect.Image = global::GraphEditorApp.Properties.Resources.Прямоугольник;
            this.toolStripButtonRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRect.Name = "toolStripButtonRect";
            this.toolStripButtonRect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRect.Text = "Прямоугольник";
            this.toolStripButtonRect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = global::GraphEditorApp.Properties.Resources.Эллипс;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEllipse.Text = "Эллипс";
            this.toolStripButtonEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonEraser
            // 
            this.toolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEraser.Image = global::GraphEditorApp.Properties.Resources.Резинка;
            this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEraser.Name = "toolStripButtonEraser";
            this.toolStripButtonEraser.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEraser.Text = "Резинка";
            this.toolStripButtonEraser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemTool,
            this.стильToolStripMenuItem,
            this.menuItemWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.menuItemWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(60, 20);
            this.menuItemFile.Text = "Рисунок";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(128, 22);
            this.menuItemNew.Text = "Создать";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemTool
            // 
            this.menuItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPen,
            this.menuItemText,
            this.menuItemLine,
            this.menuItemRect,
            this.menuItemEllipse,
            this.menuItemEraser});
            this.menuItemTool.Name = "menuItemTool";
            this.menuItemTool.Size = new System.Drawing.Size(79, 20);
            this.menuItemTool.Text = "Инструмент";
            // 
            // menuItemPen
            // 
            this.menuItemPen.Name = "menuItemPen";
            this.menuItemPen.Size = new System.Drawing.Size(163, 22);
            this.menuItemPen.Text = "Карандаш";
            this.menuItemPen.Click += new System.EventHandler(this.menuItemTool_Click);
            // 
            // menuItemText
            // 
            this.menuItemText.Name = "menuItemText";
            this.menuItemText.Size = new System.Drawing.Size(163, 22);
            this.menuItemText.Text = "Текст";
            this.menuItemText.Click += new System.EventHandler(this.menuItemTool_Click);
            // 
            // menuItemLine
            // 
            this.menuItemLine.Name = "menuItemLine";
            this.menuItemLine.Size = new System.Drawing.Size(163, 22);
            this.menuItemLine.Text = "Линия";
            this.menuItemLine.Click += new System.EventHandler(this.menuItemTool_Click);
            // 
            // menuItemRect
            // 
            this.menuItemRect.Name = "menuItemRect";
            this.menuItemRect.Size = new System.Drawing.Size(163, 22);
            this.menuItemRect.Text = "Прямоугольник";
            this.menuItemRect.Click += new System.EventHandler(this.menuItemTool_Click);
            // 
            // menuItemEllipse
            // 
            this.menuItemEllipse.Name = "menuItemEllipse";
            this.menuItemEllipse.Size = new System.Drawing.Size(163, 22);
            this.menuItemEllipse.Text = "Эллипс";
            this.menuItemEllipse.Click += new System.EventHandler(this.menuItemTool_Click);
            // 
            // menuItemEraser
            // 
            this.menuItemEraser.Name = "menuItemEraser";
            this.menuItemEraser.Size = new System.Drawing.Size(163, 22);
            this.menuItemEraser.Text = "Резинка";
            this.menuItemEraser.Click += new System.EventHandler(this.menuItemTool_Click);
            // 
            // стильToolStripMenuItem
            // 
            this.стильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.стильToolStripMenuItem.Name = "стильToolStripMenuItem";
            this.стильToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.стильToolStripMenuItem.Text = "Формат";
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.размерToolStripMenuItem.Text = "Толщина";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 21);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.Size = new System.Drawing.Size(45, 20);
            this.menuItemWindow.Text = "Окно";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 347);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPen;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonRect;
        private System.Windows.Forms.ToolStripButton toolStripButtonText;
        private System.Windows.Forms.ToolStripButton toolStripButtonEraser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemTool;
        private System.Windows.Forms.ToolStripMenuItem menuItemPen;
        private System.Windows.Forms.ToolStripMenuItem menuItemText;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemLine;
        private System.Windows.Forms.ToolStripMenuItem menuItemRect;
        private System.Windows.Forms.ToolStripMenuItem menuItemEllipse;
        private System.Windows.Forms.ToolStripMenuItem menuItemEraser;
        private System.Windows.Forms.ToolStripMenuItem стильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

