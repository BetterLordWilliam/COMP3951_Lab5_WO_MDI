using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///
/// Will Otterbein
/// March 3 2025
///
namespace COMP3951_Lab5_WillOtterbein_dotnet.MDIMenus
{
    /// <summary>
    /// Form for opening an image from the internet.
    /// </summary>
    public partial class OpenImageFromInternet : Form
    {
        public OpenImageFromInternet()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image? InternetImage { get; private set; }

        /// <summary>
        /// Load image from the internet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void httpImageLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imageURL.Text))
            {
                MessageBox.Show("Please enter a valid URL");
                return;
            }

            try
            {
                // Fetch the image from the internet w/ the supplied URL
                using HttpClient wc = new();
                byte[] bytes = await wc.GetByteArrayAsync(imageURL.Text);
                // Create memory strem from the downloaded bytes
                using MemoryStream ms = new (bytes);
                // Turn the stream into an image, update UI accordingly
                InternetImage = Image.FromStream(ms);
                imagePreviewBox.Image = InternetImage;
                imagePreviewPanel.AutoScrollMinSize = InternetImage.Size;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("There was an exception fetching the specified resource.\n\nPlease validate the URL.\n\n");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The web resource specified is not an image.\n\nPlease validate the URL.\n\n");
            }
        }
    }
}
