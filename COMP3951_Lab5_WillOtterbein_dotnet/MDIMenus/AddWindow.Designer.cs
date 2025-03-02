namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    partial class AddWindow
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
            widthEntry = new NumericUpDown();
            heightEntry = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            colorDialog1 = new ColorDialog();
            colorBox = new Panel();
            ((System.ComponentModel.ISupportInitialize)widthEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightEntry).BeginInit();
            SuspendLayout();
            // 
            // widthEntry
            // 
            widthEntry.Location = new Point(121, 36);
            widthEntry.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            widthEntry.Name = "widthEntry";
            widthEntry.Size = new Size(95, 23);
            widthEntry.TabIndex = 0;
            widthEntry.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // heightEntry
            // 
            heightEntry.Location = new Point(121, 65);
            heightEntry.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            heightEntry.Name = "heightEntry";
            heightEntry.Size = new Size(95, 23);
            heightEntry.TabIndex = 1;
            heightEntry.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Height";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(36, 131);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(117, 131);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(204, 15);
            label3.TabIndex = 6;
            label3.Text = "Configure The New Drawing Window";
            // 
            // button3
            // 
            button3.Location = new Point(154, 94);
            button3.Name = "button3";
            button3.Size = new Size(62, 23);
            button3.TabIndex = 7;
            button3.Text = "Select ...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 8;
            label4.Text = "Background Color";
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.White;
            colorDialog1.SolidColorOnly = true;
            // 
            // colorBox
            // 
            colorBox.BackColor = Color.White;
            colorBox.Location = new Point(121, 94);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(27, 23);
            colorBox.TabIndex = 9;
            // 
            // AddWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 166);
            Controls.Add(colorBox);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(heightEntry);
            Controls.Add(widthEntry);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddWindow";
            ((System.ComponentModel.ISupportInitialize)widthEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightEntry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown widthEntry;
        private NumericUpDown heightEntry;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label4;
        private ColorDialog colorDialog1;
        private Panel colorBox;
    }
}