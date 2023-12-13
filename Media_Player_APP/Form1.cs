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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
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
    }
}
