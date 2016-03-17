using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using TX.Framework.WindowUI.Forms;

namespace GdiDemo.Brush
{
    public partial class BrushFrom : BaseForm
    {
        readonly Rectangle _contentRec = new Rectangle(175, 113, 267, 159);
        Random _random = new Random();
        public BrushFrom()
        {
            InitializeComponent();
        }

        private void solidBrushToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (System.Drawing.Brush brush = new SolidBrush(Color.Aquamarine))
            {
                DrawContent(brush);
            }
        }

        private void hatchBrushToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (System.Drawing.Brush brush = new HatchBrush(HatchStyle.Cross,Color.Aquamarine))
            {
                DrawContent(brush);
            }
        }

        private void textureBrushToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (System.Drawing.Brush brush = new TextureBrush(Properties.Resources.TextureBrushImg,
                WrapMode.Tile))
            {
                DrawContent(brush);
            }
        }

        private void 线渐变画刷ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
            using (System.Drawing.Brush brush = new LinearGradientBrush(_contentRec,
               Color.Azure,
               Color.AntiqueWhite,
               (LinearGradientMode  )_random.Next((int)LinearGradientMode.Horizontal,
               (int)LinearGradientMode.BackwardDiagonal + 1)))
            {
                DrawContent(brush);
            }
        }

        private void 路径渐变画刷ToolStripMenuItem_Click(object sender, System.EventArgs e)
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
            using (var formGraphics = CreateGraphics())
            {
                formGraphics.FillRectangle(brush, _contentRec);
            }
        }
    }
}
