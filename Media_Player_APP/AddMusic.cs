using Media_Player_APP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_APP
{
    public partial class AddMusic : Form
    {
        public MUSIC music = new MUSIC();
       
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string FilePath;
        string FileName;
        string FileImage;

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
                music.FILEPATH = FilePath;
                // Lấy tên file
                FileName = openFileDialog.SafeFileName;
                music.NAME = FileName;
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
                music.IMAGE = FileImage;
                Image image = Image.FromFile(FileImage);
                ptb_addImage.BackgroundImage = image;
            }
        }



        private void btn_save_Click(object sender, EventArgs e)
        {

            if (music.FILEPATH != "" && music.IMAGE != "" && music.NAME != "")
            {
                MediaPlayer mediaPlayer = new MediaPlayer();
                mediaPlayer.MUSICs.Add(new MUSIC() { FILEPATH = FilePath, IMAGE = FileImage, NAME = FileName });
                mediaPlayer.SaveChanges();
                this.Close();
            }

        }

    }
}
