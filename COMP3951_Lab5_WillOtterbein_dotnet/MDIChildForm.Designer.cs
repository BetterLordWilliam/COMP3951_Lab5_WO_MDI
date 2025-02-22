
namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    partial class MDIChildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIChildForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            heightView = new ToolStripLabel();
            widthView = new ToolStripLabel();
            pen1Selection = new ToolStripButton();
            pen1Show = new ToolStripButton();
            pen2Selection = new ToolStripButton();
            pen2Show = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += ImageMouseDown;
            pictureBox1.MouseMove += ImageMouseMove;
            pictureBox1.MouseUp += ImageMouseUp;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.Items.AddRange(new ToolStripItem[] { heightView, toolStripSeparator1, widthView, pen1Selection, pen1Show, toolStripSeparator2, pen2Selection, pen2Show });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // heightView
            // 
            heightView.Alignment = ToolStripItemAlignment.Right;
            heightView.Name = "heightView";
            heightView.Size = new Size(86, 22);
            heightView.Text = "toolStripLabel2";
            // 
            // widthView
            // 
            widthView.Alignment = ToolStripItemAlignment.Right;
            widthView.Name = "widthView";
            widthView.Size = new Size(86, 22);
            widthView.Text = "toolStripLabel1";
            // 
            // pen1Selection
            // 
            pen1Selection.AutoSize = false;
            pen1Selection.BackColor = SystemColors.Control;
            pen1Selection.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pen1Selection.Image = (Image)resources.GetObject("pen1Selection.Image");
            pen1Selection.ImageTransparentColor = Color.Magenta;
            pen1Selection.Name = "pen1Selection";
            pen1Selection.Size = new Size(22, 22);
            pen1Selection.Text = "Pen 1";
            pen1Selection.Click += pen1Selection_Click;
            // 
            // pen1Show
            // 
            pen1Show.DisplayStyle = ToolStripItemDisplayStyle.None;
            pen1Show.Enabled = false;
            pen1Show.Image = (Image)resources.GetObject("pen1Show.Image");
            pen1Show.ImageTransparentColor = Color.Magenta;
            pen1Show.Name = "pen1Show";
            pen1Show.Size = new Size(23, 22);
            pen1Show.Text = "toolStripButton1";
            // 
            // pen2Selection
            // 
            pen2Selection.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pen2Selection.Image = (Image)resources.GetObject("pen2Selection.Image");
            pen2Selection.ImageTransparentColor = Color.Magenta;
            pen2Selection.Name = "pen2Selection";
            pen2Selection.Size = new Size(23, 22);
            pen2Selection.Text = "Pen 2";
            pen2Selection.Click += pen2Selection_Click;
            // 
            // pen2Show
            // 
            pen2Show.DisplayStyle = ToolStripItemDisplayStyle.None;
            pen2Show.Enabled = false;
            pen2Show.Image = (Image)resources.GetObject("pen2Show.Image");
            pen2Show.ImageTransparentColor = Color.Magenta;
            pen2Show.Name = "pen2Show";
            pen2Show.Size = new Size(23, 22);
            pen2Show.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // MDIChildForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MDIChildForm";
            RightToLeft = RightToLeft.No;
            Text = "Will MDI Child Form";
            Paint += MDIChildForm_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripLabel widthView;
        private ToolStripLabel heightView;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton pen1Selection;
        private ToolStripButton pen2Selection;
        private ToolStripButton pen1Show;
        private ToolStripButton pen2Show;
        private ToolStripSeparator toolStripSeparator1;
    }
}