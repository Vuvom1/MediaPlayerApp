using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_APP.Model
{
    public class Dataprovider
    {
        private static Dataprovider _ins;

        public static Dataprovider Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new Dataprovider();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }

        public MediaPlayer mediaPlayer { get; set; }

        private Dataprovider()
        {
            mediaPlayer = new MediaPlayer();
        }
    }
}
