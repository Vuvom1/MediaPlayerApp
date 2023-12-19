using Media_Player_APP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_APP
{
    public partial class AddMusic : Form
    {
       
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string FilePath;
        string FileName;
        string FileImage;
        string pathimage;

        public AddMusic()
        {
            InitializeComponent();
        }
     
        private void btn_addmusic_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "chọn music";

            openFileDialog.Filter = "file nhạc (*.mp3, *.mp4)|*.mp*";

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                // Lấy tên file
                FileName = openFileDialog.SafeFileName;
                tb_namemusic.Text = openFileDialog.FileName;


            }
        }

        private void ptb_addImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "chọn ảnh";

            openFileDialog.Filter = "Ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileImage = openFileDialog.FileName;

                pathimage = Path.GetFileName(FileImage); 

                Image image = Image.FromFile(FileImage);
                ptb_addImage.BackgroundImage = image;
            }
        }



        private void btn_save_Click(object sender, EventArgs e)
        {

            if (FilePath != "" && FileImage != "" && FileName != "")
            {
                Dataprovider.Ins.mediaPlayer.MUSICs.Add(new MUSIC() { FILEPATH = FileName, IMAGE = pathimage, NAME = FileName });
                Dataprovider.Ins.mediaPlayer.SaveChanges();
                this.Close();
            }

        }

    }
}
