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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = windowsToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(180, 22);
            openFileToolStripMenuItem.Text = "OpenFile";
            openFileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Enabled = false;
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(180, 22);
            saveFileToolStripMenuItem.Text = "SaveFile";
            saveFileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, closeToolStripMenuItem, arrangeToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(116, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(116, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // arrangeToolStripMenuItem
            // 
            arrangeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, horitonzalTilesToolStripMenuItem, verticalTilesToolStripMenuItem });
            arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            arrangeToolStripMenuItem.Size = new Size(116, 22);
            arrangeToolStripMenuItem.Text = "Arrange";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(156, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // horitonzalTilesToolStripMenuItem
            // 
            horitonzalTilesToolStripMenuItem.Name = "horitonzalTilesToolStripMenuItem";
            horitonzalTilesToolStripMenuItem.Size = new Size(156, 22);
            horitonzalTilesToolStripMenuItem.Text = "Horitonzal Tiles";
            horitonzalTilesToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // verticalTilesToolStripMenuItem
            // 
            verticalTilesToolStripMenuItem.Name = "verticalTilesToolStripMenuItem";
            verticalTilesToolStripMenuItem.Size = new Size(156, 22);
            verticalTilesToolStripMenuItem.Text = "Vertical Tiles";
            verticalTilesToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // MDIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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
    }
}
