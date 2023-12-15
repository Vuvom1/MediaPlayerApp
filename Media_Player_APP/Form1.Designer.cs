namespace Media_Player_APP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSpeedMunu = new System.Windows.Forms.Panel();
            this.btn15 = new System.Windows.Forms.Button();
            this.btnNM = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panelToolSubMenu = new System.Windows.Forms.Panel();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediasubmenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panel1Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ptb_imagemusic = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSpeedMunu.SuspendLayout();
            this.panelToolSubMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelMediasubmenu.SuspendLayout();
            this.panel1Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagemusic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.panelSpeedMunu);
            this.panelMenu.Controls.Add(this.button11);
            this.panelMenu.Controls.Add(this.button10);
            this.panelMenu.Controls.Add(this.panelToolSubMenu);
            this.panelMenu.Controls.Add(this.btnTool);
            this.panelMenu.Controls.Add(this.panelPlaylistSubMenu);
            this.panelMenu.Controls.Add(this.btnPlaylist);
            this.panelMenu.Controls.Add(this.panelMediasubmenu);
            this.panelMenu.Controls.Add(this.btnMedia);
            this.panelMenu.Controls.Add(this.panel1Logo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSpeedMunu
            // 
            this.panelSpeedMunu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSpeedMunu.Controls.Add(this.btn15);
            this.panelSpeedMunu.Controls.Add(this.btnNM);
            this.panelSpeedMunu.Controls.Add(this.btn05);
            this.panelSpeedMunu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpeedMunu.Location = new System.Drawing.Point(0, 478);
            this.panelSpeedMunu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSpeedMunu.Name = "panelSpeedMunu";
            this.panelSpeedMunu.Size = new System.Drawing.Size(150, 110);
            this.panelSpeedMunu.TabIndex = 8;
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn15.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn15.ForeColor = System.Drawing.SystemColors.Control;
            this.btn15.Location = new System.Drawing.Point(0, 58);
            this.btn15.Margin = new System.Windows.Forms.Padding(2);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(150, 26);
            this.btn15.TabIndex = 3;
            this.btn15.Text = "1.5x";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btnNM
            // 
            this.btnNM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNM.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNM.Location = new System.Drawing.Point(0, 32);
            this.btnNM.Margin = new System.Windows.Forms.Padding(2);
            this.btnNM.Name = "btnNM";
            this.btnNM.Size = new System.Drawing.Size(150, 26);
            this.btnNM.TabIndex = 5;
            this.btnNM.Text = "Normal";
            this.btnNM.UseVisualStyleBackColor = false;
            this.btnNM.Click += new System.EventHandler(this.btnNM_Click);
            // 
            // btn05
            // 
            this.btn05.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn05.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn05.ForeColor = System.Drawing.SystemColors.Control;
            this.btn05.Location = new System.Drawing.Point(0, 0);
            this.btn05.Margin = new System.Windows.Forms.Padding(2);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(150, 32);
            this.btn05.TabIndex = 4;
            this.btn05.Text = "0.5x";
            this.btn05.UseVisualStyleBackColor = false;
            this.btn05.Click += new System.EventHandler(this.btn05_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Gainsboro;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 447);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(150, 31);
            this.button11.TabIndex = 7;
            this.button11.Text = "Exit";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Gainsboro;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 416);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(150, 31);
            this.button10.TabIndex = 6;
            this.button10.Text = "Help";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panelToolSubMenu
            // 
            this.panelToolSubMenu.Controls.Add(this.btnSpeed);
            this.panelToolSubMenu.Controls.Add(this.button9);
            this.panelToolSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolSubMenu.Location = new System.Drawing.Point(0, 337);
            this.panelToolSubMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelToolSubMenu.Name = "panelToolSubMenu";
            this.panelToolSubMenu.Size = new System.Drawing.Size(150, 79);
            this.panelToolSubMenu.TabIndex = 5;
            // 
            // btnSpeed
            // 
            this.btnSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpeed.FlatAppearance.BorderSize = 0;
            this.btnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeed.ForeColor = System.Drawing.Color.LightGray;
            this.btnSpeed.Location = new System.Drawing.Point(0, 40);
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnSpeed.Size = new System.Drawing.Size(150, 31);
            this.btnSpeed.TabIndex = 1;
            this.btnSpeed.Text = "Speed";
            this.btnSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(150, 40);
            this.button9.TabIndex = 1;
            this.button9.Text = "Cut and Merge Music";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnTool
            // 
            this.btnTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTool.FlatAppearance.BorderSize = 0;
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTool.Image = ((System.Drawing.Image)(resources.GetObject("btnTool.Image")));
            this.btnTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.Location = new System.Drawing.Point(0, 295);
            this.btnTool.Margin = new System.Windows.Forms.Padding(2);
            this.btnTool.Name = "btnTool";
            this.btnTool.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnTool.Size = new System.Drawing.Size(150, 42);
            this.btnTool.TabIndex = 4;
            this.btnTool.Text = "Tool";
            this.btnTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.Controls.Add(this.button5);
            this.panelPlaylistSubMenu.Controls.Add(this.button6);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 216);
            this.panelPlaylistSubMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(150, 79);
            this.panelPlaylistSubMenu.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 40);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(150, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Delete Playlist";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.LightGray;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(150, 40);
            this.button6.TabIndex = 1;
            this.button6.Text = "Create Playlist";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 185);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(150, 31);
            this.btnPlaylist.TabIndex = 2;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediasubmenu
            // 
            this.panelMediasubmenu.Controls.Add(this.button3);
            this.panelMediasubmenu.Controls.Add(this.button2);
            this.panelMediasubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediasubmenu.Location = new System.Drawing.Point(0, 106);
            this.panelMediasubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMediasubmenu.Name = "panelMediasubmenu";
            this.panelMediasubmenu.Size = new System.Drawing.Size(150, 79);
            this.panelMediasubmenu.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(150, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "Open Folder";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open File";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnMedia.Image")));
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Location = new System.Drawing.Point(0, 65);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(150, 41);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panel1Logo
            // 
            this.panel1Logo.Controls.Add(this.pictureBox1);
            this.panel1Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1Logo.Location = new System.Drawing.Point(0, 0);
            this.panel1Logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel1Logo.Name = "panel1Logo";
            this.panel1Logo.Size = new System.Drawing.Size(150, 65);
            this.panel1Logo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(673, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 581);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(429, 558);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 26);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(349, 557);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(53, 28);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(150, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(523, 581);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // ptb_imagemusic
            // 
            this.ptb_imagemusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_imagemusic.Location = new System.Drawing.Point(150, 0);
            this.ptb_imagemusic.Name = "ptb_imagemusic";
            this.ptb_imagemusic.Size = new System.Drawing.Size(524, 536);
            this.ptb_imagemusic.TabIndex = 7;
            this.ptb_imagemusic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 581);
            this.Controls.Add(this.ptb_imagemusic);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelSpeedMunu.ResumeLayout(false);
            this.panelToolSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelMediasubmenu.ResumeLayout(false);
            this.panel1Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagemusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1Logo;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panelMediasubmenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panelToolSubMenu;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPlaylist;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSpeedMunu;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btnNM;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox ptb_imagemusic;
    }
}

