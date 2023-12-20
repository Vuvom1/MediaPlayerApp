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

namespace Media_Player_APP.UC
{
    public partial class ItemMusic : UserControl
    {
        MUSIC Music = new MUSIC();
        public ItemMusic()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            cbb_playlist.Items.Clear();
            if (Dataprovider.Ins.mediaPlayer.PLAYLISTs != null)
            {
                foreach(PLAYLIST playlist in Dataprovider.Ins.mediaPlayer.PLAYLISTs)
                {
                    cbb_playlist.Items.Add(playlist.NAME);
                }
            }
        }

        public ItemMusic(string titlemusic, Image imagemusic, string pathmusic)
        {
            InitializeComponent();
            this.titlemusic = titlemusic;
            this.imagemusic = imagemusic;
            Load();
            Music.NAME = titlemusic;
            Music.FILEPATH = pathmusic;

        }

        public string titlemusic
        {
            get { return lb_titlemusic.Text; }
            set { lb_titlemusic.Text = value; }
        }

        public Image imagemusic
        {
            get { return ptb_imgmusic.BackgroundImage; }
            set { this.ptb_imgmusic.BackgroundImage = value; }
        }

        public string pathmusic
        {
            get { return this.pathmusic; }
            set { this.pathmusic = value; }
        }

        private void lb_titlemusic_Click(object sender, EventArgs e)
        {

        }

        private void ptb_yes_Click(object sender, EventArgs e)
        {
            if (cbb_playlist.SelectedItem != null)
            {
                string selectedPlaylist = cbb_playlist.SelectedItem.ToString();
                foreach (PLAYLIST playlist in Dataprovider.Ins.mediaPlayer.PLAYLISTs)
                {
                    if (selectedPlaylist == playlist.NAME)
                    {
                        foreach (MUSIC music in Dataprovider.Ins.mediaPlayer.MUSICs)
                        {

                            if (music.NAME == Music.NAME && music.FILEPATH == Music.FILEPATH)
                            {
                                playlist.MUSICs.Add(music);
                                MessageBox.Show("thêm thành công", "thông báo", MessageBoxButtons.OK);
                                break;
                            }
                        }
                    }
                }
            }
                    Dataprovider.Ins.mediaPlayer.SaveChanges();
            this.Refresh();
        }

        private void ptb_no_Click(object sender, EventArgs e)
        {
            if (cbb_playlist.SelectedItem == null)
            {
                if (MessageBox.Show("Bạn có muốn xóa nó không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    foreach (MUSIC music in Dataprovider.Ins.mediaPlayer.MUSICs)
                    {
                        if (music.NAME == Music.NAME && music.FILEPATH == Music.FILEPATH)
                        {
                            Dataprovider.Ins.mediaPlayer.MUSICs.Remove(music);
                            break;
                        }
                    }
                }
                Dataprovider.Ins.mediaPlayer.SaveChanges();
            }
            if (cbb_playlist.SelectedItem != null)
            {
                pathmusic Pathmusic = new pathmusic();
                string selectedPlaylist = cbb_playlist.SelectedItem.ToString();
                foreach (PLAYLIST playlist in Dataprovider.Ins.mediaPlayer.PLAYLISTs)
                {
                    if (selectedPlaylist == playlist.NAME)
                    {
                        foreach (MUSIC music in Dataprovider.Ins.mediaPlayer.MUSICs)
                        {
                            string path = Pathmusic.LoadMusic(music.FILEPATH);
                            if (music.NAME == Music.NAME && Music.FILEPATH == path)
                            {
                                playlist.MUSICs.Remove(music);
                                MessageBox.Show("xóa thành công khỏi playlist", "thông báo", MessageBoxButtons.OK);
                                break;
                            }
                        }
                        break;
                    }
                }
                Dataprovider.Ins.mediaPlayer.SaveChanges();
            }
        }
    }
}
