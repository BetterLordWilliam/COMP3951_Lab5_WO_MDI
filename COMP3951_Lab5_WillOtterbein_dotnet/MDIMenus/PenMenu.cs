using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    public partial class PenMenu : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float WidthInput
        {
            get => (float)this.penThickness.Value;
            set => this.penThickness.Value = (int)value;
        }

        Color _colin;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ColorInput { get => _colin; set { _colin = value; this.penColor.BackColor = value; } }

        public PenMenu(Color cinit, float binit)
        {
            InitializeComponent();
            WidthInput = binit;
            ColorInput = cinit;
        }

        /// <summary>
        /// Color Selection dialog for the pen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectPenColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    ColorInput = cd.Color;
                }
            }
        }
    }
}
