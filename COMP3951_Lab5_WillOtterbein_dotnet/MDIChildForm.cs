using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{

    public partial class MDIChildForm : Form
    {
        public MDIChildForm(int? width = null, int? height = null, Color? background = null, string? title = null, Image? image = null)
        {
            InitializeComponent();

            Text = title ?? "New image";
            BmWidth = width ?? pictureBox1.Width;
            BmHeight = height ?? pictureBox1.Height;

            // Define the default colors
            C1 = DEFAULT_C1;
            C2 = background ?? DEFAULT_C2;
            B1 = DEFAULT_B1;
            B2 = DEFAULT_B2;

            // Create a new image if the supplied is null
            // Default image it creates is a bitmap
            ImageBitmap = image ?? new Bitmap(BmWidth, BmHeight);
            pictureBox1.Image = ImageBitmap;
            pictureBox1.Size = ImageBitmap.Size;
            panel1.AutoScrollMinSize = ImageBitmap.Size;

            // Configure the graphics object
            // Draw background if new image
            g = Graphics.FromImage(ImageBitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            if (image == null) g.Clear(C2);

            // Define the default brushes
            DrawingPen = new(C1, B1) { EndCap = LineCap.Round };
        }

        /// <summary>
        /// Event handler for when the mouse down button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseDown(object sender, MouseEventArgs e)
        {
            // Determine which pen to use
            // Left click is pen 1
            // Right click is pen 2
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawingPen = new(C1, B1) { EndCap = LineCap.Round };
                    break;
                case MouseButtons.Right:
                    DrawingPen = new(C2, B2) { EndCap = LineCap.Round };
                    break;
            }

            Painting = true;
            PreviousPoint = e.Location;
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
            using (PenMenu pm = new (C1, B1))
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
            using (PenMenu pm = new(C2,B2))
            {
                if (pm.ShowDialog() == DialogResult.OK)
                {
                    C2 = pm.ColorInput;
                    B2 = pm.WidthInput;
                }
            }
        }

        /// <summary>
        /// Finalizer for the pane, dispose graphics resources used.
        /// </summary>
        ~MDIChildForm()
        {
            ImageBitmap.Dispose();
            g.Dispose();
        }
    }
}
