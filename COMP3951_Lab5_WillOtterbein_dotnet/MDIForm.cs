using System.Linq.Expressions;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handle creating new windows (will be moved into different handler).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the add window dialog
            AddWindow aw = new AddWindow();
            if (aw.ShowDialog() == DialogResult.OK)
            {
                MDIChildForm child = new (aw.WidthInput, aw.HeightInput, aw.ColorInput);
                child.MdiParent = this;
                child.Show();
            }
        }

        /// <summary>
        /// Handle destroying the active window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Return if there is not active window
            if (this.ActiveMdiChild == null)
                return;

            // Show the dialog
            ConfirmClose cc = new ConfirmClose();
            if (cc.ShowDialog() == DialogResult.OK)
            {
                this.ActiveMdiChild?.Dispose();
            }
        }

        /// <summary>
        /// Handle selection of a menu arrangement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "cascadeToolStripMenuItem":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    return;
                case "horitonzalTilesToolStripMenuItem":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    return;
                case "verticalTilesToolStripMenuItem":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
                    return;
                case "arrangeIconsToolStripMenuItem":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
                    return;
            }

        }

        private void changeWindowColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
