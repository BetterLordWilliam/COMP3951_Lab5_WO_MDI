using System.Data;
using System.Security;
using System.Drawing.Imaging;

///
/// Will Otterbein
/// March 2 2025
///
namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    /// <summary>
    /// Enum for file extensions
    /// </summary>
    enum ImageFile
    {
        JPEG = 1,
        BMP = 2,
        PNG = 3
    }

    partial class MDIForm : Form
    {
        private delegate void setMdiLayout();
        private delegate void fileSystemOperation();
        private readonly Dictionary<int, ImageFormat> fileExtensionOperationMap = new()
        {
            { ((int)ImageFile.JPEG), ImageFormat.Jpeg },
            { ((int)ImageFile.BMP), ImageFormat.Bmp },
            { ((int)ImageFile.PNG), ImageFormat.Png }
        };
        private readonly Dictionary<string, setMdiLayout> mdiLayoutMap;
        private readonly Dictionary<string, fileSystemOperation> fileSystemOpMap;

        public bool SaveFileToolStripStatus { get => saveFileToolStripMenuItem.Enabled; }

        /// <summary>
        /// Helper method for writing images to the disk for the MDI application.
        /// </summary>
        private void saveFileHelperMethod()
        {
            MDIChildForm? mdiChildForm = (MDIChildForm)ActiveMdiChild;
            Image? i = mdiChildForm?.PictureBoxImage;

            // Check if the child window is null / image is null before
            if (mdiChildForm == null || i == null)
                return;

            // Create save file dialog
            SaveFileDialog s = new()
            {
                Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png",
                Title = "Save your creation",
                FileName = mdiChildForm.Text.Split(Path.DirectorySeparatorChar)[^1]
            };

            // Handle case of filename being empty / not OK result
            if (s.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(s.FileName))
                return;

            // Save a file to the disk
            try
            {
                using FileStream fs = new(s.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                {
                    i.Save(fs, fileExtensionOperationMap[s.FilterIndex]);
                    mdiChildForm.Text = s.FileName;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show($"Error saving the file to the disk.\n\nDetails:\n\n{e.Message}\n\n");
            }
        }

        /// <summary>
        /// Helper method for loading images to the disk for the MDI application.
        /// </summary>
        private void openFileHelperMethod()
        {
            // Load image from the disk
            OpenFileDialog o = new()
            {
                Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png",
                Title = "Open an epic image"
            };

            // Handle case of filename being empty / not OK result
            if (o.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(o.FileName))
                return;

            // Open a file from the disk
            try
            {
                using FileStream fs = new(o.FileName, FileMode.Open, FileAccess.Read);
                {
                    Image i = Image.FromStream(fs);
                    MDIChildForm child = new(i.Width, i.Height, title: o.FileName, image: i)
                    {
                        MdiParent = this
                    };
                    child.Show();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find the specified file.");
            }
            catch (IOException e)
            {
                MessageBox.Show($"Could not open the specified file.\n\nDetails:\n\n{e.Message}\n\n");
            }
        }
    }
}