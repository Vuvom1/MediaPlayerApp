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
using WMPLib;

namespace Media_Player_APP
{
    public partial class Form1 : Form
    {
        MediaPlayer mediaPlayer = new MediaPlayer();
        public Form1()
        {
            InitializeComponent();
            customizeDesing();

            Loaddata();
        }

        public void Loaddata()
        {
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
        OpenFileDialog openFileDialog;
        string[] filePaths;
        string[] fileNames;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
                fileNames = openFileDialog.SafeFileNames;
                foreach (var item in fileNames)
                {
                    this.listBox1.Items.Add(item);

                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int choose = listBox1.SelectedIndex;
                              
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
    }
}
