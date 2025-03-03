namespace COMP3951_Lab5_WillOtterbein_dotnet.MDIMenus
{
    partial class OpenImageFromInternet
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
            imagePreviewPanel = new Panel();
            imagePreviewBox = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            buttonsPanel = new Panel();
            httpImageLoad = new Button();
            label1 = new Label();
            imageURL = new MaskedTextBox();
            imagePreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePreviewBox).BeginInit();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // imagePreviewPanel
            // 
            imagePreviewPanel.AutoScroll = true;
            imagePreviewPanel.Controls.Add(imagePreviewBox);
            imagePreviewPanel.Location = new Point(15, 159);
            imagePreviewPanel.Name = "imagePreviewPanel";
            imagePreviewPanel.Size = new Size(483, 401);
            imagePreviewPanel.TabIndex = 0;
            // 
            // imagePreviewBox
            // 
            imagePreviewBox.BackColor = SystemColors.ControlDark;
            imagePreviewBox.Dock = DockStyle.Fill;
            imagePreviewBox.Location = new Point(0, 0);
            imagePreviewBox.Name = "imagePreviewBox";
            imagePreviewBox.Size = new Size(483, 401);
            imagePreviewBox.TabIndex = 0;
            imagePreviewBox.TabStop = false;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(120, 584);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(257, 584);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(httpImageLoad);
            buttonsPanel.Controls.Add(label1);
            buttonsPanel.Controls.Add(imageURL);
            buttonsPanel.Location = new Point(12, 12);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(486, 141);
            buttonsPanel.TabIndex = 3;
            // 
            // httpImageLoad
            // 
            httpImageLoad.Location = new Point(177, 87);
            httpImageLoad.Name = "httpImageLoad";
            httpImageLoad.Size = new Size(131, 40);
            httpImageLoad.TabIndex = 2;
            httpImageLoad.Text = "Load";
            httpImageLoad.UseVisualStyleBackColor = true;
            httpImageLoad.Click += httpImageLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 1;
            label1.Text = "Image HTTP URL";
            // 
            // imageURL
            // 
            imageURL.Location = new Point(3, 36);
            imageURL.Name = "imageURL";
            imageURL.Size = new Size(480, 35);
            imageURL.TabIndex = 0;
            // 
            // OpenImageFromInternet
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 636);
            Controls.Add(buttonsPanel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(imagePreviewPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OpenImageFromInternet";
            Text = "OpenImageFromInternet";
            imagePreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagePreviewBox).EndInit();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel imagePreviewPanel;
        private PictureBox imagePreviewBox;
        private Button button1;
        private Button button2;
        private Panel buttonsPanel;
        private MaskedTextBox imageURL;
        private Label label1;
        private Button httpImageLoad;
    }
}