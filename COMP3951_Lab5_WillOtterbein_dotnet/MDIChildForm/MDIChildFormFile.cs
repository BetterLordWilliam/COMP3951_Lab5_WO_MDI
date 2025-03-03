using System.ComponentModel;
using System.Configuration;
using System.Drawing.Drawing2D;

///
/// Will Otterbein
/// March 2 2025
///
namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    partial class MDIChildForm : Form
    {
        readonly float DEFAULT_B1 = 5f;
        readonly float DEFAULT_B2 = 20f;
        readonly Color DEFAULT_C1 = Color.FromArgb(255, 0, 0, 0);
        readonly Color DEFAULT_C2 = Color.FromArgb(255, 255, 255, 255);

        bool Painting = false;
        int _bmwidth, _bmheight;
        float _b1thickness, _b2thickness;
        Point? PreviousPoint = null;
        Color _c1, _c2;
        Graphics g;

        private delegate Pen retrievePen();
        private Dictionary<MouseButtons, retrievePen> buttonToBrush;

        Pen DrawingPen { get; set; }
        public Image? PictureBoxImage { get => pictureBox1.Image; }

        // Brush 1 thickness
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float B1
        {
            get => _b1thickness;
            set
            {
                _b1thickness = value;
            }
        }

        // Brush 2 thickness
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float B2
        {
            get => _b2thickness;
            set
            {
                _b2thickness = value;
            }
        }

        // Pen 1 color
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color C1
        {
            get => _c1;
            set
            {
                // Updating the UI screen parts that reflect the current pen1 color
                _c1 = value;
                pen1Show.BackColor = value;
            }
        }

        // Pen 2 Color
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color C2
        {
            get => _c2;
            set
            {
                // Updating the UI screen parts that reflect the current pen2 color
                _c2 = value;
                pen2Show.BackColor = value;
            }
        }

        // Width of the bit map
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BmWidth
        {
            get => _bmwidth;
            set
            {
                // Updating the UI Screen parts which indicate the canvas size
                _bmwidth = value;
                widthView.Text = $"Width: {value}";
            }
        }

        // Height of the bit map
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BmHeight
        {
            get => _bmheight;
            set
            {
                // Updating the UI screen parts whcih indicate canvas size
                _bmheight = value;
                heightView.Text = $"Height: {value}";
            }
        }
    }
}