namespace Paint
{
    partial class PaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.panel = new System.Windows.Forms.Panel();
            this.ClearB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.FillB = new System.Windows.Forms.Button();
            this.RectangleB = new System.Windows.Forms.Button();
            this.ColorB = new System.Windows.Forms.Button();
            this.PencilB = new System.Windows.Forms.Button();
            this.EllipseB = new System.Windows.Forms.Button();
            this.LineB = new System.Windows.Forms.Button();
            this.EraserB = new System.Windows.Forms.Button();
            this.PaintBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel.Controls.Add(this.ClearB);
            this.panel.Controls.Add(this.SaveB);
            this.panel.Controls.Add(this.FillB);
            this.panel.Controls.Add(this.RectangleB);
            this.panel.Controls.Add(this.ColorB);
            this.panel.Controls.Add(this.PencilB);
            this.panel.Controls.Add(this.EllipseB);
            this.panel.Controls.Add(this.LineB);
            this.panel.Controls.Add(this.EraserB);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(803, 83);
            this.panel.TabIndex = 7;
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(598, 49);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(75, 23);
            this.ClearB.TabIndex = 9;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(598, 12);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 8;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // FillB
            // 
            this.FillB.BackgroundImage = global::Paint.Properties.Resources.paint_bucket;
            this.FillB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FillB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillB.ForeColor = System.Drawing.Color.White;
            this.FillB.Location = new System.Drawing.Point(202, 12);
            this.FillB.Name = "FillB";
            this.FillB.Size = new System.Drawing.Size(60, 60);
            this.FillB.TabIndex = 1;
            this.FillB.UseVisualStyleBackColor = true;
            this.FillB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FillB_MouseClick);
            // 
            // RectangleB
            // 
            this.RectangleB.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.RectangleB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleB.ForeColor = System.Drawing.Color.White;
            this.RectangleB.Location = new System.Drawing.Point(532, 12);
            this.RectangleB.Name = "RectangleB";
            this.RectangleB.Size = new System.Drawing.Size(60, 60);
            this.RectangleB.TabIndex = 6;
            this.RectangleB.UseVisualStyleBackColor = true;
            this.RectangleB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RectangleB_MouseClick);
            // 
            // ColorB
            // 
            this.ColorB.BackgroundImage = global::Paint.Properties.Resources.color_wheel;
            this.ColorB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorB.ForeColor = System.Drawing.Color.White;
            this.ColorB.Location = new System.Drawing.Point(136, 12);
            this.ColorB.Name = "ColorB";
            this.ColorB.Size = new System.Drawing.Size(60, 60);
            this.ColorB.TabIndex = 0;
            this.ColorB.UseVisualStyleBackColor = true;
            this.ColorB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColorB_MouseClick);
            // 
            // PencilB
            // 
            this.PencilB.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.PencilB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PencilB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PencilB.ForeColor = System.Drawing.Color.White;
            this.PencilB.Location = new System.Drawing.Point(268, 12);
            this.PencilB.Name = "PencilB";
            this.PencilB.Size = new System.Drawing.Size(60, 60);
            this.PencilB.TabIndex = 5;
            this.PencilB.UseVisualStyleBackColor = true;
            this.PencilB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PencilB_MouseClick);
            // 
            // EllipseB
            // 
            this.EllipseB.BackgroundImage = global::Paint.Properties.Resources.ellipse;
            this.EllipseB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EllipseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipseB.ForeColor = System.Drawing.Color.White;
            this.EllipseB.Location = new System.Drawing.Point(466, 12);
            this.EllipseB.Name = "EllipseB";
            this.EllipseB.Size = new System.Drawing.Size(60, 60);
            this.EllipseB.TabIndex = 2;
            this.EllipseB.UseVisualStyleBackColor = true;
            this.EllipseB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EllipseB_MouseClick);
            // 
            // LineB
            // 
            this.LineB.BackgroundImage = global::Paint.Properties.Resources.diagonal_line;
            this.LineB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineB.ForeColor = System.Drawing.Color.White;
            this.LineB.Location = new System.Drawing.Point(400, 12);
            this.LineB.Name = "LineB";
            this.LineB.Size = new System.Drawing.Size(60, 60);
            this.LineB.TabIndex = 4;
            this.LineB.UseVisualStyleBackColor = true;
            this.LineB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LineB_MouseClick);
            // 
            // EraserB
            // 
            this.EraserB.BackgroundImage = global::Paint.Properties.Resources.eraser;
            this.EraserB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EraserB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraserB.ForeColor = System.Drawing.Color.White;
            this.EraserB.Location = new System.Drawing.Point(334, 12);
            this.EraserB.Name = "EraserB";
            this.EraserB.Size = new System.Drawing.Size(60, 60);
            this.EraserB.TabIndex = 3;
            this.EraserB.UseVisualStyleBackColor = true;
            this.EraserB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EraserB_MouseClick);
            // 
            // PaintBox
            // 
            this.PaintBox.Location = new System.Drawing.Point(0, 78);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(800, 453);
            this.PaintBox.TabIndex = 8;
            this.PaintBox.TabStop = false;
            this.PaintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBox_Paint);
            this.PaintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseClick);
            this.PaintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.PaintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.PaintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.PaintBox);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ColorB;
        private System.Windows.Forms.Button FillB;
        private System.Windows.Forms.Button EllipseB;
        private System.Windows.Forms.Button EraserB;
        private System.Windows.Forms.Button LineB;
        private System.Windows.Forms.Button PencilB;
        private System.Windows.Forms.Button RectangleB;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.PictureBox PaintBox;
    }
}

