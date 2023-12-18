using AxWMPLib;
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
        public ItemMusic()
        {
            InitializeComponent();
        }

        public ItemMusic(string titlemusic,Image imagemusic,string pathmusic)
        {
            InitializeComponent();
            this.titlemusic = titlemusic;
            this.imagemusic = imagemusic;
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
    }
}
