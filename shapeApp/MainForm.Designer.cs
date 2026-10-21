namespace ShapeApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            shapeMenu = new ToolStripMenuItem();
            rectangleMenuItem = new ToolStripMenuItem();
            curveMenuItem = new ToolStripMenuItem();
            polygonMenuItem = new ToolStripMenuItem();
            pieMenuItem = new ToolStripMenuItem();
            circleMenuItem = new ToolStripMenuItem();
            lineMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            clearMenuItem = new ToolStripMenuItem();
            canvasHost = new Panel();
            canvas = new PictureBox();
            menuStrip1.SuspendLayout();
            canvasHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { shapeMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(709, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // shapeMenu
            // 
            shapeMenu.DropDownItems.AddRange(new ToolStripItem[] { rectangleMenuItem, curveMenuItem, polygonMenuItem, pieMenuItem, circleMenuItem, lineMenuItem, toolStripSeparator1, clearMenuItem });
            shapeMenu.Name = "shapeMenu";
            shapeMenu.Size = new Size(56, 24);
            shapeMenu.Text = "Дүрс";
            // 
            // rectangleMenuItem
            // 
            rectangleMenuItem.Name = "rectangleMenuItem";
            rectangleMenuItem.Size = new Size(224, 26);
            rectangleMenuItem.Text = "Тэгш өнцөгт";
            rectangleMenuItem.Click += rectangleMenuItem_Click;
            // 
            // curveMenuItem
            // 
            curveMenuItem.Name = "curveMenuItem";
            curveMenuItem.Size = new Size(224, 26);
            curveMenuItem.Text = "Нум";
            curveMenuItem.Click += curveMenuItem_Click;
            // 
            // polygonMenuItem
            // 
            polygonMenuItem.Name = "polygonMenuItem";
            polygonMenuItem.Size = new Size(224, 26);
            polygonMenuItem.Text = "Олон талт дүрс";
            polygonMenuItem.Click += polygonMenuItem_Click;
            // 
            // pieMenuItem
            // 
            pieMenuItem.Name = "pieMenuItem";
            pieMenuItem.Size = new Size(224, 26);
            pieMenuItem.Text = "Дугуй график";
            pieMenuItem.Click += pieMenuItem_Click;
            // 
            // circleMenuItem
            // 
            circleMenuItem.Name = "circleMenuItem";
            circleMenuItem.Size = new Size(224, 26);
            circleMenuItem.Text = "Дугуй";
            circleMenuItem.Click += circleMenuItem_Click;
            // 
            // lineMenuItem
            // 
            lineMenuItem.Name = "lineMenuItem";
            lineMenuItem.Size = new Size(224, 26);
            lineMenuItem.Text = "Шулуун";
            lineMenuItem.Click += lineMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // clearMenuItem
            // 
            clearMenuItem.Name = "clearMenuItem";
            clearMenuItem.Size = new Size(224, 26);
            clearMenuItem.Text = "Цэвэрлэх";
            clearMenuItem.Click += clearMenuItem_Click;
            // 
            // canvasHost
            // 
            canvasHost.Controls.Add(canvas);
            canvasHost.Dock = DockStyle.Fill;
            canvasHost.Location = new Point(0, 30);
            canvasHost.Margin = new Padding(3, 4, 3, 4);
            canvasHost.Name = "canvasHost";
            canvasHost.Padding = new Padding(14, 16, 14, 16);
            canvasHost.Size = new Size(709, 557);
            canvasHost.TabIndex = 1;
            // 
            // canvas
            // 
            canvas.BackColor = Color.White;
            canvas.BorderStyle = BorderStyle.FixedSingle;
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(14, 16);
            canvas.Margin = new Padding(3, 4, 3, 4);
            canvas.Name = "canvas";
            canvas.Size = new Size(681, 525);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            canvas.Resize += canvas_Resize;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 587);
            Controls.Add(canvasHost);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(455, 411);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Дасгал№2. Энгийн дүрсүүд зурах";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            canvasHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapeMenu;
        private System.Windows.Forms.ToolStripMenuItem lineMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.Panel canvasHost;
        private System.Windows.Forms.PictureBox canvas;
        private ToolStripMenuItem rectangleMenuItem;
        private ToolStripMenuItem circleMenuItem;
        private ToolStripMenuItem pieMenuItem;
        private ToolStripMenuItem curveMenuItem;
        private ToolStripMenuItem polygonMenuItem;
    }
}
