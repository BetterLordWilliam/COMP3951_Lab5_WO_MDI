namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    partial class PenMenu
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
            penColor = new Panel();
            label1 = new Label();
            label2 = new Label();
            selectPenColor = new Button();
            penThickness = new NumericUpDown();
            penMenuOk = new Button();
            penMenuCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)penThickness).BeginInit();
            SuspendLayout();
            // 
            // penColor
            // 
            penColor.BackColor = Color.White;
            penColor.Location = new Point(109, 12);
            penColor.Name = "penColor";
            penColor.Size = new Size(24, 23);
            penColor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Pen Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Pen Thickness";
            // 
            // selectPenColor
            // 
            selectPenColor.Location = new Point(139, 12);
            selectPenColor.Name = "selectPenColor";
            selectPenColor.Size = new Size(75, 23);
            selectPenColor.TabIndex = 3;
            selectPenColor.Text = "Select ...";
            selectPenColor.UseVisualStyleBackColor = true;
            selectPenColor.Click += selectPenColor_Click;
            // 
            // penThickness
            // 
            penThickness.Location = new Point(109, 38);
            penThickness.Name = "penThickness";
            penThickness.Size = new Size(105, 23);
            penThickness.TabIndex = 4;
            // 
            // penMenuOk
            // 
            penMenuOk.DialogResult = DialogResult.OK;
            penMenuOk.Location = new Point(37, 67);
            penMenuOk.Name = "penMenuOk";
            penMenuOk.Size = new Size(75, 23);
            penMenuOk.TabIndex = 5;
            penMenuOk.Text = "Confirm";
            penMenuOk.UseVisualStyleBackColor = true;
            // 
            // penMenuCancel
            // 
            penMenuCancel.DialogResult = DialogResult.Cancel;
            penMenuCancel.Location = new Point(118, 67);
            penMenuCancel.Name = "penMenuCancel";
            penMenuCancel.Size = new Size(75, 23);
            penMenuCancel.TabIndex = 6;
            penMenuCancel.Text = "Cancel";
            penMenuCancel.UseVisualStyleBackColor = true;
            // 
            // PenMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 95);
            Controls.Add(penMenuCancel);
            Controls.Add(penMenuOk);
            Controls.Add(penThickness);
            Controls.Add(selectPenColor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(penColor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PenMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PenMenu";
            ((System.ComponentModel.ISupportInitialize)penThickness).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel penColor;
        private Label label1;
        private Label label2;
        private Button selectPenColor;
        private NumericUpDown penThickness;
        private Button penMenuOk;
        private Button penMenuCancel;
    }
}