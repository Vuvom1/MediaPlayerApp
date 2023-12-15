using Media_Player_APP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
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
        }

        public void Load()
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            listBox1.Items.Clear();

            if (mediaPlayer != null)
            {
                foreach (MUSIC music in mediaPlayer.MUSICs)
                {
                    listBox1.Items.Add(music.NAME);

                }
            }
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
        //OpenFileDialog openFileDialog;
        //string[] filePaths;
        //string[] fileNames;
        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new AddMusic();
            form.Show();

            form.FormClosed += (s, args) => Load();
        }

        //đường dãn tương đối

       

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                MediaPlayer mediaMediaPlayer = new MediaPlayer();
                List<MUSIC> list = mediaMediaPlayer.MUSICs.ToList();

                int choose = listBox1.SelectedIndex;
                {
                    for (int i =0; i < list.Count; i++)
                    {
                        if (choose == i)
                        {
                            string filepath = list[i].FILEPATH;
                            string fileImage = list[i].IMAGE;
                            Image image = Image.FromFile(fileImage);

                            axWindowsMediaPlayer1.URL = filepath;
                            ptb_imagemusic.BackgroundImage = image;
                        }
                    }
                }
            }
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
            if (listBox1.SelectedIndex >= 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
            else
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex <= listBox1.Items.Count -2)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            else
            {
                listBox1.SelectedIndex = 0;                 
            }         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                //int choose = listBox1.SelectedIndex;
                //axWindowsMediaPlayer1.URL = filePaths[choose];
                //axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                int currentIndex = listBox1.SelectedIndex;
                if (currentIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = currentIndex + 1;
                }
                else
                {
                    listBox1.SelectedIndex = 0;
                }
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
    }
}
