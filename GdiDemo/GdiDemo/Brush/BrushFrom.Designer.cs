namespace GdiDemo.Brush
{
    partial class BrushFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.画刷样式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线渐变画刷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.路径渐变画刷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.画刷样式ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 画刷样式ToolStripMenuItem
            // 
            this.画刷样式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBrushToolStripMenuItem,
            this.hatchBrushToolStripMenuItem,
            this.textureBrushToolStripMenuItem,
            this.线渐变画刷ToolStripMenuItem,
            this.路径渐变画刷ToolStripMenuItem});
            this.画刷样式ToolStripMenuItem.Name = "画刷样式ToolStripMenuItem";
            this.画刷样式ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.画刷样式ToolStripMenuItem.Text = "画刷样式";
            // 
            // solidBrushToolStripMenuItem
            // 
            this.solidBrushToolStripMenuItem.Name = "solidBrushToolStripMenuItem";
            this.solidBrushToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solidBrushToolStripMenuItem.Text = "一般的画刷";
            this.solidBrushToolStripMenuItem.Click += new System.EventHandler(this.solidBrushToolStripMenuItem_Click);
            // 
            // hatchBrushToolStripMenuItem
            // 
            this.hatchBrushToolStripMenuItem.Name = "hatchBrushToolStripMenuItem";
            this.hatchBrushToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hatchBrushToolStripMenuItem.Text = "阴影画刷";
            this.hatchBrushToolStripMenuItem.Click += new System.EventHandler(this.hatchBrushToolStripMenuItem_Click);
            // 
            // textureBrushToolStripMenuItem
            // 
            this.textureBrushToolStripMenuItem.Name = "textureBrushToolStripMenuItem";
            this.textureBrushToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textureBrushToolStripMenuItem.Text = "纹理画刷";
            this.textureBrushToolStripMenuItem.Click += new System.EventHandler(this.textureBrushToolStripMenuItem_Click);
            // 
            // 线渐变画刷ToolStripMenuItem
            // 
            this.线渐变画刷ToolStripMenuItem.Name = "线渐变画刷ToolStripMenuItem";
            this.线渐变画刷ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.线渐变画刷ToolStripMenuItem.Text = "线渐变画刷";
            this.线渐变画刷ToolStripMenuItem.Click += new System.EventHandler(this.线渐变画刷ToolStripMenuItem_Click);
            // 
            // 路径渐变画刷ToolStripMenuItem
            // 
            this.路径渐变画刷ToolStripMenuItem.Name = "路径渐变画刷ToolStripMenuItem";
            this.路径渐变画刷ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.路径渐变画刷ToolStripMenuItem.Text = "路径渐变画刷";
            this.路径渐变画刷ToolStripMenuItem.Click += new System.EventHandler(this.路径渐变画刷ToolStripMenuItem_Click);
            // 
            // BrushFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 384);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BrushFrom";
            this.Text = "Brush";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 画刷样式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textureBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线渐变画刷ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 路径渐变画刷ToolStripMenuItem;
    }
}