namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.collapse = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.TeaClicker = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IntervalSeconds = new System.Windows.Forms.Label();
            this.TotalClicks = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.f1 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.Label();
            this.PositionY = new System.Windows.Forms.TextBox();
            this.PositionX = new System.Windows.Forms.TextBox();
            this.labelPositionY = new System.Windows.Forms.Label();
            this.labelPositionX = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Controls.Add(this.collapse);
            this.TopPanel.Controls.Add(this.close);
            this.TopPanel.Controls.Add(this.TeaClicker);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(480, 38);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // collapse
            // 
            this.collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapse.ErrorImage = ((System.Drawing.Image)(resources.GetObject("collapse.ErrorImage")));
            this.collapse.Image = ((System.Drawing.Image)(resources.GetObject("collapse.Image")));
            this.collapse.InitialImage = ((System.Drawing.Image)(resources.GetObject("collapse.InitialImage")));
            this.collapse.Location = new System.Drawing.Point(413, 9);
            this.collapse.Name = "collapse";
            this.collapse.Size = new System.Drawing.Size(24, 24);
            this.collapse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collapse.TabIndex = 1;
            this.collapse.TabStop = false;
            this.collapse.Click += new System.EventHandler(this.collapse_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("close.ErrorImage")));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.InitialImage = ((System.Drawing.Image)(resources.GetObject("close.InitialImage")));
            this.close.Location = new System.Drawing.Point(443, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TeaClicker
            // 
            this.TeaClicker.AutoSize = true;
            this.TeaClicker.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeaClicker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeaClicker.Location = new System.Drawing.Point(4, 6);
            this.TeaClicker.Name = "TeaClicker";
            this.TeaClicker.Size = new System.Drawing.Size(148, 27);
            this.TeaClicker.TabIndex = 1;
            this.TeaClicker.Text = "TeaClicker";
            this.TeaClicker.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox1.Font = new System.Drawing.Font("DFPOP1-W9", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(13, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 42);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox2.Font = new System.Drawing.Font("DFPOP1-W9", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(13, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 42);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // IntervalSeconds
            // 
            this.IntervalSeconds.AutoSize = true;
            this.IntervalSeconds.BackColor = System.Drawing.Color.Transparent;
            this.IntervalSeconds.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalSeconds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IntervalSeconds.Location = new System.Drawing.Point(179, 19);
            this.IntervalSeconds.Name = "IntervalSeconds";
            this.IntervalSeconds.Size = new System.Drawing.Size(240, 31);
            this.IntervalSeconds.TabIndex = 2;
            this.IntervalSeconds.Text = "Interval seconds";
            this.IntervalSeconds.Click += new System.EventHandler(this.IntervalSeconds_Click);
            // 
            // TotalClicks
            // 
            this.TotalClicks.AutoSize = true;
            this.TotalClicks.BackColor = System.Drawing.Color.Transparent;
            this.TotalClicks.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalClicks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalClicks.Location = new System.Drawing.Point(179, 77);
            this.TotalClicks.Name = "TotalClicks";
            this.TotalClicks.Size = new System.Drawing.Size(175, 31);
            this.TotalClicks.TabIndex = 3;
            this.TotalClicks.Text = "Total clicks";
            this.TotalClicks.Click += new System.EventHandler(this.TotalClicks_Click);
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Start.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(317, 210);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(145, 36);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Stop.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Stop.Location = new System.Drawing.Point(197, 210);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(105, 36);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.BackColor = System.Drawing.Color.Transparent;
            this.f1.Font = new System.Drawing.Font("DFPOP1-W9", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.f1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.f1.Location = new System.Drawing.Point(222, 186);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(54, 21);
            this.f1.TabIndex = 6;
            this.f1.Text = "(F1)";
            this.f1.Click += new System.EventHandler(this.f1_Click);
            // 
            // f2
            // 
            this.f2.AutoSize = true;
            this.f2.BackColor = System.Drawing.Color.Transparent;
            this.f2.Font = new System.Drawing.Font("DFPOP1-W9", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.f2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.f2.Location = new System.Drawing.Point(361, 186);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(54, 21);
            this.f2.TabIndex = 7;
            this.f2.Text = "(F2)";
            this.f2.Click += new System.EventHandler(this.f2_Click);
            // 
            // PositionY
            // 
            this.PositionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PositionY.Font = new System.Drawing.Font("DFGothic-EB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PositionY.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.PositionY.Location = new System.Drawing.Point(112, 185);
            this.PositionY.Name = "PositionY";
            this.PositionY.ReadOnly = true;
            this.PositionY.Size = new System.Drawing.Size(66, 26);
            this.PositionY.TabIndex = 8;
            this.PositionY.Text = "Y";
            this.PositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PositionY.TextChanged += new System.EventHandler(this.PositionY_TextChanged);
            // 
            // PositionX
            // 
            this.PositionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PositionX.Font = new System.Drawing.Font("DFGothic-EB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PositionX.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.PositionX.Location = new System.Drawing.Point(112, 222);
            this.PositionX.Name = "PositionX";
            this.PositionX.ReadOnly = true;
            this.PositionX.Size = new System.Drawing.Size(66, 26);
            this.PositionX.TabIndex = 9;
            this.PositionX.Text = "X";
            this.PositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PositionX.TextChanged += new System.EventHandler(this.PositionX_TextChanged);
            // 
            // labelPositionY
            // 
            this.labelPositionY.AutoSize = true;
            this.labelPositionY.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositionY.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPositionY.Location = new System.Drawing.Point(12, 189);
            this.labelPositionY.Name = "labelPositionY";
            this.labelPositionY.Size = new System.Drawing.Size(94, 19);
            this.labelPositionY.TabIndex = 10;
            this.labelPositionY.Text = "Position Y";
            // 
            // labelPositionX
            // 
            this.labelPositionX.AutoSize = true;
            this.labelPositionX.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositionX.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPositionX.Location = new System.Drawing.Point(12, 227);
            this.labelPositionX.Name = "labelPositionX";
            this.labelPositionX.Size = new System.Drawing.Size(95, 19);
            this.labelPositionX.TabIndex = 11;
            this.labelPositionX.Text = "Position X";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.textBox3);
            this.MainPanel.Controls.Add(this.labelPositionX);
            this.MainPanel.Controls.Add(this.labelPositionY);
            this.MainPanel.Controls.Add(this.PositionX);
            this.MainPanel.Controls.Add(this.PositionY);
            this.MainPanel.Controls.Add(this.f2);
            this.MainPanel.Controls.Add(this.f1);
            this.MainPanel.Controls.Add(this.Stop);
            this.MainPanel.Controls.Add(this.Start);
            this.MainPanel.Controls.Add(this.TotalClicks);
            this.MainPanel.Controls.Add(this.IntervalSeconds);
            this.MainPanel.Controls.Add(this.textBox2);
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 38);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(480, 262);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 94);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox3.Font = new System.Drawing.Font("DFPOP1-W9", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(13, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(160, 42);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(179, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clicks remaining";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(149, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TeaClicker;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox collapse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label IntervalSeconds;
        private System.Windows.Forms.Label TotalClicks;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label f2;
        private System.Windows.Forms.TextBox PositionY;
        private System.Windows.Forms.TextBox PositionX;
        private System.Windows.Forms.Label labelPositionY;
        private System.Windows.Forms.Label labelPositionX;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

