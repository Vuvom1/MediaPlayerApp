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
            this.ptb_imgmusic = new System.Windows.Forms.PictureBox();
            this.lb_titlemusic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imgmusic)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_imgmusic
            // 
            this.ptb_imgmusic.BackgroundImage = global::Media_Player_APP.Properties.Resources._10_ngan_nam;
            this.ptb_imgmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_imgmusic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ptb_imgmusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptb_imgmusic.Location = new System.Drawing.Point(0, 0);
            this.ptb_imgmusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_imgmusic.Name = "ptb_imgmusic";
            this.ptb_imgmusic.Size = new System.Drawing.Size(161, 148);
            this.ptb_imgmusic.TabIndex = 1;
            this.ptb_imgmusic.TabStop = false;
            // 
            // lb_titlemusic
            // 
            this.lb_titlemusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_titlemusic.AutoEllipsis = true;
            this.lb_titlemusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlemusic.Location = new System.Drawing.Point(179, 61);
            this.lb_titlemusic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_titlemusic.Name = "lb_titlemusic";
            this.lb_titlemusic.Size = new System.Drawing.Size(220, 27);
            this.lb_titlemusic.TabIndex = 2;
            this.lb_titlemusic.Text = "10 ngàn năm";
            // 
            // ItemMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.lb_titlemusic);
            this.Controls.Add(this.ptb_imgmusic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemMusic";
            this.Size = new System.Drawing.Size(456, 148);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imgmusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox ptb_imgmusic;
        private System.Windows.Forms.Label lb_titlemusic;
    }
}
