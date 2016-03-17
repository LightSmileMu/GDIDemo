using System;
using System.Drawing;
using System.Windows.Forms;
using GdiDemo.Properties;
using TX.Framework.WindowUI.Forms;

namespace GdiDemo.Image
{
    public partial class GdiImage : BaseForm
    {
        private string _fileName = string.Empty;

        private readonly Rectangle _contentRec = new Rectangle(85, 81, 330, 188);

        public GdiImage()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!string.IsNullOrEmpty(_fileName))
            {
                DrawImage(_fileName);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = Resources.PictureFilter;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _fileName = dlg.FileName;
                    DrawImage(_fileName);
                }
            }
        }

        private void DrawImage(string filePah)
        {
            using (System.Drawing.Image img = System.Drawing.Image.FromFile(filePah))
            {
                using (Graphics g = CreateGraphics())
                {
                    g.DrawImage(img.GetThumbnailImage(_contentRec.Width,
                        _contentRec.Height,
                        null, new IntPtr(0)),
                        _contentRec.Location);
                }
            }
        }
    }
}