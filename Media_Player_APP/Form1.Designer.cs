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
            this.lb_playlist = new System.Windows.Forms.ListBox();
            this.Addplaylist = new System.Windows.Forms.Label();
            this.tb_addplaylist = new System.Windows.Forms.TextBox();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediasubmenu = new System.Windows.Forms.Panel();
            this.btn_addmusic = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panel1Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpmusic = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ptb_imagemusic = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 565);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSpeedMunu
            // 
            this.panelSpeedMunu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSpeedMunu.Controls.Add(this.btn15);
            this.panelSpeedMunu.Controls.Add(this.btnNM);
            this.panelSpeedMunu.Controls.Add(this.btn05);
            this.panelSpeedMunu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpeedMunu.Location = new System.Drawing.Point(0, 456);
            this.panelSpeedMunu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnNM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn05.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button11.Location = new System.Drawing.Point(0, 425);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button10.Location = new System.Drawing.Point(0, 394);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panelToolSubMenu.Location = new System.Drawing.Point(0, 315);
            this.panelToolSubMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(150, 40);
            this.button9.TabIndex = 1;
            this.button9.Text = "Edit";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnTool
            // 
            this.btnTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTool.FlatAppearance.BorderSize = 0;
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTool.Image = ((System.Drawing.Image)(resources.GetObject("btnTool.Image")));
            this.btnTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.Location = new System.Drawing.Point(0, 273);
            this.btnTool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panelPlaylistSubMenu.Controls.Add(this.lb_playlist);
            this.panelPlaylistSubMenu.Controls.Add(this.Addplaylist);
            this.panelPlaylistSubMenu.Controls.Add(this.tb_addplaylist);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 194);
            this.panelPlaylistSubMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(150, 79);
            this.panelPlaylistSubMenu.TabIndex = 3;
            // 
            // lb_playlist
            // 
            this.lb_playlist.FormattingEnabled = true;
            this.lb_playlist.Location = new System.Drawing.Point(0, 32);
            this.lb_playlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_playlist.Name = "lb_playlist";
            this.lb_playlist.Size = new System.Drawing.Size(150, 43);
            this.lb_playlist.TabIndex = 2;
            this.lb_playlist.SelectedIndexChanged += new System.EventHandler(this.lb_playlist_SelectedIndexChanged);
            this.lb_playlist.DoubleClick += new System.EventHandler(this.lb_playlist_DoubleClick);
            // 
            // Addplaylist
            // 
            this.Addplaylist.AutoEllipsis = true;
            this.Addplaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addplaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addplaylist.Location = new System.Drawing.Point(128, 4);
            this.Addplaylist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addplaylist.Name = "Addplaylist";
            this.Addplaylist.Size = new System.Drawing.Size(18, 23);
            this.Addplaylist.TabIndex = 1;
            this.Addplaylist.Text = "+";
            this.Addplaylist.Click += new System.EventHandler(this.Addplaylist_Click);
            // 
            // tb_addplaylist
            // 
            this.tb_addplaylist.Location = new System.Drawing.Point(2, 7);
            this.tb_addplaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_addplaylist.Name = "tb_addplaylist";
            this.tb_addplaylist.Size = new System.Drawing.Size(122, 20);
            this.tb_addplaylist.TabIndex = 0;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 148);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(150, 46);
            this.btnPlaylist.TabIndex = 2;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediasubmenu
            // 
            this.panelMediasubmenu.Controls.Add(this.btn_addmusic);
            this.panelMediasubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediasubmenu.Location = new System.Drawing.Point(0, 106);
            this.panelMediasubmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMediasubmenu.Name = "panelMediasubmenu";
            this.panelMediasubmenu.Size = new System.Drawing.Size(150, 42);
            this.panelMediasubmenu.TabIndex = 1;
            // 
            // btn_addmusic
            // 
            this.btn_addmusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addmusic.FlatAppearance.BorderSize = 0;
            this.btn_addmusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addmusic.ForeColor = System.Drawing.Color.LightGray;
            this.btn_addmusic.Location = new System.Drawing.Point(0, 0);
            this.btn_addmusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addmusic.Name = "btn_addmusic";
            this.btn_addmusic.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_addmusic.Size = new System.Drawing.Size(150, 40);
            this.btn_addmusic.TabIndex = 1;
            this.btn_addmusic.Text = "Open File";
            this.btn_addmusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addmusic.UseVisualStyleBackColor = true;
            this.btn_addmusic.Click += new System.EventHandler(this.btn_addmusic_Click);
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
            this.btnMedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panel1Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1Logo.Name = "panel1Logo";
            this.panel1Logo.Size = new System.Drawing.Size(150, 65);
            this.panel1Logo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flpmusic
            // 
            this.flpmusic.AutoScroll = true;
            this.flpmusic.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpmusic.Location = new System.Drawing.Point(700, 0);
            this.flpmusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpmusic.Name = "flpmusic";
            this.flpmusic.Size = new System.Drawing.Size(455, 565);
            this.flpmusic.TabIndex = 9;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(150, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(550, 565);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // ptb_imagemusic
            // 
            this.ptb_imagemusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_imagemusic.Location = new System.Drawing.Point(150, 0);
            this.ptb_imagemusic.Name = "ptb_imagemusic";
            this.ptb_imagemusic.Size = new System.Drawing.Size(550, 520);
            this.ptb_imagemusic.TabIndex = 7;
            this.ptb_imagemusic.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(182, 537);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(25, 21);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(205, 539);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 20);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 565);
            this.Controls.Add(this.ptb_imagemusic);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.flpmusic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelSpeedMunu.ResumeLayout(false);
            this.panelToolSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.PerformLayout();
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
        private System.Windows.Forms.Button btn_addmusic;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panelToolSubMenu;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSpeedMunu;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btnNM;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox ptb_imagemusic;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public System.Windows.Forms.FlowLayoutPanel flpmusic;
        private System.Windows.Forms.Label Addplaylist;
        private System.Windows.Forms.TextBox tb_addplaylist;
        private System.Windows.Forms.ListBox lb_playlist;
    }
}

