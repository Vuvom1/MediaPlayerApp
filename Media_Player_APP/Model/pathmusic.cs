using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_APP.Model
{
    public class pathmusic
    {
        public string getParentofParentPath(string path)
        {
            string newPath = path;
            for (int i = 0; i < 2; i++)
            {
                newPath = Path.GetDirectoryName(newPath);
                if (string.IsNullOrEmpty(newPath)) // Kiểm tra nếu đã đến thư mục gốc
                {
                    break;
                }
            }
            return newPath;
        }


        public string LoadMusic(string path)
        {
            string appFolderPath = Application.StartupPath;

            string newPath = getParentofParentPath(appFolderPath);

            // Tên tệp tin ảnh
            string pathmusic = newPath + "\\music\\" + path;

            return pathmusic;
        }
        public string Loadimg(string path)
        {
            string appFolderPath = Application.StartupPath;

            string newPath = getParentofParentPath(appFolderPath);

            // Tên tệp tin ảnh
            string pathimage = newPath + "\\Resources\\" + path;

            return pathimage;
        }
    }

}
