using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

using System.Net;
namespace task_4
{
    public class WebStrategy : IImageLoaderStrategy
    {
        public Image Load(string href)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("https://i.pinimg.com/564x/b5/a8/66/b5a8665da40cabdcd2b96490fee62bbf.jpg");
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}