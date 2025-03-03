namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    partial class MDIForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            openInternetToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            arrangeToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            horitonzalTilesToolStripMenuItem = new ToolStripMenuItem();
            verticalTilesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = windowsToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(2030, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, openInternetToolStripMenuItem, saveFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(62, 34);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(315, 40);
            openFileToolStripMenuItem.Text = "OpenFile";
            openFileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openInternetToolStripMenuItem
            // 
            openInternetToolStripMenuItem.Name = "openInternetToolStripMenuItem";
            openInternetToolStripMenuItem.Size = new Size(315, 40);
            openInternetToolStripMenuItem.Text = "OpenFromInternet";
            openInternetToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Enabled = false;
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(315, 40);
            saveFileToolStripMenuItem.Text = "SaveFile";
            saveFileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, closeToolStripMenuItem, arrangeToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(116, 34);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(205, 40);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(205, 40);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // arrangeToolStripMenuItem
            // 
            arrangeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, horitonzalTilesToolStripMenuItem, verticalTilesToolStripMenuItem });
            arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            arrangeToolStripMenuItem.Size = new Size(205, 40);
            arrangeToolStripMenuItem.Text = "Arrange";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(274, 40);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // horitonzalTilesToolStripMenuItem
            // 
            horitonzalTilesToolStripMenuItem.Name = "horitonzalTilesToolStripMenuItem";
            horitonzalTilesToolStripMenuItem.Size = new Size(274, 40);
            horitonzalTilesToolStripMenuItem.Text = "Horitonzal Tiles";
            horitonzalTilesToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // verticalTilesToolStripMenuItem
            // 
            verticalTilesToolStripMenuItem.Name = "verticalTilesToolStripMenuItem";
            verticalTilesToolStripMenuItem.Size = new Size(274, 40);
            verticalTilesToolStripMenuItem.Text = "Vertical Tiles";
            verticalTilesToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // MDIForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2030, 1522);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MDIForm";
            Text = "Will MDI Application";
            MdiChildActivate += MDIForm_MdiChildActivate;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem arrangeToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horitonzalTilesToolStripMenuItem;
        private ToolStripMenuItem verticalTilesToolStripMenuItem;
        private ToolStripMenuItem openInternetToolStripMenuItem;
    }
}
