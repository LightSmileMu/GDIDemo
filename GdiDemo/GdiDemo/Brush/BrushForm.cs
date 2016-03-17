using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using GdiDemo.Properties;
using TX.Framework.WindowUI.Forms;

namespace GdiDemo.Brush
{
    public partial class BrushForm : BaseForm
    {
        private readonly Rectangle _contentRec = new Rectangle(175, 113, 267, 159);
        private readonly Random _random = new Random();

        public BrushForm()
        {
            InitializeComponent();
        }

        private void solidBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.Drawing.Brush brush = new SolidBrush(Color.Aquamarine))
            {
                DrawContent(brush);
            }
        }

        private void hatchBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.Drawing.Brush brush = new HatchBrush(HatchStyle.Cross, Color.Aquamarine))
            {
                DrawContent(brush);
            }
        }

        private void textureBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.Drawing.Brush brush = new TextureBrush(Resources.TextureBrushImg,
                WrapMode.Tile))
            {
                DrawContent(brush);
            }
        }

        private void 线渐变画刷ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.Drawing.Brush brush = new LinearGradientBrush(_contentRec,
                Color.Azure,
                Color.AntiqueWhite,
                (LinearGradientMode) _random.Next((int) LinearGradientMode.Horizontal,
                    (int) LinearGradientMode.BackwardDiagonal + 1)))
            {
                DrawContent(brush);
            }
        }

        private void 路径渐变画刷ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var path = new GraphicsPath())
            {
                path.AddRectangle(_contentRec);
                using (System.Drawing.Brush brush = new PathGradientBrush(path))
                {
                    DrawContent(brush);
                }
            }
        }

        private void DrawContent(System.Drawing.Brush brush)
        {
            using (Graphics formGraphics = CreateGraphics())
            {
                formGraphics.FillRectangle(brush, _contentRec);
            }
        }
    }
}