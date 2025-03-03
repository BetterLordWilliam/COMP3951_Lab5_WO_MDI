using System.ComponentModel;
using System.Drawing.Drawing2D;

///
/// Will Otterbein
/// March 2 2025
///
namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    public partial class MDIChildForm : Form
    {
        /// <summary>
        /// Constructor for the MDIChildForm class, build drawable surface for the supplied image document, or create new bitmap.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="background"></param>
        /// <param name="title"></param>
        /// <param name="imageFile"></param>
        public MDIChildForm(int? width = null, int? height = null, Color? background = null, string? title = null, Image? image = null)
        {
            InitializeComponent();

            // Define the default stuff
            C1 = DEFAULT_C1;
            C2 = background ?? DEFAULT_C2;
            B1 = DEFAULT_B1;
            B2 = DEFAULT_B2;
            DrawingPen = new(C1, B1) { EndCap = LineCap.Round };

            buttonToBrush = new()
            {
                { MouseButtons.Left, () => new(C1, B1) { EndCap = LineCap.Round } },
                { MouseButtons.Right, () => new(C2, B2) { EndCap = LineCap.Round } }
            };

            // Configure window properties
            Text = title ?? "New image";
            BmWidth = width ?? pictureBox1.Width;
            BmHeight = height ?? pictureBox1.Height;

            // Load image / create new empty bitmap image
            pictureBox1.Image = image ?? new Bitmap(BmWidth, BmHeight);
            pictureBox1.Size = pictureBox1.Image.Size;
            panel1.AutoScrollMinSize = pictureBox1.Image.Size;

            // Setup graphics resource
            g = Graphics.FromImage(pictureBox1.Image);
            g.SmoothingMode = SmoothingMode.HighQuality;
            if (image == null) g.Clear(C2);
        }

        /// <summary>
        /// Event handler for when the mouse down button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DrawingPen = buttonToBrush[e.Button]();
                Painting = true;
                PreviousPoint = e.Location;
            }
            catch (Exception ex) when (ex is ArgumentNullException || ex is KeyNotFoundException)
            {
                MessageBox.Show("Invalid input button");
            }
        }

        /// <summary>
        /// Event handler for when the mouse is released (stop painting).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseUp(object sender, MouseEventArgs e)
        {
            Painting = false;
            PreviousPoint = null;
        }

        /// <summary>
        /// Event handler for when the mouse moves.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseMove(object sender, MouseEventArgs e)
        {
            // Must be in the Painting stage
            if (!Painting)
                return;

            if (PreviousPoint != null)
            {
                // Draw lines to the bitmap
                g.DrawLine(DrawingPen, PreviousPoint.Value.X, PreviousPoint.Value.Y, e.X, e.Y);
            }

            // Invalidate the picture box -- make it redraw
            PreviousPoint = e.Location;
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// Pen 1 selection menu, configure color and thickness.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pen1Selection_Click(object sender, EventArgs e)
        {
            using PenMenu pm = new(C1, B1);
            {
                if (pm.ShowDialog() == DialogResult.OK)
                {
                    C1 = pm.ColorInput;
                    B1 = pm.WidthInput;
                }
            }
        }

        /// <summary>
        /// Pen 2 selection menu, configure color and thickness.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pen2Selection_Click(object sender, EventArgs e)
        {
            using PenMenu pm = new(C2, B2);
            {
                if (pm.ShowDialog() == DialogResult.OK)
                {
                    C2 = pm.ColorInput;
                    B2 = pm.WidthInput;
                }
            }
        }

        /// <summary>
        /// On form close event, dispose of the resources used by the form.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            pictureBox1?.Image?.Dispose();            
            g.Dispose();
        }
    }
}
