﻿using Media_Player_APP.Model;
using Media_Player_APP.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Media_Player_APP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            customizeDesing();

            Load();
            LoadPlaylist();
        }

        public void Load()
        {
            
            flpmusic.Controls.Clear();
            if(Dataprovider.Ins.mediaPlayer.MUSICs != null)
            {
                foreach (MUSIC music in Dataprovider.Ins.mediaPlayer.MUSICs)
                {
                    Image image = Image.FromFile(music.IMAGE);
                    ItemMusic im = new ItemMusic(music.NAME, image,music.FILEPATH);
                    im.Tag = music;
                    im.Click += clickitem;
                    flpmusic.Controls.Add(im);
                }
            }    

        }        
        public void LoadPlaylist()
        {
            lb_playlist.Items.Clear();
            if (Dataprovider.Ins.mediaPlayer.PLAYLISTs != null)
            {
                foreach (PLAYLIST playlist in Dataprovider.Ins.mediaPlayer.PLAYLISTs)
                {
                    lb_playlist.Items.Add(playlist.NAME);
                }
            }
        }
        public void clickitem(object sender, EventArgs e)
        {
            ItemMusic clickedItem = (ItemMusic)sender;
            MUSIC Musicinfo = (MUSIC)clickedItem.Tag;
            axWindowsMediaPlayer1.URL = Musicinfo.FILEPATH;
            Image img = Image.FromFile(Musicinfo.IMAGE);
            ptb_imagemusic.BackgroundImage = img;
        }

        private void customizeDesing()
        {
            panelMediasubmenu.Visible = false;
            panelPlaylistSubMenu.Visible = false; 
            panelToolSubMenu.Visible = false;
            panelSpeedMunu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelMediasubmenu.Visible == true)
                panelMediasubmenu.Visible = false; 
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolSubMenu.Visible == true)
                panelToolSubMenu.Visible = false;
            if (panelSpeedMunu.Visible == true)
                panelSpeedMunu.Visible = false;
        }

        private void showSubmenu(Panel SubMenu) 
        {
            if (SubMenu.Visible == false)
            {
                hideSubmenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMediasubmenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPlaylistSubMenu);
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            showSubmenu(panelToolSubMenu);
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSpeedMunu);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {     
        }

        private void btn_addmusic_Click(object sender, EventArgs e)
        {
            Form form = new AddMusic();
            form.Show();

            form.FormClosed += (s, args) => Load();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            List<MUSIC> list = Dataprovider.Ins.mediaPlayer.MUSICs.ToList();

            //if (listBox1.SelectedIndex >= 1)
            //{
            //    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            //    axWindowsMediaPlayer1.URL = list[listBox1.SelectedIndex].FILEPATH;
            //    string fileImage = list[listBox1.SelectedIndex].IMAGE;
            //    Image image = Image.FromFile(fileImage);

            //    ptb_imagemusic.BackgroundImage = image;
            //}
            //else
            //{
            //    listBox1.SelectedIndex = listBox1.Items.Count - 1;
            //    axWindowsMediaPlayer1.URL = list[listBox1.SelectedIndex].FILEPATH;
            //}

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //if(listBox1.SelectedIndex <= listBox1.Items.Count -2)
            //{
            //    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            //}
            //else
            //{
            //    listBox1.SelectedIndex = 0;                 
            //}         
        }


        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //int currentIndex = listBox1.SelectedIndex;
                //if (currentIndex < listBox1.Items.Count - 1)
                //{
                //    listBox1.SelectedIndex = currentIndex + 1;
                //}
                //else
                //{
                //    listBox1.SelectedIndex = 0;
                //}
            }
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.settings.rate = 0.5;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            hideSubmenu();
        }

        private void btnNM_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.settings.rate = 1.0;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            hideSubmenu();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.settings.rate = 1.5;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            hideSubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdit formEdit = new FormEdit();

            formEdit.ShowDialog();

            this.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Addplaylist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_addplaylist.Text))
            {
                MessageBox.Show("Chưa nhập thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool playlistExists = false;

                foreach (PLAYLIST playlist in Dataprovider.Ins.mediaPlayer.PLAYLISTs)
                {
                    if (tb_addplaylist.Text == playlist.NAME)
                    {
                        MessageBox.Show("Playlist đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        playlistExists = true;
                        break; // Không cần kiểm tra tiếp nếu đã tìm thấy playlist trùng khớp
                    }
                }

                if (!playlistExists)
                {
                    Dataprovider.Ins.mediaPlayer.PLAYLISTs.Add(new PLAYLIST() { NAME = tb_addplaylist.Text });
                    Dataprovider.Ins.mediaPlayer.SaveChanges();
                    if(MessageBox.Show("Nhập playlist thành công", "Thông Báo", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        LoadPlaylist();
                        tb_addplaylist.Text = string.Empty;
                        this.Refresh();
                    }
                }
            }
        }

        private void lb_playlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadPlaylist(PLAYLIST pLAYLIST)
        {
                flpmusic.Controls.Clear();
                if (pLAYLIST.MUSICs != null)
                {
                    foreach (MUSIC music in pLAYLIST.MUSICs)
                    {
                        Image image = Image.FromFile(music.IMAGE);
                        ItemMusic im = new ItemMusic(music.NAME, image, music.FILEPATH);
                        im.Tag = music;

                        im.Click += clickitem;
                        flpmusic.Controls.Add(im);
                    }
                }
        }

        private void lb_playlist_DoubleClick(object sender, EventArgs e)
        {
            
            if(lb_playlist.SelectedIndex != -1)
            {
                int choose = lb_playlist.SelectedIndex;
                string playlist = lb_playlist.Items[choose].ToString();
                foreach(PLAYLIST list in Dataprovider.Ins.mediaPlayer.PLAYLISTs)
                {
                    if(list.NAME == playlist)
                    {
                        loadPlaylist(list);
                        break;
                    }
                }
            }
        }
    }
}
