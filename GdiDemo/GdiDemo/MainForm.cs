using System.Windows.Forms;
using GdiDemo.Brush;
using TX.Framework.WindowUI.Forms;

namespace GdiDemo
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BrushToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var brushFm = new BrushFrom())
            {
                brushFm.ShowDialog();
            }
        }
    }
}
