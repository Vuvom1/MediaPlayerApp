namespace Media_Player_APP.UC
{
    partial class ItemMusic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_titlemusic = new System.Windows.Forms.Label();
            this.cbb_playlist = new System.Windows.Forms.ComboBox();
            this.ptb_no = new System.Windows.Forms.PictureBox();
            this.ptb_yes = new System.Windows.Forms.PictureBox();
            this.ptb_imgmusic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imgmusic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titlemusic
            // 
            this.lb_titlemusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_titlemusic.AutoEllipsis = true;
            this.lb_titlemusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlemusic.Location = new System.Drawing.Point(177, 32);
            this.lb_titlemusic.Name = "lb_titlemusic";
            this.lb_titlemusic.Size = new System.Drawing.Size(165, 28);
            this.lb_titlemusic.TabIndex = 2;
            this.lb_titlemusic.Text = "10 ngàn năm";
            // 
            // cbb_playlist
            // 
            this.cbb_playlist.FormattingEnabled = true;
            this.cbb_playlist.Location = new System.Drawing.Point(142, 97);
            this.cbb_playlist.Name = "cbb_playlist";
            this.cbb_playlist.Size = new System.Drawing.Size(187, 21);
            this.cbb_playlist.TabIndex = 3;
            // 
            // ptb_no
            // 
            this.ptb_no.BackgroundImage = global::Media_Player_APP.Properties.Resources.cancel2;
            this.ptb_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_no.Location = new System.Drawing.Point(365, 93);
            this.ptb_no.Name = "ptb_no";
            this.ptb_no.Size = new System.Drawing.Size(26, 24);
            this.ptb_no.TabIndex = 5;
            this.ptb_no.TabStop = false;
            this.ptb_no.Click += new System.EventHandler(this.ptb_no_Click);
            // 
            // ptb_yes
            // 
            this.ptb_yes.BackgroundImage = global::Media_Player_APP.Properties.Resources.checkmarks3;
            this.ptb_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_yes.Location = new System.Drawing.Point(335, 93);
            this.ptb_yes.Name = "ptb_yes";
            this.ptb_yes.Size = new System.Drawing.Size(24, 25);
            this.ptb_yes.TabIndex = 4;
            this.ptb_yes.TabStop = false;
            this.ptb_yes.Click += new System.EventHandler(this.ptb_yes_Click);
            // 
            // ptb_imgmusic
            // 
            this.ptb_imgmusic.BackgroundImage = global::Media_Player_APP.Properties.Resources._10_ngan_nam;
            this.ptb_imgmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_imgmusic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ptb_imgmusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptb_imgmusic.Location = new System.Drawing.Point(0, 0);
            this.ptb_imgmusic.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_imgmusic.Name = "ptb_imgmusic";
            this.ptb_imgmusic.Size = new System.Drawing.Size(121, 139);
            this.ptb_imgmusic.TabIndex = 1;
            this.ptb_imgmusic.TabStop = false;
            // 
            // ItemMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.ptb_no);
            this.Controls.Add(this.ptb_yes);
            this.Controls.Add(this.cbb_playlist);
            this.Controls.Add(this.lb_titlemusic);
            this.Controls.Add(this.ptb_imgmusic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemMusic";
            this.Size = new System.Drawing.Size(438, 139);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imgmusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox ptb_imgmusic;
        private System.Windows.Forms.Label lb_titlemusic;
        private System.Windows.Forms.ComboBox cbb_playlist;
        private System.Windows.Forms.PictureBox ptb_yes;
        private System.Windows.Forms.PictureBox ptb_no;
    }
}
