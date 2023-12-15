namespace Media_Player_APP
{
    partial class AddMusic
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
            this.tb_namemusic = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addmusic = new System.Windows.Forms.Button();
            this.ptb_addImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_addImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_namemusic
            // 
            this.tb_namemusic.Location = new System.Drawing.Point(26, 350);
            this.tb_namemusic.Multiline = true;
            this.tb_namemusic.Name = "tb_namemusic";
            this.tb_namemusic.ReadOnly = true;
            this.tb_namemusic.Size = new System.Drawing.Size(263, 32);
            this.tb_namemusic.TabIndex = 8;
            this.tb_namemusic.Text = "Path music";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(172, 414);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 53);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addmusic
            // 
            this.btn_addmusic.Location = new System.Drawing.Point(316, 350);
            this.btn_addmusic.Name = "btn_addmusic";
            this.btn_addmusic.Size = new System.Drawing.Size(80, 32);
            this.btn_addmusic.TabIndex = 5;
            this.btn_addmusic.Text = "Thêm nhạc";
            this.btn_addmusic.UseVisualStyleBackColor = true;
            this.btn_addmusic.Click += new System.EventHandler(this.btn_addmusic_Click);
            // 
            // ptb_addImage
            // 
            this.ptb_addImage.BackgroundImage = global::Media_Player_APP.Properties.Resources.choosemusic;
            this.ptb_addImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_addImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_addImage.Location = new System.Drawing.Point(57, 12);
            this.ptb_addImage.Name = "ptb_addImage";
            this.ptb_addImage.Size = new System.Drawing.Size(304, 311);
            this.ptb_addImage.TabIndex = 6;
            this.ptb_addImage.TabStop = false;
            this.ptb_addImage.Click += new System.EventHandler(this.ptb_addImage_Click);
            // 
            // AddMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 488);
            this.Controls.Add(this.tb_namemusic);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.ptb_addImage);
            this.Controls.Add(this.btn_addmusic);
            this.Name = "AddMusic";
            this.Text = "AddMusic";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_addImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_namemusic;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox ptb_addImage;
        private System.Windows.Forms.Button btn_addmusic;
    }
}