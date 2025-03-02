using System.Security;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    partial class MDIForm : Form
    {
        /// <summary>
        /// Helper method for writing images to the disk for the MDI application.
        /// </summary>
        private void saveFileHelperMethod()
        {
            // Check if the child window is null before
            if (ActiveMdiChild == null)
                return;
            // Check if the Image object from the MDI child window is null before
            Image? i = ((MDIChildForm)ActiveMdiChild).PictureBoxImage;
            if (i == null)
                return;

            // Write the image to the disk
            SaveFileDialog s = new();
            s.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            s.Title = "Save your creation";
            s.FileName = ActiveMdiChild.Text;
            s.ShowDialog();

            if (s.FileName != "")
            {
                // Save image via FileStream created by OpenFile method
                System.IO.FileStream fs = (System.IO.FileStream)s.OpenFile();
                // Saves the image in the appropriate ImageFormat based upon  the File Type selected in the dialog
                // FileIndex property is one-based
                switch(s.FilterIndex)
                {
                    case 1:
                        i.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        i.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        i.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
                // Update name of the MDI child window
                ActiveMdiChild.Text = s.FileName;
                fs.Close();
            }
        }

        /// <summary>
        /// Helper method for loading images to the disk for the MDI application.
        /// </summary>
        private void openFileHelperMethod()
        {
            // Load image from the disk
            OpenFileDialog o = new();
            o.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            o.Title = "Open an epic image";
            
            // Try and load the image file from the disk
            if (o.ShowDialog() == DialogResult.OK && o.FileName != "")
            {
                Image i = new Bitmap(o.FileName);
                MDIChildForm child = new(i.Width, i.Height, image: i, title: o.FileName);
                child.MdiParent = this;
                child.Show();
            }
        }
    }
}